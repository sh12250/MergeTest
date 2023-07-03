using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            // {        2023. 07. 03.   Add user input / Beta
            string userInput = string.Empty;
            Console.WriteLine("This program convert Cm to Inch");
            Console.WriteLine("Input Cm Value");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            // }        2023. 07. 03.   Add user input / Beta
            ruler.Run();
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int CentiMeter { get; set; } = 0;
        public float Inch
        {
            get { return CentiMeter * ONE_INCH; }
            private set { CentiMeter = (int)(value / ONE_INCH); }
        }

        public Ruler(int cmValue)
        {
            CentiMeter = cmValue;
        }

        public void Run()
        {
            Console.WriteLine($"{this.CentiMeter}cm 는 {this.Inch}inch 입니다.");
        }
    }
}
