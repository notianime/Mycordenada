using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyApp
{
    public class Student
    {
        public string code {get; set;}
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
        
    class Program
    {
        public static void mycars()
        {
            // aqui mi codigo de carros
        }
        public static void mystudents()
        {
            // Aquí está la definición de una colección
            List<Student> mystudents = new List<Student>();

            Student mystudent = new Student();
            mystudent.code = "RROJASE";

            Student mystudent2 = new Student();
            mystudent2.code = "PEPITA2";

            MiEstudiante.Add(mystudent);
            mystudents.Add(mystudent2);
            //--------------------------------
            foreach (Student o in mystudents)
            {
                Console.WriteLine(o.code);
            }
            //--------------------------------
            for (int i = 0; i < mystudents.Count; i++)
            {
                Console.WriteLine(mystudents[i].code);
            }
            //--------------------------------

                Console.WriteLine(String.Format("Instancia Alumno: {0} {1}",
                    mystudent.code, "otro valor"));
        }
        static void Main(string[] args)
        {

            mystudents();
            mycars();

            Calculator mycalculator = new Calculator();
            double result = mycalculator.sum("10", "5");
            Console.Write(String.Format("..{0}", result));
            //string a = Console.ReadLine();

            //Console.Write(String.Format("..{0}", a));
            
            Console.ReadKey();

        }
    }
}
