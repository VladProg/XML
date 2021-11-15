using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ParsingXML.XmlParsers
{
    class SaxParser : Parser
    {
        public SaxParser(string fileName) : base(fileName) { }

        public override IEnumerable<string> GetAttributeValues(string attributeName)
        {
            using XmlTextReader xmlReader = new(FileName);
            List<string> result = new();
            while (xmlReader.Read())
                if (xmlReader.NodeType is XmlNodeType.Attribute && xmlReader.Name == attributeName)
                    result.Add(xmlReader.Value);
            return result.Distinct();
        }

        public override IEnumerable<Lesson> FilterLessons(string groupName, string dayIndex, string pairIndex,
                                                          string subgroup, string week, string format,
                                                          string subject, string teacherName)
        {
            using XmlTextReader xmlReader = new(FileName);
            Dictionary<string, string> attributes = new();
            List<string> teacherNames = new();
            while (xmlReader.Read())
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Attribute:
                        if (xmlReader.Name == "teacher_name")
                            teacherNames.Add(xmlReader.Value);
                        else
                            attributes[xmlReader.Name] = xmlReader.Value;
                        break;
                    case XmlNodeType.Element when xmlReader.Name == "lesson":
                        teacherNames.Clear();
                        break;
                    case XmlNodeType.EndElement when xmlReader.Name == "lesson":
                        Lesson current = new()
                        {
                            GroupName = attributes["group_name"],
                            DayIndex = attributes["day_index"],
                            PairIndex = attributes["pair_index"],
                            Subgroup = attributes["subgroup"],
                            Week = attributes["week"],
                            Format = attributes["format"],
                            Subject = attributes["subject"],
                            TeacherNames = teacherNames
                        };
                        if (current.Matches(groupName, dayIndex, pairIndex, subgroup, week, format, subject, teacherName))
                            yield return current;
                        break;
                }
        }
    }
}
