using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlConecction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();

           if(sql.Prueba ()) {
                MessageBox.Show("Conectado...");
           }
           else {
                MessageBox.Show("No se ha conectado...");
           
           }
        }
    }
}
