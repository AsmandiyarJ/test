using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//31
namespace test
{
    public class PublicClass
    {

        public PublicClass()
        {
            Name = "DefaultName";
            //41
            Print(Name);

        }
        public string Name { get; set; }

        private string? field = "your name";

        public string Field
        {
            get { return field ?? string.Empty; }
            set { field = value; }
        }
        //38
        public void VoidMethod()
        {
            //42
            int resuilt = 0;
            IntMethod(resuilt);

        }
        //48
        public void VoidMethod(int aX)
        {
            //42
            int resuilt = 0;
            IntMethod(resuilt);

        }

        //39
        private int IntMethod(int ade)
        {
            return ade;
        }
        //40
        public static void Print(string print)
        {
            Console.WriteLine(print);
        }
    }

}

