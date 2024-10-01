using Beauty_Salon.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Salon.serviciiSalon
{
    public class Hair_Salon: IServicii
    {
        private string _type;
        private string _eveniment;
        private int _id;
        private string _typePar;
        private float _timpParcurs;

        public Hair_Salon()
        {

        }

        public string TypePar
        { 
            get { return _typePar; }
            set { _typePar = value; }

        }
        public string Eveniment
        {
            get { return _eveniment; }
            set { _eveniment = value; }

        }
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
        public float TimpParcurs
        { get { return _timpParcurs;}
          set { _timpParcurs = value; }
        }

        public void Afisare()
        {
            Console.WriteLine(this.ToString());




        }
        public string ToString()
        {
            string t = " "+base.ToString();
            t += "Id: " + Id + "\n";
            t += "Type: " + Type + "\n";
            t += "Tipul de Par:: " + TypePar + "\n";
            t += "Eveniment: " + Eveniment + "\n";
            t += "TimpParcurs: " + TimpParcurs + "\n";
            return t;

        }


        public IServicii ReturnServicii()
        {
            Hair_Salon h = new Hair_Salon();
            h.Id = Id;
            h.Type = Type;
            h.Eveniment = Eveniment;
            h.TimpParcurs = TimpParcurs;
            h.TypePar = TypePar;
            return h;



        }

        public int CompareTo(Hair_Salon other)
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
