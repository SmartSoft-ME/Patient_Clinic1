

namespace Patients
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }

        public List<Injury> Injuries { get; } = new();
        public Patient(string name, string? address, int age)
        {
            
            Name = name;
            Address = address;
            Age = age;
        }
        public void update(string name, string address, int age)
        {
            this.Name = name;
            this.Address = address;
            this.Age = age;
            

        }
    }
}