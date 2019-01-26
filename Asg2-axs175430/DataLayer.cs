using System;
using System.Collections.Generic;
using System.IO;

//class to handle the creating, reading and writng of records to and from the file
//DataLayer Operations present in this file
namespace Asg2_axs175430
{
    class DataLayer
    {
        public Boolean CreateDatatFile()
        {

            FileStream f = new System.IO.FileStream(@"CS6326Asg2.txt", System.IO.FileMode.OpenOrCreate);
            f.Close();
            return true;
        }

        public List<Entry> readRecords()
        {
            List<Entry> rows = new List<Entry>();

            StreamReader file = new StreamReader(@"CS6326Asg2.txt");
            while (true)
            {
                String line = file.ReadLine();
                if (line == null)
                {
                    break;
                }
                string[] info = line.Split('\t');
                Entry entry = new Entry();
                entry.firstName = info[0];
                entry.middleInitial = info[1];
                entry.lastName = info[2];
                entry.addressLine1 = info[3];
                entry.addressLine2 = info[4];
                entry.city = info[5];
                entry.state = info[6];
                entry.zipCode = info[7];
                entry.gender = info[8];
                entry.phoneNumber = info[9];
                entry.emailAddress = info[10];
                entry.proofOfPurchase = info[11];
                entry.dateRecieved = DateTime.Parse(info[12]);
                entry.startTime = TimeSpan.Parse(info[13]);
                entry.endTime = TimeSpan.Parse(info[14]);
                entry.numberOfKeyPresses = info[15];
                rows.Add(entry);

            }
            file.Close();
            return rows;
        }

        public Boolean writeRecords(List<Entry> entries)
        {
            StreamWriter sw = new StreamWriter(@"CS6326Asg2.txt");
            foreach (Entry entry1 in entries)
            {
                sw.Write(entry1.firstName + "\t");
                sw.Write(entry1.middleInitial + "\t");
                sw.Write(entry1.lastName + "\t");
                sw.Write(entry1.addressLine1 + "\t");
                sw.Write(entry1.addressLine2 + "\t");
                sw.Write(entry1.city + "\t");
                sw.Write(entry1.state + "\t");
                sw.Write(entry1.zipCode + "\t");
                sw.Write(entry1.gender + "\t");
                sw.Write(entry1.phoneNumber + "\t");
                sw.Write(entry1.emailAddress + "\t");
                sw.Write(entry1.proofOfPurchase + "\t");
                sw.Write(entry1.dateRecieved + "\t");
                sw.Write(entry1.startTime + "\t");
                sw.Write(entry1.endTime + "\t");
                sw.Write(entry1.numberOfKeyPresses + "\t\n");

            }
            sw.Close();
            return true;
        }
    }
}
