namespace _12_Employee
{
    public class Employee
    {
        public Employee(string name, string type,int id)
        {
            this.Id          = id;
            this.Name       = name;
            this.Type       = type;
        
        }

        public int Id { get; set; }

        public string Name  { get; set;}
        public string Type  { get;set;}

    }
}