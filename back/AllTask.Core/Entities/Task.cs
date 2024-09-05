using AllTask.Core.Enums;

namespace AllTask.Core.Entities;

public class Task : BaseEntity
{
    protected Task(){ }

    public Task(string name, Routine routine, int routineId) : base()
    {
        Name = name;
        Routine = routine;
        RoutineId = routineId;
    }

    public string Name { get; private set; }
    public Routine Routine { get; private set; }
    public int RoutineId { get; private set; }
    public Category Category { get; private set; }
    public int CategoryId { get; private set; }
    public List<DaysOfWeek> Days { get; private set; }
}