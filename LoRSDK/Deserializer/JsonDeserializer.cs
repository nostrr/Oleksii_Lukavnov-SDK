using LotRSDK.Interfaces;
using Newtonsoft.Json;

namespace LotRSDK.Deserializer
{
    public class JsonDeserializer : IDeserialize
    {
        public T Deserialize<T>(string value)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            catch
            {
                throw new JsonException($"Unable to cast '{value}' string to the specified type ${typeof(T).Name}");
            }
        }
    }
}
