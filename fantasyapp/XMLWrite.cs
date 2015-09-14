using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasyapp
{
    public class XMLWrite
    {
        public static void WriteXML(string name)
        {
            Player qb = new Player();
            qb.name = name;
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Player));

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\temp\SerializationQb.xml");
            writer.Serialize(file, qb);
            file.Close();

        }
       
    }
}
