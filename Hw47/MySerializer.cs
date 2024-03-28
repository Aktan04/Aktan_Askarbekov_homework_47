using System.Reflection;
using System.Text;

namespace Hw47;

public class MySerializer<T>
{
    private T obj;

    public MySerializer(T obj)
    {
        this.obj = obj;
    }

    public string SerializeObject(T obj)
    {
        StringBuilder sb = new StringBuilder();
        TypeInfo type = typeof(T).GetTypeInfo();
        PropertyInfo[] properties = type.GetProperties();

        foreach (var property in properties)
        {
            string propertyName = property.Name;
            object value = property.GetValue(obj);
            sb.AppendLine($"{propertyName} : {value}");
        }

        return sb.ToString();
    }

    public string Serialize()
    {
        return SerializeObject(obj);
    }
}