using System.Collections.Generic;
using System.Linq;

namespace ParsingXML
{
    struct Lesson
    {
        public string GroupName, DayIndex, PairIndex, Subject, Week, Subgroup, Format;
        public IEnumerable<string> TeacherNames;

        public bool Matches(string groupName, string dayIndex, string pairIndex,
                            string subject, string week, string subgroup,
                            string format, string teacherName)
            => (groupName == "" || groupName == GroupName)
            && (dayIndex == "" || dayIndex == DayIndex)
            && (pairIndex == "" || pairIndex == PairIndex)
            && (subject == "" || subject == Subject)
            && (week == "" || week == Week)
            && (subgroup == "" || subgroup == Subgroup)
            && (format == "" || format == Format)
            && (teacherName == "" || TeacherNames.Contains(teacherName));
    }
}
