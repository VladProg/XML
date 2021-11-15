from requests import get
import sys

old_stdout = sys.stdout
sys.stdout = open(r'C:\Users\268\source\repos\XML\timetable.xml', 'w', encoding='utf-8')

groups = get('https://api.mytimetable.live/rest/groups/?faculty=1&univ=1').json()['results']
groups.sort(key=lambda l: l['name'])

print(f'<?xml version="1.0" encoding="utf-8"?>')
print(f'<timetable>')
for g in groups:
    name = g['name']
    print(name, file=old_stdout)
    lessons = get('https://api.mytimetable.live/rest/timetable/?group=' + g['slug']).json()['lessons']
    days = [{} for _ in range(5)]
    for l in lessons:
        d = l['day']
        i = l['lesson_time']
        l['week'] = 'Обидва' if '11' in l['weeks'] else 'Непарний' if l['weeks'].find('1') % 2 == 0 else 'Парний'
        l['format'] = ['Лекція', 'Семінар', 'Практика', 'Лабораторна'][l['format']]
        l['subgroup'] = l['subgroup'] or '-'
        if i not in days[d]:
            days[d][i] = []
        days[d][i] += [l]
    print(f'    <group group_name="{name}">')
    for d in range(5):
        day = ['Понеділок', 'Вівторок', 'Середа', 'Четвер', 'П\'ятниця'][d]
        print(f'        <day day_index="{day}">')
        for i in sorted(days[d]):
            print(f'            <pair pair_index="{i}">')
            for l in sorted(days[d][i], key=lambda l: (l['week'], l['subgroup'])):
                print(
                    f'                <lesson '
                    f'subgroup="{l["subgroup"]}" '
                    f'week="{l["week"]}" '
                    f'format="{l["format"]}" '
                    f'subject="{l["name_full"]}"'
                    f'>')
                for t in l['teachers']:
                    print(f'                    <teacher teacher_name="{t["full_name"]}"/>')
                print(f'                </lesson>')
            print(f'            </pair>')
        print(f'        </day>')
    print(f'    </group>')
    # break
print(f'</timetable>')

sys.stdout.close()
sys.stdout = old_stdout
print('end')
