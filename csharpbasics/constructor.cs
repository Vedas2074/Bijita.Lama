namespace LearningClasses
{
    internal class Person
    {
        //Default parameterless constructor
        public Person()
        {

        }
        //paramatrized constructor
        public Person(string n, string add, byte a)
        {
            this.Name = n;
            this.Address = add;
            this.Age = a;
        }
        public string Name { get; set; }

        public string Address { get; set; }

        public byte Age { get; set; } 
        
    }
}