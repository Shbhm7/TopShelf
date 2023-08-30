
namespace JsonFileService
{
    public class DataModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}