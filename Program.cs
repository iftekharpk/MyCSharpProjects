using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string firstName = "Iftekhar";
            string lastName = "Ahmed";
            string dob = "Jun 25 2003";
            string add1 = "Kuril";
            string add2 = "Flyover";
            string city = "Dhaka";
            string state = "Dhaka";
            string country = "Bangladesh";
            int zip = 1290;

            Console.WriteLine("My Name is : " + firstName + " " + lastName);

            Console.WriteLine("My Date of Birth is : " + dob);

            Console.WriteLine("My Address is : " + add1 + " " + add2 + " \n" + "City : " + city + " \n" + "State : " + state + " \n" + "Country : " + country+" \n" + "Zip Code : " + zip);




        }
    }
}

