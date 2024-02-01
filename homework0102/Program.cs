#region TASK1
using homework0102;

Dictionary<string, DateTime> exams = new Dictionary<string, DateTime>();
exams.Add("Python", new DateTime(2024, 2, 1, 2, 0, 0));
exams.Add("Html", new DateTime(2024, 2, 8, 9, 0, 0));
exams.Add("Css", new DateTime(2024, 2, 16, 10, 0, 0));
exams.Add("C#", new DateTime(2024, 2, 27, 9, 0, 0));
exams.Add("Sql", new DateTime(2024, 1,4 , 3, 0, 0));

foreach(var item in exams)
{
    TimeSpan stayDate = item.Value - DateTime.Now;
    if (stayDate < TimeSpan.Zero)
    {
        Console.WriteLine("Fənn: "+item.Key+" "+item.Value.ToString("(dd.MM.yyyy)")+" "+"Imtahan vaxti bitmisdir");
    }
    else
    {
        Console.WriteLine("Fənn: " + item.Key + " -  " + item.Value.ToString("(dd.MM.yyyy)") + " " + stayDate.Days + " Gün qalıb");
    }
}
#endregion
#region TASK2
Library library = new Library();
string opt;

do
{
    ShowMenu();
    opt = Console.ReadLine();
    switch (opt)
    {
        case "1":
         
            library.AddBook();
            break;
        case "2":
            library.RemoveBook();
            break;
        case "3":
            library.ShowBook();
                break;
        case "4":
            library.SpesfkShowBook();
            break;
        case "0":
            Console.WriteLine("Əməliyyat bitmişdir");
            break;
        default:
            Console.WriteLine("Əməliyyat yanlisdir!");
            break;
    }

} while (opt != "0");

static void ShowMenu()
{
    Console.WriteLine("\n======Menu======");
    Console.WriteLine("1.Kitab əlavə et");
    Console.WriteLine("2.Kitab sil");
    Console.WriteLine("3.Butun kitablara bax");
    Console.WriteLine("4.Secilmis kitaba bax");
    Console.WriteLine("0.Əməliyyatı bitir");
    Console.Write("Secim edin  ");
}

#endregion



