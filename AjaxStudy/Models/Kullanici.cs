using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxStudy.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class KullaniciIslem
    {
        private static List<Kullanici> users = new List<Kullanici>()
            {
                new Kullanici {Id =1 , Name="Hasan"},
                new Kullanici {Id =2 , Name="Cantürk"}
            };

        public static List<Kullanici> GetAll()
        {
            return users;
        }

        public static Kullanici GetById(int id)
        {
            return users.FirstOrDefault(I => I.Id == id);
        }

        public static void Add(Kullanici kullanici)
        {
            users.Add(kullanici);
        }


    }



}
