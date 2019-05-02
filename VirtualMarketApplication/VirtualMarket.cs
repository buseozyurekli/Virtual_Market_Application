using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VirtualMarketApplication
{
    public class VirtualMarket
    {
        private static List<Customer> Customers = new List<Customer>();
        protected static ArrayList Category = new ArrayList();
        private static List<Personnel> Personnels = new List<Personnel>();

		public void SignUp(Customer customer)
        {
            Customers.Add(customer);
        }

        public void AddPersonnel(Personnel personnel)
        {
            Personnels.Add(personnel);
        }

        public string PersonnelControl(long tc)
        {
            string message = "";
            foreach (Personnel personnel in Personnels)
            {
                if(tc == personnel.TC)
                {
                    message = personnel.name + personnel.surname;
                }
            }
            return message;
        }

        public string FindPersonnel(long tc)
        {
            string message = "Personnel Not Found..";
            foreach (Personnel personnel in Personnels)
            {
                if (tc == personnel.TC)
                {
                    message = "Login Successful..";
                    break;
                }
                else
                {
                    message = "Login Failed..";
                }
            }
            return message;
        }

        public string CustomerControl(string username)
        {
            string message = "";
            foreach (Customer custom in Customers)
            {
                if (username == custom.username)
                {
                    message = custom.mail;
                }
            }
            return message;
        }

        public string FindCustomer(string username, int password)
        {
            string message = "Customer Not Found..";
            foreach (Customer custom in Customers)
            {
                if(username == custom.username && password == custom.password)
                {
                    message = "Login Successful..";
                    break;
                }
                else
                {
                    message = "Login Failed..";
                }
            }
            return message;
        }
    }
}
