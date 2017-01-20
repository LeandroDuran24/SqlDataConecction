using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlConecction
{
    class Conexion
    {
        SqlConnection conecction = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=tutorial;Data Source=LeandroDuran");

        private void Conectar()
        {
            if (conecction.State == ConnectionState.Closed)
            {
                conecction.Open();
            }
        }



        public bool Prueba()
        {
            Conectar();
            if (conecction.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
