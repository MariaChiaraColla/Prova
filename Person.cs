using System;
using System.Collections.Generic;
using System.Text;

namespace Classi
{
    public class Person
    {
        //Ordine del codice: campi, proprietà e metodi

        //Campi: quasi sempre privati, in questo caso scrivo i campi di default
        private string firstName = "Pippo";
        private string lastName = "Sconosciuto";  //se non c'è il valore di default non scrive niente

        private int age;

        //Proprietà: sono public e ci espongono i campi, dato che sono privati
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }  //value= qualunque valore
        }

        public string LastName
        {
            get { return lastName; }    //se tolgo il get non posso leggerlo (quindi writeLine non funziona) (write only)
            set { lastName = value; }  //se tolgo il set non posso fare persona.LastName = "Colla"; (read only)
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Contacts Contacts { get; set; }

        //Metodi

        public string GetFullName()
        {
            return firstName + " " + lastName + " " + age;
        }

    }
}
