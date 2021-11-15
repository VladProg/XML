using System.Collections.Generic;

namespace ParsingXML.XmlParsers
{
    class Context
    {
        public Parser CurrentParser { private get; set; }

        public IEnumerable<string> GetAttributeValues(string attributeName)
            => CurrentParser.GetAttributeValues(attributeName);

        public IEnumerable<Lesson> FilterLessons(string groupName, string dayIndex, string pairIndex,
                                                 string subgroup, string week, string format,
                                                 string subject, string teacherName)
            => CurrentParser.FilterLessons(groupName, dayIndex, pairIndex, subgroup, week, format, subject, teacherName);
    }
}
