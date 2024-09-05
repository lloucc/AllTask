using AllTask.Core.Enums;

namespace AllTask.Core.Entities
{
    public class Routine : BaseEntity
    {
        protected Routine()
        {}

        public Routine(string name, int categoryId, Category category, bool repeats) : base()
        {
            Name = name;
            CategoryId = categoryId;
            Category = category;
        }

        public string Name { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
        public List<Task> Tasks { get; private set; }
        public List<DaysOfWeek> Days { get; private set; }
        
    }
}
