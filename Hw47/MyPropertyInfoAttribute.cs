namespace Hw47;
[AttributeUsage(AttributeTargets.Property)]
public class MyPropertyInfoAttribute : Attribute
{
    public string SerializationName { get; set; }

    public MyPropertyInfoAttribute(string serializationName)
    {
        SerializationName = serializationName;
    }
}