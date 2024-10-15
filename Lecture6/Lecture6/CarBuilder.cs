namespace Lecture6
{
    internal class CarBuilder
    {
        private int Id { get; set; } = 4321;
        private string Name { get; set; } = "default car";
        private string Description { get; set; }
        private int Age { get; set; } = 0;
        private int NumWheels { get; set; } = 4;
        private string Color { get; set; }
        private string EngineType { get; set; }

        public CarBuilder()
        {

        }

        public CarBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public CarBuilder WithDescription(string description)
        {
            Description = description;
            return this;
        }

        public CarBuilder WithId(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id");

            Id = id;
            return this;
        }


        public Car Build()
        {
            Car returnCar = new Car()
            {
                Id = Id,
                Age = Age,
                Color = Color,
                EngineType = EngineType,
                Description = Description,
                Name = Name,
                NumWheels = NumWheels
            };

            return returnCar;
        }
    }
}
