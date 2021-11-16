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
        private readonly XmlParsers.Context _xmlParserContext = new();
        public const string XML_FILE = @"C:\Users\268\source\repos\XML\timetable.xml";
        public const string XSL_FILE = @"C:\Users\268\source\repos\XML\transform.xsl";
        public const string HTML_FILE = @"C:\Users\268\source\repos\XML\timetable.html";

        public Window() => InitializeComponent();

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDom.Checked)
                _xmlParserContext.CurrentParser = new XmlParsers.DomParser(XML_FILE);
            else if (radioButtonSax.Checked)
                _xmlParserContext.CurrentParser = new XmlParsers.SaxParser(XML_FILE);
            else if (radioButtonLinqToXml.Checked)
                _xmlParserContext.CurrentParser = new XmlParsers.LinqToXmlParser(XML_FILE);
            buttonProcess.Visible = true;
            ClearResults();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (!groupBoxFilters.Visible)
            {
                foreach (ComboBox cb in new[] {comboBoxGroupName,comboBoxDayIndex,comboBoxPairIndex,
                                          comboBoxSubgroup,comboBoxWeek,comboBoxFormat,
                                          comboBoxSubject,comboBoxTeacherName})
                    cb.Items.Add("");
                foreach (string s in _xmlParserContext.GetAttributeValues("group_name"))
                    comboBoxGroupName.Items.Add(s);
                foreach (string s in _xmlParserContext.GetAttributeValues("day_index"))
                    comboBoxDayIndex.Items.Add(s);
                foreach (string s in _xmlParserContext.GetAttributeValues("pair_index"))
                    comboBoxPairIndex.Items.Add(s);
                foreach (string s in _xmlParserContext.GetAttributeValues("subgroup"))
                    comboBoxSubgroup.Items.Add(s);
                foreach (string s in _xmlParserContext.GetAttributeValues("week"))
                    comboBoxWeek.Items.Add(s);
                foreach (string s in _xmlParserContext.GetAttributeValues("format"))
                    comboBoxFormat.Items.Add(s);
                foreach (string s in _xmlParserContext.GetAttributeValues("subject").OrderBy(x => x))
                    comboBoxSubject.Items.Add(s);
                foreach (string s in _xmlParserContext.GetAttributeValues("teacher_name").OrderBy(x => x))
                    comboBoxTeacherName.Items.Add(s);
                groupBoxFilters.Visible = true;
                buttonProcess.Text = "Шукати";
            }
            else
            {
                ClearResults();
                richTextBoxResults.Visible = false;
                foreach (Lesson lesson in _xmlParserContext.FilterLessons(
                            comboBoxGroupName.Text, comboBoxDayIndex.Text, comboBoxPairIndex.Text,
                            comboBoxSubgroup.Text, comboBoxWeek.Text, comboBoxFormat.Text,
                            comboBoxSubject.Text, comboBoxTeacherName.Text))
                {
                    void WriteText(string text, bool bold)
                    {
                        richTextBoxResults.SelectionFont = new("Segoe UI", 9F,
                            bold ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point);
                        richTextBoxResults.AppendText(text);
                    }
                    void AddRow(string name, string value)
                    {
                        WriteText(name + ": ", bold: true);
                        WriteText(value + "\n", bold: false);
                    }
                    AddRow("Група", lesson.GroupName);
                    AddRow("День", lesson.DayIndex);
                    AddRow("Пара", lesson.PairIndex);
                    AddRow("Підгрупа", lesson.Subgroup);
                    AddRow("Тиждень", lesson.Week);
                    AddRow("Формат", lesson.Format);
                    AddRow("Предмет", lesson.Subject);
                    AddRow("Викладачі", string.Join("", from teacher in lesson.TeacherNames select "\n" + teacher));
                    WriteText("\n", false);
                }
                richTextBoxResults.Visible = true;
            }
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (e.Cancel = !comboBox.Items.Contains(comboBox.Text))
                MessageBox.Show("Оберіть значення з випадаючого списку");
        }

        private void ClearResults(object sender = null, EventArgs e = null)
            => richTextBoxResults.Clear();

        private void buttonHtml_Click(object sender, EventArgs e)
        {
            XslTransformer.Transform(XML_FILE, XSL_FILE, HTML_FILE);
            Process.Start("explorer.exe", HTML_FILE);
        }
    }
}