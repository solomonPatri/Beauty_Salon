using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Salon.user
{
    public class Client :User
    {
        private int _id_client;
        private string _name;
        private int _age;
        private string _address;

        public Client(string Propietati) : base(Propietati)
        {

            string[] text = Propietati.Split(',');

            _id_client = int.Parse(text[4]);
            _name = text[5];
            _age = int.Parse(text[6]);
            _address = text[7];

        }
        public Client()
        {

        }


        public int IdClient
        {
            get { return _id_client; }
            set { _id_client = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Adress
        {
            get { return _address; }
            set { _address = value; }
        }


        public override string ToString()
        {
            string t = " "+base.ToString();
            t += "IdClient: " + IdClient + "\n";
            t += "Name: " + Name + "\n";
            t += "Varsta: " + Age + "\n";
            t += "Adresa:" + Adress + "\n";
            return t;

        }


        public int CompareTo(Client other)
        {
            if (_id_client> other._id_client)
            {
                return 1;
            }

            if (_id_client < other._id_client)
            {
                return -1;

            }

            return 0;

        }

        public class ClientBuilder
        {
            private readonly Client _person;

            public ClientBuilder ()
            {
                _person = new Client();

            }

            public ClientBuilder SetNamePerson(string name)
            {
                _person.Name = name;
                return this;

            }
            public ClientBuilder SetAgePerson(int age)
            {
                _person.Age = age;

                return this;
            }

            public ClientBuilder SetAdressPerson(string adress)
            {

                _person.Adress = adress;

                return this;

            }

            public Client Build()
            {
                return _person;
            }














        }








    }
}
