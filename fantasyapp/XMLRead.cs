using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasyapp
{
    class XMLRead
    {
        static public string ReadXML()
       {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Player));

            using (System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\y49592\Documents\Visual Studio 2013\Projects\fantasyapp\fantasyapp\Player.xml"))
            {
               Player qb = new Player();
               qb = (Player)reader.Deserialize(file);
                string result = qb.name;
                return result;
            }  
            }
    }
}
