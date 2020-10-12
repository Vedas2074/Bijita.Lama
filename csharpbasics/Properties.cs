class Human
{
    internal string name;
    byte age = 23;
    public byte Age//property pascal casing
    {
        get
        {
            return age;

        }
        set
        {
            if(value > 20 && value < 30)
                age = value;
            
        }

        
    }
    //Autoimplemented property
    public string Name { get; private set; }
    //read only property
    public string Address { get; }
}