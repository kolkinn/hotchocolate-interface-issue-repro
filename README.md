# The issue
When using pure code-first and decorating a class or record with the attribute `InterfaceType`, all classes deriving the type also become interface types in the GraphQL schema.

See the [class based interface type](ClassBasedInterfaceType/Models/Fruit.cs) and its project for a reproduction of the issue.

Here is a working example using an [interface based interface type](InterfaceBasedInterfaceType/Models/IFruit.cs).

## C# code

```c#
public class Query
{
    public string Hello => "World!";
    
    // This doesn't work since Orange and Pineapple become interfaces
    // public IEnumerable<Fruit> GetFruits() => new Fruit[] {new Orange(), new Pineapple()};
}

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
```

## Resulting GraphQL schema

```graphql
schema {
    query: Query
}

interface Fruit {
    taste: String
}

interface Orange {
    color: String
    taste: String
}

interface Pineapple {
    shape: String
    taste: String
}

type Query {
    hello: String
}
```

## Expected GraphQL schema

```graphql
schema {
    query: Query
}

interface Fruit {
    taste: String
}

type Orange implements Fruit{
    color: String
    taste: String
}

type Pineapple implements Fruit {
    shape: String
    taste: String
}

type Query {
    hello: String
}
```