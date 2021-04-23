using System.Collections.Generic;

namespace ClassBasedInterfaceType.Models
{
    public class Query
    {
        public string Hello => "World!";
        
        // This doesn't work since Orange and Pineapple become interfaces
        // public IEnumerable<Fruit> GetFruits() => new Fruit[] {new Orange(), new Pineapple()};
    }
}