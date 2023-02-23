using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DBFactory
    {
        public static DBAccess GetAccessor(string whichKind)
        {
            switch (whichKind.ToLower())
            {
                case "mongo":
                case "mongodb":
                case "pieceofcrap":
                    return new MongoDB();
                case "mysql":
                    return new MySQL();
                case "postgres":
                case "postgresql":
                    return new Postgres();
                case "oracle":
                case "ellisoncashcow":
                    return new Oracle();
                case "sqlsrvr":
                case "msss":
                    return new SqlSrvr();
                default:
                    throw new Exception("Unknown DB selection.");
            }
        }
    }
}
