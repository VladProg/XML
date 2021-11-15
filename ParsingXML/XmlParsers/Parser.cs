using System.Collections.Generic;

namespace ParsingXML.XmlParsers
{
    abstract class Parser
    {
        public readonly string FileName;
        public Parser(string fileName)
            => FileName = fileName;
        public abstract IEnumerable<string> GetAttributeValues(string attributeName);
        public abstract IEnumerable<Lesson> FilterLessons(string groupName, string dayIndex, string pairIndex,
                                                          string subject, string week, string subgroup,
                                                          string format, string teacherName);
    }
}
