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
                foreach(Lesson lesson in _xmlParserContext.FilterLessons(
                            comboBoxGroupName.Text, comboBoxDayIndex.Text, comboBoxPairIndex.Text,
                            comboBoxSubgroup.Text, comboBoxWeek.Text, comboBoxFormat.Text,
                            comboBoxSubject.Text, comboBoxTeacherName.Text))
                {
                    Label CreateLabel(string text, bool bold)
                    {
                        Label label = new();
                        label.Text = text;
                        label.Font = new("Segoe UI", 9F, bold ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point);
                        label.AutoSize = true;
                        return label;
                    }

                    FlowLayoutPanel CreateRow(string name, string value)
                    {
                        FlowLayoutPanel row;
                        row = new();
                        row.Controls.Add(CreateLabel(name + ": ", bold: true));
                        row.Controls.Add(CreateLabel(value, bold: false));
                        row.AutoSize = true;
                        row.Dock = DockStyle.Top;
                        return row;
                    }

                    GroupBox result = new();
                    result.Controls.Add(CreateRow("Група", lesson.GroupName));
                    result.Controls.Add(CreateRow("День", lesson.DayIndex));
                    result.Controls.Add(CreateRow("Пара", lesson.PairIndex));
                    result.Controls.Add(CreateRow("Підгрупа", lesson.Subgroup));
                    result.Controls.Add(CreateRow("Тиждень", lesson.Week));
                    result.Controls.Add(CreateRow("Формат", lesson.Format));
                    result.Controls.Add(CreateRow("Предмет", lesson.Subject));
                    result.Dock = DockStyle.Top;
                    result.AutoSize = true;
                    panelResults.Controls.Add(result);
                }
                //richTextBoxResults.Text = string.Join("\n",
                //    from lesson in _xmlParserContext.FilterLessons(
                //        comboBoxGroupName.Text, comboBoxDayIndex.Text, comboBoxPairIndex.Text,
                //        comboBoxSubgroup.Text, comboBoxWeek.Text, comboBoxFormat.Text,
                //        comboBoxSubject.Text, comboBoxTeacherName.Text)
                //    select $"Група: {lesson.GroupName}\n" +
                //           $"День: {lesson.DayIndex}\n" +
                //           $"Пара: {lesson.PairIndex}\n" +
                //           $"Підгрупа: {lesson.Subgroup}\n" +
                //           $"Тиждень: {lesson.Week}\n" +
                //           $"Формат: {lesson.Format}\n" +
                //           $"Предмет: {lesson.Subject}\n" +
                //           $"Викладачі:\n{string.Join('\n', lesson.TeacherNames)}\n"
                //    );
            }
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (e.Cancel = !comboBox.Items.Contains(comboBox.Text))
                MessageBox.Show("Оберіть значення з випадаючого списку");
        }

        private void ClearResults(object sender = null, EventArgs e = null)
            => panelResults.Controls.Clear();

        private void buttonHtml_Click(object sender, EventArgs e)
        {
            XslTransformer.Transform(XML_FILE, XSL_FILE, HTML_FILE);
            Process.Start("explorer.exe", HTML_FILE);
        }
    }
}