using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace @class
{
    class listHuman
    {
        private List<Human> listHumans;

        public listHuman()
        {
            listHumans = new List<Human>();
        }
        public void add(Human human)
        {
            listHumans.Add(human);
        }
        public void show()
        {
            for (int n = 0; n < listHumans.Count(); n++)
                listHumans[n].printInfo();
        }
        public string show(int a)
        {
            string data = "";
            for (int n = 0; n < listHumans.Count(); n++)
                data += listHumans[n].toStr();
            return data;
        }
        public void findCountry_Nation(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
                if (listHumans[n].Adress.Country == str &&
                    listHumans[n].Nation.ToString() == "Ukranian")
                    listHumans[n].printInfo();
        }
        public void findName(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if (listHumans[n].Name == str)
                    listHumans[n].printInfo();
                else
                    Console.WriteLine("такого немає");
            }

        }
        public void find_change_name(string fName, string lName)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if (listHumans[n].Name == fName)
                {
                    listHumans[n].Name = lName;
                    listHumans[n].printInfo();
                }
            }

        }
        public void find_change_surname(string fSurname, string lSurname)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if (listHumans[n].Surname == fSurname)
                {
                    listHumans[n].Surname = lSurname;
                    listHumans[n].printInfo();
                }
                else
                    Console.WriteLine("такого немає");
            }
        }
        public void find_change_age(string name, string surname, int age)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if ((listHumans[n].Name == name) && (listHumans[n].Surname == surname))
                {
                    listHumans[n].Age = age;
                    listHumans[n].printInfo();
                }
                else
                    Console.WriteLine("такого немає");
            }
        }
        public void remove(string name, string surname)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if ((listHumans[n].Name == name) && (listHumans[n].Surname == surname))
                    listHumans.RemoveAt(n);
            }
            Console.WriteLine("видалення пройшло");
        }
        public void average_age()
        {
            int age = 0;
            for (int n = 0; n < listHumans.Count(); n++)
                age += listHumans[n].Age;
            if (listHumans.Count() != 0)
            {
                float result = age / listHumans.Count();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("пустий список");
            }
        }
        public void show(bool b)
        {
            foreach (Human obj in listHumans)
                obj.printInfo();
        }
        public void sort_surname()
        {
            Human reserv = new Human();
            for (int j = 1; j < listHumans.Count(); j++)
                for (int i = 0; i < listHumans.Count() - 1; i++)
                    if (listHumans[i].Surname[0] > listHumans[i + 1].Surname[0])
                    {
                        reserv = listHumans[i];
                        listHumans[i] = listHumans[i + 1];
                        listHumans[i + 1] = reserv;
                    }
            for (int n = 0; n < listHumans.Count(); n++)
                listHumans[n].printInfo();

        }
        public void sort_age()
        {
            Human reserv = new Human();
            for (int j = 1; j < listHumans.Count(); j++)
                for (int i = 0; i < listHumans.Count() - 1; i++)
                    if (listHumans[i].Age > listHumans[i + 1].Age)
                    {
                        reserv = listHumans[i];
                        listHumans[i] = listHumans[i + 1];
                        listHumans[i + 1] = reserv;
                    }
            for (int n = 0; n < listHumans.Count(); n++)
                listHumans[n].printInfo();

        }

    }
}
