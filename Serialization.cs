using System.Runtime.Serialization;

namespace PohodaIntegration
{
    public class Serialization<T> where T : class
    {
        public static T DeserializeFromXmlFile(string pathToFile)
        {
            if (string.IsNullOrEmpty(pathToFile) || !File.Exists(pathToFile))
            {
                throw new ArgumentNullException("pathToFile");
            }

            var deserializer = new DataContractSerializer(typeof(T));

            using var stream = File.OpenRead(pathToFile);
            return (T)deserializer.ReadObject(stream);
        }
    }
}
