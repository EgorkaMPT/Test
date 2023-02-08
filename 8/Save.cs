using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Save
    {
        static int sec;
        static int ID = 1;
        static string Name;
        static List<Users> rez = new List<Users>();
        public static void Sohrani()
        {
            Console.Clear();
            Console.WriteLine("Результаты: ");
            rez.Sort((x, y) =>
            {
                int ret = String.Compare($"{y.Min}", $"{x.Min}");
                return ret != 0 ? ret :
                x.Min.CompareTo(y.Min);
            });
            foreach (Users a in rez)
            {
                Console.WriteLine($"Имя: {a.Name}\nРезультат в минуту: {a.Min}\nРезультат в секунду: {a.Sec}\n");
                Sav();
            }
            Console.WriteLine($"\nЧтобы добавить новый результат нажмите  кнопку Tab");
        }
        public static void Sav()
        {
            File.WriteAllText("C:\\Users\\User\\OneDraive\\Рабочий стол\\1.json", JsonConvert.SerializeObject(rez));
        }
    }
}
