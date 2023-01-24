using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _931921.solomin.dmitrii.lab13.Models
{

    public class Questions
    {

        public int a { get; set; }
        public int b { get; set; }
        public int act { get; set; }
        public int answer { get; set; }
        public string problem { get; set; }
        [Required(ErrorMessage = "Не введен ответ")]
        [Range(-100, 100)]
        public string yanswer { get; set; }

        public Questions()
        {
            Random rnd = new Random();
            act = rnd.Next(4);
            a = rnd.Next(11);
            b = act == 3 ? rnd.Next(1, 11) : rnd.Next(0, 11);
            switch (act)
            {
                case 0:
                    answer = a * b;
                    problem = (a) + " * " + (b) + " =";
                    break;
                case 1:
                    answer = a + b;
                    problem = (a) + " + " + (b) + " =";
                    break;
                case 2:
                    answer = a - b;
                    problem = (a) + " - " + (b) + " =";
                    break;
                case 3:
                    answer = a / b;
                    problem = (a) + " / " + (b) + " =";
                    break;
            }
        }
    }

    public class IdentityMap
    {
        private static readonly IdentityMap Instance = new IdentityMap();
        List<Questions> actions = new List<Questions>();
        private IdentityMap() { }
        public static int alls;
        public static int rights;
        public static void Up()
        {
            Instance.actions.Clear();
            alls = 0;
            rights = 0;
        }
        public static void AddAction(Questions action)
        {
            Instance.actions.Add(action);
        }
        public static List<Questions> Get()
        {
            return Instance.actions;
        }
    }
}
