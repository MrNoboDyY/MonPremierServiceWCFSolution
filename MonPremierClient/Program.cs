using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Projet creer depuis la MonPremierService WCF
namespace MonPremierClient
{//Utilisation d'un WebService GetPrice depuis Reference Client =>> MonPremierClient
    class Program
    { 

        //creation Methode Asynchrone rendant Asynchrone le WebService "GetPrice"
        //indique au programlme que cette methode peut s'executer de façon Asynchrone
        static async void MaMethodeAsynchrone (string input , ServiceReference1.Service1Client client)
        {
            Console.WriteLine($"Prix de l'objet {input} : {await client.GetPriceAsync(input)} ");
        }

        static void Main(string[] args)
        {

            var input = "";

            //creation d'un Objet "Service1Client" nous permettant de communiquer avec le WebService
            var client = new ServiceReference1.Service1Client();

            do
            {
                Console.WriteLine(" nomer l'objet dont vous souhaitez avoir le prix !!");

                //enregistrement des infos venant du clavier
                input = Console.ReadLine();

                //gestion des infos venant du clavier a savoir "input" ==>> utilisation du XebService "GetPrice" 
                //en fonction de l'input
                //Console.WriteLine($"Prix de l'objet {input} : {client.GetPrice(input)}");


                Task.Run(() => MaMethodeAsynchrone(input, client));

            } while (input != "quit");

            client.Close();
        }
    }
}
