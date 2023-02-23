using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDB : DBAccess
    {
        public MongoDB() 
        {
            base.WhoAmI = "MongoDB";
        }

        public override void Delete()
        {
            Console.WriteLine("Deleting a MongoDB blob...");
        }

        public override void Insert()
        {
            Console.WriteLine("Inserting a MongoDB blob...");
        }

        public override void Select()
        {
            Console.WriteLine("Selecting a MongoDB blob...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating a MongoDB blob...");
        }
    }
}
