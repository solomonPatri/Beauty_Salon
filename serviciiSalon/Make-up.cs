using Beauty_Salon.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Salon.serviciiSalon
{
    public class Make_up :IServicii
    {

        private string _type;
        private int _id;
        private string _culoare;
        public Make_up()
        {


        }
        private float _timpparcurs;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Culoare
        {
            get { return _culoare; }
            set { _culoare = value; }
        }
     
        public float Timpparcurs
        {
            get { return _timpparcurs;}
            set { _timpparcurs = value;}
        }


        public void Afisare()
        {
            Console.WriteLine(this.ToString());
            



        }
        public string ToString()
        {
            string t = " ";
            t += "Id: " + Id + "\n";
            t += "Type: " + Type + "\n";
            t += "Culoare: " + Culoare + "\n";
            t += "Timp parcurs: " +Timpparcurs + "\n";
           
            return t;

        }


        public IServicii ReturnServicii()
        {
                Make_up mk = new Make_up();
               mk.Id = Id;
              mk.Type = Type;
            mk.Culoare = Culoare;
            mk.Timpparcurs = Timpparcurs;

            return mk;



        }



        public int CompareTo(Make_up other)
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








    }
}
