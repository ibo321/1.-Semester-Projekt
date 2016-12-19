using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Documents;

namespace Projekt.Model
{
    class Residence
    {
        public int Adult { get; set; }
        //public int Guests { get; set; }
        public int HouseNo { get; set; }
        public int Child02 { get; set; }
        public int Child36 { get; set; }
        public int Child715 { get; set; }

        public Residence(int adult, int houseNo, int child02, int child36, int child715)
        {
            Adult = adult;
            //Guests = 0;
            HouseNo = houseNo;
            Child02 = child02;
            Child36 = child36;
            Child715 = child715;
        }

        public void Add(string type, int amount)
        {
            switch(type)
            {
                case "Adult":
                    Adult = Adult + amount;
                    break;
                //case "Guests":
                //    Guests = Guests + amount;
                //    break;
                case "Child02":
                    Child02 = Child02 + amount;
                    break;
                case "Child36":
                    Child36 = Child36 + amount;
                    break;
                case "Child715":
                    Child715 = Child715 + amount;
                    break;
            }
        }

        public override string ToString()
        {
            return $"HusNr.: {HouseNo}\nVoksne: {Adult}\nBørn (0-2 år): {Child02}\nBørn (3-6 år): {Child36}\nBørn (7-15 år): {Child715}";
        }
    }
}
