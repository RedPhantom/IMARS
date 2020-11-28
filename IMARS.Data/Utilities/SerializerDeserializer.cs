using System;
using System.Text.Json;

namespace IMARS.Data.Utilities
{
    public static class SerializerDeserializer
    {
        public static string Serialize(object o)
        {
            return JsonSerializer.Serialize(o);
        }

        public static object Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
