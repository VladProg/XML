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
        private XmlParsers.Context _xmlParserContext = new();
        public const string XML_FILE= @"C:\Users\268\source\repos\XML\timetable.xml";
        public const string XSL_FILE= @"C:\Users\268\source\repos\XML\transform.xsl";
        public const string HTML_FILE= @"C:\Users\268\source\repos\XML\timetable.html";

        public Window()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool initialized = _xmlParserContext.Initialized;
            if (radioButtonDom.Checked)
                _xmlParserContext.CurrentParser = new XmlParsers.DomParser(XML_FILE);
            else if (radioButtonSax.Checked)
                _xmlParserContext.CurrentParser = new XmlParsers.SaxParser(XML_FILE);
            else if (radioButtonLinqToXml.Checked)
                _xmlParserContext.CurrentParser = new XmlParsers.LinqToXmlParser(XML_FILE);
            if (!initialized)
            {
                foreach (var s in _xmlParserContext.GetAttributeValues("group_name"))
                    comboBoxGroupName.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("day_index"))
                    comboBoxDayIndex.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("pair_index"))
                    comboBoxPairIndex.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("subject").OrderBy(x => x))
                    comboBoxSubject.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("week"))
                    comboBoxWeek.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("subgroup"))
                    comboBoxSubgroup.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("format"))
                    comboBoxFormat.Items.Add(s);
                foreach (var s in _xmlParserContext.GetAttributeValues("teacher_name").OrderBy(x => x))
                    comboBoxTeacherName.Items.Add(s);
            }
        }
    }
}
