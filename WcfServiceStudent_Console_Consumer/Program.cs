using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceStudent_Console_Consumer.ServiceReferenceStudent;

namespace WcfServiceStudent_Console_Consumer
{
    class Program
    {
        /// <summary>
        /// Vi tilføjer en Service Reference som peger på vores web service på localhost.
        /// Dette gøres ved at "paste" stien til wsdl-filen: http://localhost:51241/ServiceStudent.svc?wsdl
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (ServiceStudentClient client = new ServiceStudentClient("BasicHttpBinding_IServiceStudent"))
            {
                Student[] students = client.GetAllStudents();
                foreach (var stud in students)
                {
                    Console.WriteLine(stud.Id + "\t" + stud.Name + "\t" + stud.Klasse);
                }

                Student stud1 = client.GetStudentById(3);
                Console.WriteLine($"\nStuderende med Id 3 er : {stud1.Name}");

            }
        }
    }
}
