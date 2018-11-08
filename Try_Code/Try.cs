using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Try_Code
{
    public class Try
    {
        //для ввода только чисел
        public static void PutTextNumbers(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex(@"[^0-9]+");
            e.Handled = reg.IsMatch(e.Text);
        }

        //проверка Email
        public static bool checkEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        //Для нахождения файла возле *.exe
        public static string newWay(string folder, string file)
        {
            string way = Assembly.GetExecutingAssembly().Location.Replace("", folder);
            way = way + file;
            return way;
        }

        //считает возраст
        public static int GetAge(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.DayOfYear < date.DayOfYear) //на случай, если день рождения ещё не наступил
            {
                age--;
            }
            return age;
        }

        //цикл по всему английскому алфавиту
        public static void Alphabet()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                //необходимый код
            }
        }

        //работа с Regex
        public static bool RegexWork(string r, string password)
        {
            Regex reg = new Regex(r);
            Match mat = reg.Match(password);
            return mat.Success;
        }
    }
}
