using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MySQL : DBAccess
    {
        public MySQL()
        {
            base.WhoAmI = "MySQL";
        }

        public override void Delete()
        {
            Console.WriteLine("Deleting a MySQL record...");
        }

        public override void Insert()
        {
            Console.WriteLine("Inserting a MySQL record...");
        }

        public override void Select()
        {
            Console.WriteLine("Selecting a MySQL record...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating a MySQL record...");
        }

    }
}
