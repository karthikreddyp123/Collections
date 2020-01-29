using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("Test1", "Test@123");
            hashtable.Add("Admin", "Admin@123");
            hashtable.Add("Temp", "Temp@123");
            hashtable.Add("Demo", "Demo@123");
            hashtable.Add("Test2", "Test2@123");
            hashtable.Remove("Admin");

            if (hashtable.ContainsKey("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                hashtable.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }

            // Get a collection of the keys.
            ICollection key = hashtable.Keys;
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + hashtable[k]);
            }
            Console.ReadKey();
        }
    }
}
