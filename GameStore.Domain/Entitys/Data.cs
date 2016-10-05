using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entitys
{
    public static class Data //Those static Lists using like a dummy results of Entity stored procedures
    {
        public static List<GamesDataModel> GamesList = new List<GamesDataModel>()
        {
            new GamesDataModel(){Name = "FarCry 2", Price = 1999 },
            new GamesDataModel(){Name = "Skyrim", Price = 999 },
            new GamesDataModel(){Name = "Counter-Strike", Price = 1299 }
        }; 
    }

    public class GamesDataModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        
    }
}
