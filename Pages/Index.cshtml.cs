using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        public User CurrentUser { get; set; }
        TemperatureManager manager = new TemperatureManager();

        public void OnGet()
        {
            CurrentUser = new User("Иван", "Иванов", new DateTime(1985, 5, 15), "ivan@example.com");
        }
       
      public string getTemperature()
        {
            return  manager.GetFormattedAverages();
        }  

       public string CompareStrings(string str1, string str2)
        {
            
            bool result1 = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
            bool result2 = str1.ToUpper() == str2.ToUpper();

            return $"Сравнение {str1} и {str2}:\n" +
                   $"Строки равны при ToUpper? {result2}\n" +
                   $"Строки равны при игнорировании регистра? {result1}";
        }

        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public  int GCD(int a, int b, int c)
        {
            return GCD(GCD(a, b), c);
        }
        public  string CheckPhrase() {
            string[] phrases = {
            "Действия говорят громче, чем слова.",
            "Привет!",
            "Python.",
            "PHP.",
            "random"
        };

            string str="";
            foreach (var phrase in phrases)
            {
                bool endsWithDot = EndsInDot(phrase);
               str+=$"'{phrase}' заканчивается точкой:{endsWithDot.ToString()}\n";
            }

            return str;
        }

        bool EndsInDot(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            return text.EndsWith(".");
        }
    }

}
        




