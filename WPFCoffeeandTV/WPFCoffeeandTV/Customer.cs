using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFCoffeeandTV
{
    class Customer
    {
        string name;
        string coffeeSize;
        string shotType;
        string numOfShots;
        string typeOfMilk;
        string foam;
        string toppings;
        string flavours;
        

        public string Name { get => name; set => name = value; }
        public string CoffeeSize { get => CoffeeSize; set => CoffeeSize = value; }
        public string ShotType { get => shotType; set => shotType = value; }
        public string NumOfShots { get => numOfShots; set => numOfShots = value; }
        public string TypeOfMilk { get => typeOfMilk; set => typeOfMilk = value; }
        public string Foam { get => foam; set => foam = value; }
        public string Toppings { get => toppings; set => toppings = value; }
        public string Flavours { get => flavours; set => flavours = value; }

        public Customer()
        {

        }
        public Customer(string nm, string pw, int dob, string sx, string pn, string pic, string ar)
        {
            name = nm;
            password = pw;
            age = dob;
            sex = sx;
            phoneNumber = pn;
            picturePath = pic;
            ageRange = ar;
            genre = gnr;

        }

        public void saveData()
        {
            using (StreamWriter sw = File.AppendText("CoffeeOrder.csv"))
            {
                string eachItem = "";//will add items from the string array ln
                foreach (var item in genre)
                {
                    eachItem += "-" + item;
                }
                sw.WriteLine(name + "," + password + "," + age + "," + sex + "," + phoneNumber + "," + picturePath + "," + ageRange + "," + eachItem);
            }
        }

    }
}
