using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAM_and_CPU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
         public class DataProgramContext : DbContext
        {

            public DataProgramContext() : base("BaseCPURAM")
            {
                Database.SetInitializer<DataProgramContext>(new DataProgramContextSeed());


            }

            public DbSet<ValueCpuAndRam> RAMCPUSAVE { get; set; }
            public DbSet<ListEmails> ListEmailsDB { get; set; }
        }

        public class DataProgramContextSeed : DropCreateDatabaseIfModelChanges<DataProgramContext>
        {

            protected override void Seed(DataProgramContext context)
            {

      

                base.Seed(context);
            }
        }
    }
}
