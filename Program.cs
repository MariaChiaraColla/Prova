using System;

namespace Classi
{
    class Program
    {
        static void Main(string[] args)
        {
                        //PERSON

            //Person persona = new Person();
            ////Console.WriteLine(persona.FirstName + " " + persona.LastName + " " + persona.Age);
            //Console.WriteLine(persona.GetFullName());

            //persona.FirstName = "Matilde";
            //persona.LastName = "Pluto";
            //persona.Age = 30;
            ////Console.WriteLine(persona.FirstName + " " + persona.LastName + " " + persona.Age);
            //Console.WriteLine(persona.GetFullName());

            //Person[] Persone = new Person[5];
            //Random random = new Random();


                        //ARRAY DI PERSON 

            //for (int i = 0; i < 5; i++)
            //{
            //    //Persone[i] = new Person();
            //    //Persone[i].FirstName = "Pippo" + i+1;
            //    //Persone[i].LastName = "Cognome" + ((i+1)*2);
            //    //Persone[i].Age = random.Next(1, 99);
            //    //Console.WriteLine(Persone[i].GetFullName());
            //    Person PersonaDaInserire = new Person()
            //    {
            //        FirstName = "Pippo" + (i + 1),
            //        LastName = "Cognome" + (2 * (i + 1)),
            //        Age = random.Next(1, 99)
            //    };
            //    Persone[i] = PersonaDaInserire;
            //}

            //foreach(Person person in Persone)
            //{
            //    Console.WriteLine(person.GetFullName());
            //}


                        //PERSON CON CONTACTS( E ADDRESS)

            //persona.Contacts = new Contacts
            //{
            //    PhoneNumber = 123,
            //    Email = "prova@ciao.it",
            //    Address = new Address
            //    {
            //        City = "Milano",
            //        State = "Italy",
            //        ZipCode = 20100
            //    }
            //};
            //Console.WriteLine(persona.GetFullName() + " " + persona.Contacts.Address.City);
            //Console.WriteLine("");


            //get all employ (lettura da file) e filtro per nome

            //Employee[] employee = EmployeeManagement.GetAllEmployee();
            //foreach(Employee emp in employee)
            //{
            //    Console.WriteLine(emp.StampaEmployee());
            //}

            //Employee[] employeeFilterName = EmployeeManagement.EmployeeFilterName(out int count);
            //for(int i = 0; i<count; i++)
            //{
            //    Console.WriteLine(employeeFilterName[i].StampaEmployee());
            //}

            //Inserisci nuovo employee
            //Employee employeeDaAggiungere = new Employee
            //{
            //    FirstName = "Anna",
            //    LastName = "Rossi",
            //    Role = "UI Designer",
            //    Department = "IT"
            //};
            //EmployeeManagement.InsertEmployee(employeeDaAggiungere);

            //Employee[] employee2 = EmployeeManagement.GetAllEmployee();
            //foreach (Employee emp in employee2)
            //{
            //    Console.WriteLine(emp.StampaEmployee());
            //}

            Employee employeeDaEliminare = new Employee
            {
                FirstName = "Anna",
                LastName = "Rossi",
                Role = "UI Designer",
                Department = "IT"
            };
            EmployeeManagement.DeleteEmployee(employeeDaEliminare);

            Employee[] employee3 = EmployeeManagement.GetAllEmployee();
            foreach (Employee emp in employee3)
            {
                Console.WriteLine(emp.StampaEmployee());
            }
        }
    }
}
