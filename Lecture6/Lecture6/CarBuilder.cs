namespace Lecture6
{
    internal class CarBuilder
    {
        private readonly Car _car;
        public CarBuilder()
        {
            _car = new Car();
        }

        public CarBuilder WithName(string name)
        {
            _car.Name = name;
            return this;
        }

        public CarBuilder WithDescription(string description)
        {
            _car.Description = description;
            return this;
        }

        public CarBuilder WithId(int id)
        {
            _car.Id = id;
            return this;
        }

        // Remaining methods for Car's properties

        public Car Build()
        {
            return _car;
        }
    }
}
