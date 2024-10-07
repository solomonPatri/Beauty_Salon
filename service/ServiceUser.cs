using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Beauty_Salon.user;

namespace Beauty_Salon.service
{
    public  class ServiceUser
    {

        private List<User> _users;
        private string _filepath;

        public ServiceUser() {

            _users = new List<User>();

            _filepath = GetDirectory();

            load();
        
        
        }


        public void Meniu()
        {
            Console.WriteLine("Alegeti tipul de colectie :" + "\n");
            Console.WriteLine("1->Lista." + "\n");
            Console.WriteLine("2->Stiva." + "\n");
            Console.WriteLine("3->Coada" + "\n");
            Console.WriteLine("4->Hashset" + "\n");
            Console.WriteLine("5->SortedSet." + "\n");
            Console.WriteLine("6->Dictionary" + "\n");
            Console.WriteLine("7->LINQ" + "\n");


        }

        public void load()
        {
            int nrales= int.Parse(Console.ReadLine());
            try
            {
                using (StreamReader sr = new StreamReader(_filepath))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {

                        switch (line.Split(",")[0])
                        {

                            case "Client":

                               Client cl = new Client(line);
                               _users.Add(cl);

                                break;
                            case "Angajat":
                               Angajat angajat = new Angajat(line);
                                _users.Add(angajat);
                                break;
                            case null:
                                
                                Meniu();
                                switch (nrales)
                                {
                                    case 1:

                                        ListaUser();

                                        break;

                                    case 2:

                                        StackUsers();

                                        break;




                                }


                                break;

                            
                            default:

                                break;



                        }






                    }


                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


           









        }
        private string GetDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.Combine(currentDirectory, "data");
            string filepath = Path.Combine(dataFolder, "BeautySalon.txt");

            return filepath;


        }


        public void ListaUser()
        {

            List<User>  users = new List<User>();

            Client cl1 = Client.ClientBuilder
               .Create()
               .SetNamePerson("Ana")
               .SetAgePerson(20)
               .SetAdressPerson("strd ludos 122")
               .Build();

            Client cl2= Client.ClientBuilder
               .Create()
               .SetNamePerson("Maria")
               .SetAgePerson(25)
               .SetAdressPerson("strd ludos 122")
               .Build();












        }

        public void StackUsers()
        {












        }







    }
}
