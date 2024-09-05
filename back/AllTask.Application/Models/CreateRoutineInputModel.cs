using System.ComponentModel;
using AllTask.Core.Entities;
using AllTask.Core.Enums;

namespace AllTask.Application.Models;

public class CreateRoutineInputModel
{
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public List<int> Days { get; set; }

    public Routine FromEntity()
    {
        List<DaysOfWeek> daysEnum = [];
        Days.ForEach(d =>
        {
            switch (d)
            {
                case 0:
                    daysEnum.Add(DaysOfWeek.Domingo);
                    break;
                case 1:
                    daysEnum.Add(DaysOfWeek.Segunda);
                    break;
                case 2:
                    daysEnum.Add(DaysOfWeek.Terça);
                    break;
                case 3:
                    daysEnum.Add(DaysOfWeek.Quarta);
                    break;
                case 4:
                    daysEnum.Add(DaysOfWeek.Quinta);
                    break;
                case 5:
                    daysEnum.Add(DaysOfWeek.Sexta);
                    break;
                case 6:
                    daysEnum.Add(DaysOfWeek.Sabado);
                    break;
                default:
                    throw new InvalidEnumArgumentException("Dia inválido [0-6]");
            }
        });
        
        return new Routine(Name, CategoryId, daysEnum);
    }
}