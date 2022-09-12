using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Human> listHuman = new List<Human>();
          
            listHuman list = new listHuman();
            Human.inputInfo(list);
            list.show();
            string choice = null;
            while (choice != "0")
            {
                Console.WriteLine("Выберите действие ");
                Console.WriteLine("0 - выйти с программы.");
                Console.WriteLine("1 - распечатать все объекты");
                Console.WriteLine("2 - найти объект по имени");
                Console.WriteLine("3 - сортировка объектов по возрасту и вывести информацию");
                Console.WriteLine("4 - сортировка объектов по фамилии и вывести информацию");
                Console.WriteLine("5 - создать новый объект и добавить в список");
                Console.WriteLine("6 - изменить значения поля объекта");
                Console.WriteLine("7 - удалить объект");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("До свидания!");
                        break;
                    case "1":
                        list.show();
                        break;
                    case "2":
                        Console.WriteLine("Введите имя ");
                        string name = Console.ReadLine();
                        list.findName(name);
                        break;
                    case "3":
                        list.sort_age();
                        break;
                    case "4":
                        list.sort_surname();
                        break;
                    case "5":
                        Human.inputInfo(list);
                        Console.WriteLine("Теперь наш список выглядит так: ");
                        list.show();
                        break;
                    case "6":
                        string c = null;
                        while (c != "0")
                        {
                            Console.WriteLine("Выберите действие ");
                            Console.WriteLine("0 - вернуться в главное меню.");
                            Console.WriteLine("1 - изменить имя");
                            Console.WriteLine("2 - изменить фамилию");
                            Console.WriteLine("3 - изменить возраст");
                            c = Console.ReadLine();
                            switch (c)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.WriteLine("Введите имя объекта которое хотите изменить: ");
                                    string firstName = Console.ReadLine();
                                    Console.WriteLine("Введите имя на которое хотите изменить: ");
                                    string secondName = Console.ReadLine();
                                    list.find_change_name(firstName, secondName);
                                    break;
                                case "2":
                                    Console.WriteLine("Введите фамилию объекта которую хотите изменить: ");
                                    string firstSurname = Console.ReadLine();
                                    Console.WriteLine("Введите фамилию на которую хотите изменить: ");
                                    string secondSurname = Console.ReadLine();
                                    list.find_change_surname(firstSurname, secondSurname);
                                    break;
                                case "3":
                                    Console.WriteLine("Введите имя объекта чей возраст вы хотите изменить: ");
                                    string Name = Console.ReadLine();
                                    Console.WriteLine("Введите фамилию объекта чей возраст вы хотите изменить: ");
                                    string SurName = Console.ReadLine();
                                    Console.WriteLine("Введите возраст на который хотите изменить: ");
                                    int Age = int.Parse(Console.ReadLine());
                                    list.find_change_age(Name, SurName, Age);
                                    break;
                                default:
                                    Console.WriteLine("Вы ввели неверный номер!");
                                    break;
                            }
                        }
                        break;
                    case "7":
                        Console.WriteLine("Введите имя объекта который хотите удалить: ");
                        string name_human = Console.ReadLine();
                        Console.WriteLine("Введите фамилию объекта который хотите удалить: ");
                        string surName = Console.ReadLine();
                        list.remove(name_human, surName);
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверный номер!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
