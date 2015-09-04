using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fantasyapp
{
    public partial class MyFantasyApp : Form
    {
        public MyFantasyApp()
        {
            InitializeComponent();
        }

        private void updateLineup_Click(object sender, EventArgs e)
        {
            qbUpdate.Visible = true;
            confirmUpdate.Visible = true;
        }

    

        private void confirmUpdate_Click(object sender, EventArgs e)
        {
            qbUpdate.Visible = false;
            confirmUpdate.Visible = false;
            qb.Text = qbUpdate.Text;
        }

        public class Player
        {
            public string name;
            
        }

        public void ReadXML()
        {
            var p = new Player { name = "Matt Ryan" };
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(Player));
            var wfile = new System.IO.StreamWriter(@"C:\temp\SerializationOverview.xml");
            writer.Serialize(wfile, p);
            wfile.Close();

            System.Xml.Serialization.XmlSerializer reader =
              new System.Xml.Serialization.XmlSerializer(typeof(Player));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"c:\temp\SerializationOverview.xml");
            Player overview = (Player)reader.Deserialize(file);
            file.Close();

            Console.WriteLine(overview.name);
        }
    }
}
