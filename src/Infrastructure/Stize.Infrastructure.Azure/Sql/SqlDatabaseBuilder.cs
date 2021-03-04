using Pulumi;
using Pulumi.AzureNextGen.Sql.Latest;
using Pulumi.Random;

namespace Stize.Infrastructure.Azure.Sql
{
    /// <summary>
    /// Azure SQL database builder
    /// </summary>
    public class SqlDatabaseBuilder : BaseBuilder<Database>
    {
        /// <summary>
        /// Database arguments
        /// </summary>
        /// <returns></returns>
        public DatabaseArgs Arguments {get; private set; } = new DatabaseArgs();

        /// <summary>
        /// Creates a new instance of <see="SqlDatabaseBuilder" />
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public SqlDatabaseBuilder(string name) : base(name)
        {
        }
        /// <summary>
        /// Creates a new instance of <see="SqlDatabaseBuilder" />
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public SqlDatabaseBuilder(string name, RandomId rid) : base(name, rid)
        {
        }
        /// <summary>
        /// Creates a new instance of <see="SqlDatabaseBuilder" />
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public SqlDatabaseBuilder(string name, DatabaseArgs arguments) : this(name)
        {
            Arguments = arguments;
        }
        /// <summary>
        /// Creates a new instance of <see="SqlDatabaseBuilder" />
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public SqlDatabaseBuilder(string name, DatabaseArgs arguments, RandomId rid) : this(name, rid)
        {
            Arguments = arguments;
        }

        /// <summary>
        /// Creates the Pulumi database object
        /// </summary>
        /// <param name="cro">Database's CustomResourceOptions</param>
        /// <returns></returns>
        public override Database Build(CustomResourceOptions cro)
        {
            var db = new Database(this.Name, this.Arguments, cro);
            return db;
        }
    }
}