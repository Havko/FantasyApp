using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasyapp
{
    public class XMLWrite
    {
        public static void WriteXML(string name, string position)
        {
         
            Player qb = new Player();
            qb.name = name;
            qb.position = 
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Player));

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\y49592\Documents\Visual Studio 2013\Projects\fantasyapp\fantasyapp\Player.xml");
            writer.Serialize(file, qb);
            file.Close();

        }
       
    }
}
