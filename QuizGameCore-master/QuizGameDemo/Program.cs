var example = new Example("My best cutie value");

Console.WriteLine("Hello, World!");


public class Example
{
    private readonly string value;


    public Example(string value)
    {
        this.value = value;
    }


    public string SomeProperty => value;


    public string SomeMethod() => value;
}