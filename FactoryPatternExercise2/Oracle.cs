using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class Oracle : DBAccess
    {
        public Oracle()
        {
            base.WhoAmI = "Oracle";
        }

        public override void Delete()
        {
            Console.WriteLine("Deleting an Oracle record...");
        }

        public override void Insert()
        {
            Console.WriteLine("Inserting an Oracle record...");
        }

        public override void Select()
        {
            Console.WriteLine("Selecting an Oracle record...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating an Oracle record...");
        }
    }
}
