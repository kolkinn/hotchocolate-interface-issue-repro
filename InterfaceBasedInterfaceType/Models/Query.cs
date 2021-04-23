using System.Collections.Generic;

namespace InterfaceBasedInterfaceType.Models
{
    public class Query
    {
        public string Hello => "World!";
        
        public IEnumerable<IFruit> GetFruits() => new IFruit[] {new Orange(), new Pineapple()};
    }
}