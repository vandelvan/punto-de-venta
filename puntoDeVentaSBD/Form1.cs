using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace puntoDeVentaSBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var cs = "Host=localhost;Username=postgres;Password=pswrd;Database=testdb";
            try
            {
                using var con = new NpgsqlConnection(cs);
                con.Open();
                
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DROP TABLE IF EXISTS cars";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"CREATE TABLE cars(id SERIAL PRIMARY KEY, 
                    name VARCHAR(255), price INT)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
                cmd.ExecuteNonQuery();
                
            }
            catch
            {
                Console.WriteLine("No se logro conectar a la database");
            }

            

        }
    }
}