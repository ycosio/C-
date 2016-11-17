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

namespace LecturaXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTxml.Text = "";
            XmlTextReader reader = new XmlTextReader("C:/Users/Yair/Documents/7-D/Sistemas de hipermedia/configuracion.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        TXTxml.Text += "<" + reader.Name + ">";
                        break;
                    case XmlNodeType.Text: 
                        TXTxml.Text +=reader.Value;
                        break;
                    case XmlNodeType.EndElement: 
                        TXTxml.Text += "</" + reader.Name + ">";
                        break;
                }
                TXTxml.Text += Environment.NewLine;
            }
        }
    
    }
}
