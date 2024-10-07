using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Salon.user
{
    public class Angajat :User
    {
        private int _id_angajat;
        private string _name;
        private float _salariu;
        private string _type_serv;

        public Angajat(string Propietati) : base(Propietati)
        {
            string[] text = Propietati.Split(',');
            _id_angajat = int.Parse(text[5]);
            _name = text[6];
            _salariu = float.Parse(text[7]);
            _type_serv = text[8];

        }
        public Angajat()
        {

        }

        public int IdAng
        {
            get { return _id_angajat; }
            set { _id_angajat = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Salariu
        {
            get { return _salariu; }
            set { _salariu = value; }
        }

        public string TypeServ
        {
            get { return _type_serv; }
            set { _type_serv = value; }
        }

        public override string ToString()
        {
            string t = " "+base.ToString();
            t += "Id: " + IdAng + "\n";
            t += "Name: " + Name + "\n";
            t += "Salariul: " + Salariu + "\n";
            t += "Serviciul Cerut:" + TypeServ + "\n";
            return t;

        }

        public int CompareTo(Angajat other)
        {
            if (_id_angajat > other._id_angajat)
            {
                return 1;
            }

            if (_id_angajat < other._id_angajat)
            {
                return -1;

            }

            return 0;

        }


        public class AngajatBuilder
        {
            private readonly Angajat _angajat;

            public AngajatBuilder(Angajat ang)
            {
                _angajat =ang;

            }
            public static AngajatBuilder Create()
            {

                return new AngajatBuilder(new Angajat());

            }
            public AngajatBuilder SetnameAngajat(string name)
            {
                _angajat.Name = name;
                return this;

            }
            public AngajatBuilder SetSalariuAnfajat(float salariul)
            {
                _angajat.Salariu = salariul;

                return this;
            }

            public AngajatBuilder SetServiciePerson(string type)
            {

                _angajat.TypeServ = type;

                return this;

            }

            public Angajat Build()
            {
                return _angajat;
            }














        }


        public override bool Equals(object angajat)
        {
            return angajat is Angajat other && this.Name.Equals(other.Name);
        }











    }
}
