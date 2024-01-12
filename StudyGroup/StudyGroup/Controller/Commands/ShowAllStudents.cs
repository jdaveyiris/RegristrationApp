using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGroup.Commands
{
    public class ShowAllStudents
    {
        public static void ShowAll(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Attendance Recorded: {student.AttendanceRecorded}");
                Console.WriteLine($"Attendance Value: {student.AttendanceValue}");
                Console.WriteLine();
            }
        }
    }
}
