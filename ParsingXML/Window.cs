using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsingXML
{
    public partial class Window : Form
    {
        private bool _initialized = false;
        private XmlParsers.Context _xmlParserContext = new();
        public const string XML_FILE= @"C:\Users\268\source\repos\XML\timetable.xml";
        public const string XSL_FILE= @"C:\Users\268\source\repos\XML\transform.xsl";
        public const string HTML_FILE= @"C:\Users\268\source\repos\XML\timetable.html";

        public Window()
        {
            InitializeComponent();
        }

        private void Process()
        {
            if (!_initialized)
            {
                foreach (var s in _xmlParserContext.GetAttributeValues("group_name"))
                    comboBox2.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("day_index"))
                    comboBox1.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("pair_index"))
                    comboBoxPairIndex.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("subgroup"))
                    comboBoxSubgroup.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("week"))
                    comboBoxWeek.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("format"))
                    comboBoxFormat.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("subject").OrderBy(x => x))
                    comboBoxSubject.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("teacher_name").OrderBy(x => x))
                    comboBoxTeacherName.Items.Add(s);
                _initialized = true;
                labelAnalyze.Text = "Шукати за допомогою:";
                groupBoxFilters.Visible = true;
            }
            else
            {

            }
        }

        private void buttonDom_Click(object sender, EventArgs e)
        {
            _xmlParserContext.CurrentParser = new XmlParsers.DomParser(XML_FILE);
            Process();
        }

        private void buttonSax_Click(object sender, EventArgs e)
        {
            _xmlParserContext.CurrentParser = new XmlParsers.SaxParser(XML_FILE);
            Process();
        }

        private void buttonLinqToXml_Click(object sender, EventArgs e)
        {
            _xmlParserContext.CurrentParser = new XmlParsers.LinqToXmlParser(XML_FILE);
            Process();
        }
    }
}
