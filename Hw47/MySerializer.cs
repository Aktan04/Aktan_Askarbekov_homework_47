using System.Reflection;
using System.Text;

namespace Hw47;

public class MySerializer<T>
{
    private T _obj;

    public MySerializer(T obj)
    {
        _obj = obj;
    }

    public string SerializeObject(T obj)
    {
        StringBuilder sb = new StringBuilder();
        TypeInfo type = typeof(T).GetTypeInfo();
        PropertyInfo[] properties = type.GetProperties();

        foreach (var property in properties)
        {
            string propertyName = property.Name;
            object? value = property.GetValue(obj);
            sb.AppendLine($"{propertyName} : {value}");
        }

        return sb.ToString();
    }

    public string Serialize()
    {
        StringBuilder sb = new StringBuilder();
        PropertyInfo[] properties = typeof(T).GetProperties();

        foreach (var property in properties)
        {
            MyPropertyInfoAttribute attribute = (MyPropertyInfoAttribute)Attribute.GetCustomAttribute(property, typeof(MyPropertyInfoAttribute));
            string propertyName = attribute != null ? attribute.SerializationName : property.Name;
            object value = property.GetValue(_obj);
            sb.AppendLine($"{propertyName}: {value}");
        }

        return sb.ToString();
    }
}