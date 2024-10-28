using PersonalDetails.Models;
using System.Reflection.Metadata.Ecma335;

namespace PersonalDetails.Classes
{
    public class ProcessDetails
    {
        public static Task<ResponseObject> GetResponse(DateTime dOB, string fullName)
        {
            var response = new ResponseObject()
            {
                Age = GetAge(dOB),
                Vowels = GetVowelCount(fullName),
                DaysUntillBirthday = GetDaysUntilBirthday(dOB),
                Days14 = Get14Days(dOB)
            };
            return Task.FromResult(response);
        }

        public static int GetVowelCount(string fullName)
        {
            HashSet<char> list = ['a', 'e', 'i', 'o', 'u', 'ä', 'ö', 'ü', 'à', 'è', 'ì', 'ò', 'ù'];
            int count = 0;
            foreach (char c in fullName)
            {
                if (list.Contains(c))
                    count++;
            }
            return count;
        }

        public static int GetAge(DateTime dOB)
        {
            return DateTime.Now.Year -  dOB.Year;
        }

        public static int GetDaysUntilBirthday(DateTime dOB)
        {
            DateTime birthday = dOB;
            birthday = birthday.AddYears(DateTime.Now.Year - dOB.Year);
            
            birthday  = birthday > DateTime.Now ? birthday : birthday.AddYears(1);
            
            return (birthday - DateTime.Now).Days + 1;
        }

        public static List<string> Get14Days(DateTime dOB)
        {
            DateTime birthday = dOB;
            birthday = birthday.AddYears(DateTime.Now.Year - dOB.Year);

            birthday = birthday > DateTime.Now ? birthday : birthday.AddYears(1);

            var list = new List<string>();
            for (int i = -14; i< 0; i++)
            {
                list.Add(birthday.AddDays(i).DayOfWeek.ToString());
            }
            return list;
        }

    }
}
