using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ParsingXML.XmlParsers
{
    class DomParser : Parser
    {
        public DomParser(string fileName) : base(fileName) { }

        public override IEnumerable<string> GetAttributeValues(string attributeName)
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(FileName);
            List<string> result = new();
            GetAttributeValuesRecursion(xmlDoc.DocumentElement, attributeName, result);
            return result.Distinct();
        }

        private static void GetAttributeValuesRecursion(XmlNode node, string attributeName, List<string> result)
        {
            foreach (XmlAttribute attribute in node.Attributes)
                if (attribute.Name == attributeName)
                    result.Add(attribute.Value);
            foreach (XmlNode child in node.ChildNodes)
                GetAttributeValuesRecursion(child, attributeName, result);
        }

        public override IEnumerable<Lesson> FilterLessons(string groupName, string dayIndex, string pairIndex,
                                                          string subject, string week, string subgroup,
                                                          string format, string teacherName)
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(FileName);

            string xPath = "/timetable";

            xPath += "/group";
            if (groupName != "")
                xPath += $"[@group_name='{groupName}']";

            xPath += "/day";
            if (dayIndex != "")
                xPath += $"[@day_index='{dayIndex}']";

            xPath += "/pair";
            if (pairIndex != "")
                xPath += $"[@pair_index='{pairIndex}']";

            xPath += "/lesson";
            if (subject != "")
                xPath += $"[@subject='{subject}']";
            if (week != "")
                xPath += $"[@week='{week}']";
            if (subgroup != "")
                xPath += $"[@subgroup='{subgroup}']";
            if (format != "")
                xPath += $"[@format='{format}']";

            if(teacherName!="")
                xPath += $"[teacher[@teacher_name='{teacherName}']]";

            foreach (XmlNode lesson in xmlDoc.SelectNodes(xPath))
            {
                Lesson current = new()
                {
                    GroupName = lesson.SelectSingleNode("ancestor::group").Attributes["group_name"].Value,
                    DayIndex = lesson.SelectSingleNode("ancestor::day").Attributes["day_index"].Value,
                    PairIndex = lesson.SelectSingleNode("ancestor::pair").Attributes["pair_index"].Value,
                    Subject = lesson.Attributes["subject"].Value,
                    Week = lesson.Attributes["week"].Value,
                    Subgroup = lesson.Attributes["subgroup"].Value,
                    Format = lesson.Attributes["format"].Value,
                    TeacherNames = new List<string>()
                };
                foreach (XmlNode teacher in lesson.SelectNodes("teacher"))
                    (current.TeacherNames as List<string>).Add(teacher.Attributes["teacher_name"].Value);
                yield return current;
            }
        }
    }
}
