using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SqlSrvr : DBAccess
    {
        public SqlSrvr()
        {
            base.WhoAmI = "SqlSrvr";
        }

        public override void Delete()
        {
            Console.WriteLine("Deleting a SqlSrvr record...");
        }

        public override void Insert()
        {
            Console.WriteLine("Inserting a SqlSrvr record...");
        }

        public override void Select()
        {
            Console.WriteLine("Selecting a SqlSrvr record...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating a SqlSrvr record...");
        }

    }
}
