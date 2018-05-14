namespace Source
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SourceModel : DbContext
    {
     
        public SourceModel()
            : base("name=SourceModel")
        {
        }
        public virtual DbSet<DataDb> DataDbSet { get; set; }
        public virtual DbSet<Message> MessageSet { get; set; }
        public virtual DbSet<Status> StatusSet { get; set; }

    }

}