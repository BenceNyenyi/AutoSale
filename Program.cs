using AutoSale.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoSale
{
    public class Program
    {
        public static connect conn = new connect();
        public static List<car> lista = new List<car>();

        public static void feladat1()
        {

            string sql = "SELECT * FROM cars";
            conn.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);
            MySqlDataReader dr = cmd.ExecuteReader();   

            dr.Read();

            car cars = new car();

            cars.id = dr.GetInt32(0);
            cars.Brand = dr.GetString(1);
            cars.Type = dr.GetString(2); 
            cars.License = dr.GetString(3);
            cars.Date = dr.GetString(4);

            cars.Add(cars);
            while (dr.Read()) ;
           

            conn.Connection.Close();
            




            conn.Connection.Close();
        }

        static void Main(string[] args)
        {
            feladat1();
            foreach (var item in lista)
            {
                Console.WriteLine($"Márka: {item.Brand}, Azonosító: {item.License}");
            }
        }


        static void feladat2()
        {
            string marka, típus, azon;
            int ev;



            Console.WriteLine("Kérem az autó márkáját: ");
            marka = Console.ReadLine();


            Console.WriteLine("Kérem az autó márkáját: ");
            típus =Console.ReadLine();


            Console.WriteLine("Kérem az autó márkáját: ");
            azon = Console.ReadLine();

            Console.WriteLine("Kérem az autó márkáját: ");
            ev = int.Parse(Console.ReadLine());

            string sql = ("INSERT INTO");
            conn.Connection.Open();

           

            

            conn.Connection.Close();
        }


        public static void feladat3()
        {
            int id, ev;

            Console.WriteLine("Kérem az autó id-ját: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérem az autó gyártás idejét: ");
            id = int.Parse(Console.ReadLine());

            string sql = ("UPDATE");
        }

       
    }
}
