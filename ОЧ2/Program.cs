﻿
using System.Runtime.InteropServices;
using ОЧ2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Zalik zalik1 = new Zalik("OP", "Ярошко", 1000);
Zalik zalik2 = new Zalik("ТІ", "Заболоцький", 70);
Zalik zalik3 = new Zalik("Алгоритми", "Костів", 64); 
Zalik zalik4 = new Zalik("БД", "Костів", 59); 
Zalik zalik5 = new Zalik("ТІМС", "Притула", 47);
Exam exam1 = new Exam("OP", "Ярошко", "Assistant 1", 99);
Exam exam2 = new Exam("ТІ", "Заболоцький", "Assistant 2", 86);
Exam exam3 = new Exam("Алгоритми", "Костів", "Assistant 3", 75);
Exam exam4 = new Exam("БД", "Костів", "Assistant 4", 63);
Exam exam5 = new Exam("ТІМС", "Притула", "Assistant 5", 101);

List<Zalik> container = new List<Zalik>() { zalik1, zalik2, zalik3, zalik4, zalik5, exam1, exam2, exam3, exam4, exam5 };

InputDiscipline(container);

foreach (Zalik containerItem in container)
    Console.WriteLine(containerItem);

Console.WriteLine();

// Finds object with the greatest score
var bestSubject = new Zalik();
for(int i = 0; i < container.Count; i++)
{
    if (container[i] > bestSubject)
    {
        bestSubject = container[i];
    }
}

// Check out Exam type  
if (bestSubject.GetType() == typeof(Exam))
    Console.WriteLine("oject with te best score: Іспит");
else
    Console.WriteLine("oject with te best score: Залік");

if (bestSubject is Exam)
    Console.WriteLine("oject with te best score: Іспит");
else
    Console.WriteLine("oject with te best score: Залік");

// Differnce between total zaliks' and exams' scores
int totZaliks = 0;
int totExams = 0;
foreach (var containerItem in container)
{
    if(containerItem is Exam)
    {
        totExams += containerItem.Grade;
    }
    else
    {
        totZaliks += containerItem.Grade;
    }
}
Console.WriteLine($"\nDiffernce between total zaliks' and exams' scores equals to: {Math.Abs(totZaliks-totExams)}");

Zalik minFinal = container.Min();
Zalik maxFinal = container.Max();
Console.WriteLine($"The worst subject: {minFinal}");
Console.WriteLine($"The best subject: {maxFinal}");
Console.WriteLine($"Differnce between max and minimum finals' scores equals to: {maxFinal - minFinal}");

// Check on failed exams
int failedCounter = 0;

foreach (var containerItem in container)
{
    if (containerItem.Grade < 51)
        failedCounter++;
}

Console.WriteLine($"\nFailed exams: {failedCounter}");

// Create new collection based on a certain teacher
List<Zalik> teachersList = new List<Zalik>();
string teacherName = "Ярошко";
foreach (var containerItem in container)
{
    if (containerItem.Teacher == teacherName)
        teachersList.Add(containerItem);
}
Console.WriteLine($"\nІспити/заліки викладача {teacherName}:");
foreach (var item in teachersList)
    Console.WriteLine(item);

Console.WriteLine("\n\n");
container.Sort();
foreach (var item in container)
    Console.WriteLine(item);
Console.WriteLine("\n\n");


void InputDiscipline(List<Zalik> cnt)
{
    Console.WriteLine("Скільки елементів бажаєте ввести?");
    int amount = int.Parse(Console.ReadLine());
    for(int i = 0; i < amount; i++)
    {
        Console.WriteLine("Іспит чи залік? (і/z - english letters)");
        string type = Console.ReadLine();
        string subject;
        string teacher;
        string assistant = "";
        int score = 0;
        Console.WriteLine("Предмет: ");
        subject = Console.ReadLine();
        Console.WriteLine("Викладач: ");
        teacher = Console.ReadLine();
        Console.WriteLine("Бал: ");
        score = int.Parse(Console.ReadLine());
        if (type == "i")   // english "i"
        {
            Console.WriteLine("Асистент: ");
            assistant = Console.ReadLine();
            cnt.Add(new Exam(subject, teacher, assistant, score));
        }
        else
        {
            cnt.Add(new Zalik(subject, teacher, score));
        }
    }
}
