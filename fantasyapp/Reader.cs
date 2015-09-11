using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace fantasyapp
{
    public class Reader
    {
        public static string Read()
        {
            string result = "Test 2";
            XmlTextReader reader = new XmlTextReader ("Player.xml");

            while (reader.Read())
            {
                result = reader.GetAttribute(0);
            }
            return result;
        }
    }
}

