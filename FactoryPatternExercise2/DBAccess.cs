using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public abstract class DBAccess
    {
        public string? WhoAmI { get; internal set; }

        public virtual void PrintSummary()
        {
            Console.WriteLine($"Default summary: {WhoAmI}");
        }

        public abstract void Select();
        public abstract void Delete();
        public abstract void Insert();
        public abstract void Update();
    }
}
