using System.Collections.Generic;

namespace ParsingXML.XmlParsers
{
    class Context
    {
        public Parser CurrentParser { private get; set; }

        public bool Initialized => CurrentParser is not null;

        public IEnumerable<string> GetAttributeValues(string attributeName)
            => CurrentParser.GetAttributeValues(attributeName);

        public IEnumerable<Lesson> FilterLessons(string groupName, string dayIndex, string pairIndex,
                                                 string subject, string week, string subgroup,
                                                 string format, string teacherName)
            => CurrentParser.FilterLessons(groupName, dayIndex, pairIndex, subject, week, subgroup, format, teacherName);
    }
}
