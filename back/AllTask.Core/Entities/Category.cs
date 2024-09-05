namespace AllTask.Core.Entities
{
    public class Category : BaseEntity
    {
        protected Category()
        { }

        public Category(string name) : base()
        {
            Name = name;
        }

        public string Name { get; private set; }
        public List<Routine> Routines { get; private set; }
    }
}
