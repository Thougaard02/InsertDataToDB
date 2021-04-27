using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertDataToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DalManager manager = new DalManager();

            manager.InsertData();
        }
       
    }
}
