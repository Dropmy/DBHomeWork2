namespace MyWork
{
    public class Auto
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Mark { get; set; }
        public int Cost { get; set; }
        public int Amount { get; set; }
    }

    public class Mark
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? Description { get; set; }
    }

    public class Engine
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
        public int MaxSpeed { get; set; }
    }

    public class Wheel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
    }

    public class CarNumber
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public int RegNum { get; set; }
    }
}
