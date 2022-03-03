using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace KBProject
{
    class KBdatabase
    {
        private string _connectionString;

        public KBdatabase()
        {
            _connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=KBduombaze; Integrated Security=True;";
        }
        public void IDuomenuBaze(string vardas, string pavarde, int amzius, int kraujoGrupe, string slaptazodis)
        {
            //Susikuriam connection i sql duombaze
            //Pridedam visus parametrus gautus is registracijos laukeliu.
            using (SqlConnection sqlConnection = new SqlConnection (_connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO Zmones (vardas, pavarde, amzius, kraujoGrupe, slaptazodis) " +
                        "VALUES (@Vardas, @Pavarde, @Amzius, @KraujoGrupe, @Slaptazodis)", sqlConnection))
                    {
                        command.Parameters.Add(new SqlParameter("Vardas", vardas));
                        command.Parameters.Add(new SqlParameter("Pavarde", pavarde));
                        command.Parameters.Add(new SqlParameter("Amzius", amzius));
                        command.Parameters.Add(new SqlParameter("KraujoGrupe", kraujoGrupe));
                        command.Parameters.Add(new SqlParameter("Slaptazodis", slaptazodis));
                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ivyko registracijos klaida duombazeje!\n {ex.Message}");
                }
                
            }
        }
        public void NuskaitomDuombaze(string vardas, string slaptazodis)
        {
            //Nusiskaitom duombaze
            //Paziurim ar laukeliuose ivesti duomenys sutampa su duombazes
            //Jeigu taip - nuvedam i kita puslapi
            //Jeigu ne - messagebox.show("blogi duomenys.");
            using (SqlConnection sqlcon = new SqlConnection(_connectionString))
            {
                PrisijungimoPuslapis prisijungimoPsl = new PrisijungimoPuslapis();
                sqlcon.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT Vardas, Slaptazodis FROM Zmones", sqlcon))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string DBvardas = reader[0].ToString();
                            string DBslaptazodis = reader[1].ToString();
                            if (DBvardas == vardas && DBslaptazodis == slaptazodis)
                            {
                                MessageBox.Show("Prisijungete sekmingai!");
                            }
                            else
                            {
                                MessageBox.Show("Vardas arba slaptazodis neteisingi!");
                            }
                        }
                        sqlcon.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ivyko duombazes klaida - {ex.Message}");
                }
            }

        }
    }
}
