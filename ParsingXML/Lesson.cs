using System.Collections.Generic;
using System.Linq;

namespace ParsingXML
{
    struct Lesson
    {
        public string GroupName, DayIndex, PairIndex, Subgroup, Week, Format, Subject;
        public IEnumerable<string> TeacherNames;

        public bool Matches(string groupName, string dayIndex, string pairIndex,
                            string subgroup, string week, string format,
                            string subject, string teacherName)
            => (groupName == "" || groupName == GroupName)
            && (dayIndex == "" || dayIndex == DayIndex)
            && (pairIndex == "" || pairIndex == PairIndex)
            && (subgroup == "" || subgroup == Subgroup)
            && (week == "" || week == Week)
            && (format == "" || format == Format)
            && (subject == "" || subject == Subject)
            && (teacherName == "" || TeacherNames.Contains(teacherName));
    }
}
