using System;
using System.IO;
using System.Windows.Forms;

namespace FinalPOODef
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\logs\\log.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                txtLog.AppendText(line + "\r\n");
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
