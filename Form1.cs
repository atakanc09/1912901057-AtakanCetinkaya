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
using System.IO;

namespace _1912901057_AtakanCetinkaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnOku_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlOku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");

           
            
           
           

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    lstBxHaber.Items.Add(xmlOku.ReadString());
                    
                }

            }
           
            
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            string file = "C:\\AtakanC";
            string txtFile = "C:\\AtakanC\\AtakanC.txt";
            Directory.CreateDirectory(file);
            FileStream stream = File.Create(txtFile);
            StreamWriter sw = new StreamWriter(stream);
            String[] sitesDizi = new String[lstBxHaber.Items.Count];
            lstBxHaber.Items.CopyTo(sitesDizi, 0);
            System.IO.File.WriteAllLines("AtakanC.txt", sitesDizi);
            sw.Flush();
            sw.Close();


        }
    }
}
