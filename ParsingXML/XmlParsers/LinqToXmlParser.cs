using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ParsingXML.XmlParsers
{
    class LinqToXmlParser : Parser
    {
        public LinqToXmlParser(string fileName) : base(fileName) { }

        public override IEnumerable<string> GetAttributeValues(string attributeName)
        {
            XDocument doc = XDocument.Load(FileName);
            return (from element in doc.Descendants()
                    let attribute = element.Attribute(attributeName)
                    where attribute is not null && attribute.Name == attributeName
                    select attribute.Value).Distinct();
        }

        public override IEnumerable<Lesson> FilterLessons(string groupName, string dayIndex, string pairIndex,
                                                          string subject, string week, string subgroup,
                                                          string format, string teacherName)
        {
            XDocument doc = XDocument.Load(FileName);
            return from element in doc.Descendants()
                   where element.Name == "lesson"
                   let current = new Lesson()
                   {
                       GroupName = element.Parent.Parent.Parent.Attribute("group_name").Value,
                       DayIndex = element.Parent.Parent.Attribute("group_name").Value,
                       PairIndex = element.Parent.Attribute("group_name").Value,
                       Subject = element.Attribute("subject").Value,
                       Week = element.Attribute("week").Value,
                       Subgroup = element.Attribute("subgroup").Value,
                       Format = element.Attribute("format").Value,
                       TeacherNames = (from child in element.Descendants() select child.Attribute("teacher_name").Value)
                   }
                   where current.Matches(groupName, dayIndex, pairIndex, subject, week, subgroup, format, teacherName)
                   select current;
        }
    }
}
