using Entities.Abstract;

namespace Entities
{

    public class EmployeeEntity:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
