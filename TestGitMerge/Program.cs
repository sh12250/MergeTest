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
            Ruler ruler = new Ruler(10);
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
        // {        2023. 07. 03.       Add private _SetInch function / Gamma
            private set { this._SetInch(value); }
        }

        public Ruler(int cmValue)
        {
            CentiMeter = cmValue;
        }

        public void Run()
        {
            Console.WriteLine($"{this.CentiMeter}cm 는 {this.Inch}inch 입니다.");
        }

        private void _SetInch(float inchValue) { CentiMeter = (int)(inchValue / ONE_INCH); }
        // }        2023. 07. 03.       Add private _SetInch function / Gamma
    }
}
