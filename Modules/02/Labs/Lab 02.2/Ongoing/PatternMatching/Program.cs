using System;
using System.Collections.Generic;
using System.Linq;
using Wincubate.CS8.Data;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            IEnumerable<Employee> employees = employeeRepository.GetAll();

            ////////////////////////////////////////////////////
            // a)
            // Write the Code Production Index for each employee
            ////////////////////////////////////////////////////

            Console.WriteLine("Code Production Index for each employee:");

            foreach (var employee in employees)
            {
                var workLine = employee switch
                {
                    SoftwareEngineer se => GetWorkLineForSoftwareEngineer(se),
                    SoftwareArchitect sa => GetWorkLineForSoftwareArchitect(sa),
                    _ => $"{employee.FullName}: 0",
                };

                Console.WriteLine(workLine);
            }

            ////////////////////////////////////////////////////////////////
            // b)
            // All student programmers mentored by a chief software engineer
            ////////////////////////////////////////////////////////////////

            Console.WriteLine("\nStudent programmers mentored by a chief software engineer:");
            IEnumerable<StudentProgrammer> mentionedStudents = GetMentionedStudents(employees);

            foreach (var student in mentionedStudents)
            {
                Console.WriteLine($"{student.FullName} mentored by chief");
            }
        }

        private static IEnumerable<StudentProgrammer> GetMentionedStudents(IEnumerable<Employee> employees)
        {
            return employees
                .Where(e => e is StudentProgrammer { MentoredBy: SoftwareEngineer { Level: Level.Chief } })
                .OfType<StudentProgrammer>();
        }

        private static string GetWorkLineForSoftwareEngineer(SoftwareEngineer se)
        {
            return $"{se.FullName}: {se.CodeLinesProduced}";
        }

        private static string GetWorkLineForSoftwareArchitect(SoftwareArchitect sa)
        {
            const int workMultiplierPerVisio = 250;
            int workProduced = sa.VisioDrawingsProduced * workMultiplierPerVisio;
            return $"{sa.FullName}: {workProduced}";
        }
    }
}
