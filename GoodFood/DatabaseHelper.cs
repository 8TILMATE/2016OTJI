using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace GoodFood
{
    class DatabaseHelper
    {
        public static string _connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rafxg\\source\\repos\\GoodFood\\GoodFood\\Resurse\\GoodFood.mdf;Integrated Security = True";
        public static string _filepath = "C:\\Users\\rafxg\\source\\repos\\GoodFood\\GoodFood\\Resurse\\meniu.txt";
        
        public static void Init()
        {
            StergereMeniu();
            InserareMeniu();          
        }
        public static void InserareMeniu()
        {
            using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Meniu values  (@id,@denumire,@descriere,@pret,@kcal,@fel)";
                using(StreamReader rdr = new StreamReader(_filepath))
                {
                    while (rdr.Peek() >= 1)
                    {
                        var line = rdr.ReadLine().Split(';');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            cmd.Parameters.AddWithValue("id", line[0].Trim());
                            cmd.Parameters.AddWithValue("denumire", line[1].Trim());
                            cmd.Parameters.AddWithValue("descriere", line[2].Trim());
                            cmd.Parameters.AddWithValue("pret", line[3].Trim());
                            cmd.Parameters.AddWithValue("kcal", line[4].Trim());
                            cmd.Parameters.AddWithValue("fel", line[5].Trim());
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
            }
        }
        public static void StergereMeniu()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Delete from Meniu";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.ExecuteNonQuery();
                }
                cmdText = "DBCC CHECKIDENT('MENIU',RESEED,0)";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {

                }
            }
        }
        public static bool LoginVerify(string email,string parola)
        {
            using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select nume,prenume,adresa,email,kcal_zilnice from Clienti where Clienti.email=@email and Clienti.parola=@parola";
                using(SqlCommand cmd = new SqlCommand(cmdText,con))
                {
                    cmd.Parameters.AddWithValue("parola", parola);
                    cmd.Parameters.AddWithValue("email", email);
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        rdr.Read();
                        try
                        {
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                Console.WriteLine(rdr.GetValue(i).ToString());
                            }
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                        Console.WriteLine("am ajuns");
                       // }
                    }
                }
            }
        }
        public static void CreeareCont(string nume,string prenume, string email, string parola,string adresa)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Clienti(nume,prenume,adresa,email,parola) values (@nume,@prenume,@adresa,@email,@parola)";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("prenume", prenume);
                    cmd.Parameters.AddWithValue("nume", nume);
                    cmd.Parameters.AddWithValue("adresa", adresa);
                    cmd.Parameters.AddWithValue("parola", parola);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
