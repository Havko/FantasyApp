using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace fantasyapp
{
     
    public partial class MyFantasyApp : Form
    {
        
       
        public MyFantasyApp()
        {
            InitializeComponent();
            qb.Text = Reader.Read();
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
            //qb.Text = qbUpdate.Text;
            
            //Writer.Write(qbUpdate.Text);
            
        }

       
        }
   

}

