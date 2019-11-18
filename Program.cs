using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataSetProgramShowXML
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable tabela1 = new DataTable("patients");
            tabela1.Columns.Add("name");
            tabela1.Columns.Add("id");
            tabela1.Rows.Add("sam", "1");
            DataSet set = new DataSet("office");
            set.Tables.Add(tabela1);
            DataSet copy = set.Copy();
            set.Clear();
            Console.WriteLine("set: {0}", set.GetXml());
            Console.ReadLine();
            Console.WriteLine("copy: {0}", copy.GetXml());
            Console.ReadLine();






        }
    }
}
