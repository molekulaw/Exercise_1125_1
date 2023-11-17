using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Commands
{
    internal class CommandListStudents : CommandUser
    {
        StudentDB studentDB;

        public CommandListStudents(StudentDB studentDB)
        {
            this.studentDB = studentDB;
        }

        public override void Execute()
        {
            var students = studentDB.Search("");
            foreach (var student in students)
                Console.WriteLine($"{student.LastName} {student.FirstName} {student.UID}");
        }
    }
}
