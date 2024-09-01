namespace AllTask.Core.Entities
{
    public class Routine : BaseEntity
    {
        protected Routine()
        {}

        public Routine(string name, int idCategory, Category category, bool repeats) : base()
        {
            Name = name;
            IdCategory = idCategory;
            Category = category;
            Repeats = repeats;
        }

        public string Name { get; private set; }
        public int IdCategory { get; private set; }
        public Category Category { get; private set; }
        public bool Repeats { get; private set; }
    }
}
