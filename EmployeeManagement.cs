using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Classi
{
    public class EmployeeManagement
    {
        public static string path { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Employees.csv");//percorso file da leggere
        //Lettura di tutti gli employees
        public static Employee[] GetAllEmployee() 
        {
            int totalLines = File.ReadLines(path).Count();  //totale delle righe del file
            Employee[] employees = new Employee[totalLines - 1]; //array di tutti gli employee, -1 perchè parto da 1
            string line; //singola riga

            using(StreamReader reader = File.OpenText(path))
            {
                string header = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    for(int i =0; i < totalLines-1; i++)  //-1 perchè parto da 0
                    {
                        line = reader.ReadLine();  //leggi la prima riga, quindi primo employee
                        string[] employeeData = line.Split(","); //togli la virgola
                        Employee employee = new Employee  //creo l'employee
                        {
                            FirstName = employeeData[0],
                            LastName = employeeData[1],
                            Role = employeeData[2],
                            Department = employeeData[3]
                        };

                        employees[i] = employee;
                    }
                }

            }
            return employees;
        }

        //filtro per nome gli employees
        public static Employee[] EmployeeFilterName(out int count)
        {
            Console.WriteLine("Inserisci il nome dell'Employee che vuoi cercare: ");
            string name = Console.ReadLine();
            Employee[] allEmployee = GetAllEmployee();
            Employee[] employeeFilterName = new Employee[allEmployee.Length];
            int j = 0;
            count = 0;

            for (int i = 0; i < allEmployee.Length; i++)
            {
                if(allEmployee[i].FirstName == name)
                {
                    employeeFilterName[j] = allEmployee[i];
                    j++;
                }
            }

            count = j;
            return employeeFilterName;
        }

        //aggiungere un nuovo employee sul file
        public static bool InsertEmployee(Employee employee)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(employee.FirstName + "," + employee.LastName + "," + employee.Role + "," + employee.Department);
                }
                Console.WriteLine("Employee aggiunto correttamente");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool DeleteEmployee(Employee employee)
        {
            int j = 0;
            try
            {
                int totalLines = File.ReadLines(path).Count();
                Employee[] AllEmployee = GetAllEmployee();
                ArrayList newEmployeeList = new ArrayList();

                for(int i =0; i< totalLines- 1; i++)
                {
                    if(!(AllEmployee[i].FirstName == employee.FirstName && AllEmployee[i].LastName == employee.LastName &&
                        AllEmployee[i].Role == employee.Role && AllEmployee[i].Department == employee.Department))
                    {
                        newEmployeeList.Add(AllEmployee[i]);
                    }
                }
                using(StreamWriter writer = File.CreateText(path))
                {
                    writer.WriteLine("firstName,lastName,role,department");
                    foreach (Employee e in newEmployeeList)
                    {
                        writer.WriteLine(e.FirstName + "," + e.LastName + "," + e.Role + "," + e.Department);
                    }
                }
                Console.WriteLine("Employee eliminato correttamente");
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
