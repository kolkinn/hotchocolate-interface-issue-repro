using HotChocolate.Types;

namespace InterfaceBasedInterfaceType.Models
{
    [InterfaceType("Fruit")]
    public interface IFruit
    {
        public string Taste { get; }
    }

    public class Orange : IFruit
    {
        public string Taste { get; } = "Sweet";
        public string Color { get; } = "Orange";
    }

    public class Pineapple : IFruit
    {
        public string Taste { get; } = "Sweet";
        public string Shape { get; } = "Strange";
    }
}