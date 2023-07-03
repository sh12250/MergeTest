using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitMerge
{
    // {        2023. 07. 03. Modified class position / Alpha
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
    // }        2023. 07. 03. Modified class position / Alpha
    // commit test
    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }
}
