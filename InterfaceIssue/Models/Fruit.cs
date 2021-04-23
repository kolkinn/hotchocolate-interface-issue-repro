using HotChocolate.Types;

namespace InterfaceIssue.Models
{
    [InterfaceType]
    public class Fruit
    {
        public string Taste { get; } = "Sweet";
    }

    public class Orange : Fruit
    {
        public string Color { get; } = "Orange";
    }

    public class Pineapple : Fruit
    {
        public string Shape { get; } = "Strange";
    }
}