using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class Postgres : DBAccess
    {
        public Postgres()
        {
            base.WhoAmI = "Postgres";
        }
        public override void Delete()
        {
            Console.WriteLine("Deleting a Postgres record...");
        }

        public override void Insert()
        {
            Console.WriteLine("Inserting a Postgres record...");
        }

        public override void Select()
        {
            Console.WriteLine("Selecting a Postgres record...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating a Postgres record...");
        }
    }
}
