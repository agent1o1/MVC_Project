using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entitys
{
    public static class Data
    {
        public static List<DataModel> DataSet = new List<DataModel>()
        {
            new DataModel(){Name = "Patric", Age = 34 },
            new DataModel(){Name = "Nicol", Age = 28 },
            new DataModel(){Name = "Abubakar", Age = 31 },

        }; 
    }

    public class DataModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
    }
}
