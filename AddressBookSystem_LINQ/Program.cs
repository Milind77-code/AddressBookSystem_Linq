using System;

namespace AddressBookSystem_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_AddressBookSystem_Linq***");
            AddrssBookModel model = new AddrssBookModel();
            AddressBookDataTable dataTable = new AddressBookDataTable();
            dataTable.CreateTable(model);
           // dataTable.Display();
            while (true)
            {
                Console.WriteLine("\nEnter Choice  \n1. Add Contact \n2. Display \n3. Edit Contact  \n4. Exit ");
                int choise = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choise)
                    {
                        case 1:
                            Console.Write("Enter the first name: ");
                            model.First_Name = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.Last_Name = Console.ReadLine();
                            Console.Write("Enter the Address : ");
                            model.Address = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.City = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.State = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.Zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.Phone_Number = Console.ReadLine();
                            Console.Write("Enter the E-mail : ");
                            model.Email = Console.ReadLine();
                            dataTable.AddContact(model);
                            break;
                        case 2:
                            dataTable.Display();
                            break;
                        case 3:
                            Console.Write("Enter the first name: ");
                            model.First_Name = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.Last_Name = Console.ReadLine();
                            Console.Write("Enter the Address : ");
                            model.Address = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.City = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.State = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.Zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.Phone_Number = Console.ReadLine();
                            Console.Write("Enter the E-mail : ");
                            model.Email = Console.ReadLine();
                            dataTable.EditContact(model);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }

            }
        }
    }
}
