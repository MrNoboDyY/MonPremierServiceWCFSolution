using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonPremierServiceWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {


        //Appel du WebService creer dans l'interface IService1.cs
        public float GetPrice(string id)
        {
            //System.Threading.Thread.Sleep(10000);

            switch (id)
            {
                case "chaussures":
                    {
                        return 49.0f;
                    }
                case "blouson":
                    {
                        return 129f;
                    }
                default:
                    {
                        return 99999999999999.99f;
                    }
            }
        }

        public string GetData(int value)
        {
            return $"valeur passée en parametre : {value}";
        }

        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
