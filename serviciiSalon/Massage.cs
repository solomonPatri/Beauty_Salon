using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Salon.serviciiSalon
{
    public class Massage
    {
        private int _id;
        private string _name;
        private float _timpParcurs;
        private string _material;

        public int Id {
            get { return _id; } 
            set { _id = value; }
        }
        public string Name { 
            get { return _name; } 
            set { _name = value; }
        }
        public float TimpParcurs { 
            get {  return _timpParcurs; }
            set { _timpParcurs = value; }
            } 

        public string Material
    {
        get { return _material; }
        set { _material = value; }
    }



        public void Afisare()
        {
            Console.WriteLine(this.ToString());




        }
        public string ToString()
        {
            string t = " " + base.ToString();
            t += "Id: " + Id + "\n";
            t += "Name: " + Name + "\n";
            t += "Material folosit: " + Material + "\n";
            t += "TimpParcurs: " + TimpParcurs + "\n";
            return t;

        }


        public IServicii ReturnServicii()
        {
            Massage mj = new Massage();
            mj.Id = Id;
            mj.Name = Name;
            mj.TimpParcurs = TimpParcurs;
            mj.Material = Material;
            return mj;



        }

        public int CompareTo(Massage other)
        {
            if (_id > other._id)
            {
                return 1;
            }

            if (_id < other._id)
            {
                return -1;

            }

            return 0;

        }

        public override bool Equals(object profesor)
        {
            return profesor is Massage other && this.Name.Equals(other.Name);
        }

















    }
}
