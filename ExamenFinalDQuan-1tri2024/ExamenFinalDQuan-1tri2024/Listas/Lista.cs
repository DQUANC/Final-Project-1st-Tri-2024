using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalDQuan_1tri2024.Listas
{
    public class Lista
    {
        public List<string> ListData = new List<string>();

        public void addList(String value)
        {
            this.ListData.Add(value);
        }

        public List<string> addList()
        {
            return this.ListData;
        }
    }
}
