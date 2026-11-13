using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities.Enums;

[Flags]
public enum StudentStatus
{
    None = 0,          // Не задано (недопустимо при сохранении)
    Active = 1 << 0,     // Обучается
    Budget = 1 << 1,     // Бюджетная форма
    Paid = 1 << 2,     // Платная форма
    OnLeave = 1 << 3,     // Академический отпуск
    Expelled = 1 << 4,     // Отчислен
    Graduate = 1 << 5,     // Выпускник
    HasScholarship = 1 << 6,     // Получает стипендию
    ForeignStudent = 1 << 7,     // Иностранный студент
    Orphan = 1 << 8,     // Сирота (льготы)
    Disabled = 1 << 9      // Студент с ОВЗ (льготы)
}