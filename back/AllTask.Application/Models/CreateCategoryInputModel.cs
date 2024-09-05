using AllTask.Core.Entities;

namespace AllTask.Application.Models;

public class CreateCategoryInputModel
{
    public string Name { get; set; }

    public Category FromEntity()
    {
        return new Category(Name);
    }
}