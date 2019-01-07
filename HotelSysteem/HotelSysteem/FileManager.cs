using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HotelSysteem
{
    class FileManager
    {
        List<string> List;
        public void Insert(string Name, string Address, int Room, DateTime Date)
        {
            string combination = Name + Address + Room.ToString() + Date.ToString();
            string Database = "Database.txt";

            if (!File.Exists(Database))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(Database))
                {
                    sw.WriteLine(Name);
                    sw.WriteLine(Address);
                    sw.WriteLine(Room);
                    sw.WriteLine(Date);
                    sw.Write("\n");
                }
            }
            else
            {

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(Database))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

                using (StreamWriter test = File.AppendText(Database))
                {
                    List = new List<string>();
                    List.Add(Name);
                    List.Add(Address);
                    List.Add(Room.ToString());
                    List.Add(Date.ToString());
                    List.Add("\n");
                    foreach (string item in List)
                    {
                        test.WriteLine(item);
                    }
                }
            }

        }
        public List<string> OverviewList()
        {
            string Database = "Database.txt";
            List<string> Fulllist;
            if (!File.Exists(Database))
            {
                return null;
            }
            else
            {
                Fulllist = new List<string>();
                using (StreamReader sr = File.OpenText(Database))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Fulllist.Add(s);
                    }
                }
                
                return Fulllist;
            }
        }
    }
}
