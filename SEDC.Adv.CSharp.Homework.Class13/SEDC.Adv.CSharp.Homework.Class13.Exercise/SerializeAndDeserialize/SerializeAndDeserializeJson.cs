using SEDC.Adv.CSharp.Homework.Class13.Exercise.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class13.Exercise.SerializeAndDeserialize
{
    public class SerializeAndDeserializeJson
    {
        private const string _dogJsonContent =
            "{\"Name\": {name},\"Color\": {color},\"Age\": {age} }";
        // Serialize 
        public string SerializeDog(Dog dog)
        {
            StringBuilder sb = new StringBuilder(_dogJsonContent);

            return sb.Replace("{name}", dog.Name)
               .Replace("{color}", dog.Color)
               .Replace("{age}", dog.Age.ToString())
               .ToString();
        }
        // Deserialize 
        public Dog DeserializeDog(string json)
        {
            #region Procces
            /* 1 - Remove brackets "{"
               2 - Split on every ',' 
            [
                "Name" : Spark
                "Color" : Red
                "Age" : 5
            ]
            3 - Split ':'
            4 - KEY: "Name" VALUE: "Spark"
            Map every property from student to value
            */
            #endregion

            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\t", "")
                .Replace("\n", "")
                .Replace("\"", "");
            var properties = content.Split(',');

            Dictionary<string, string> dictionaryProperties = new Dictionary<string, string>();
            foreach (var property in properties)
            {
                // "Name" : Spark
                var pair = property.Split(':');
                dictionaryProperties.Add(pair[0].Trim(), pair[1].Trim());
            }

            var dog = new Dog();
            dog.Name = dictionaryProperties["Name"];
            dog.Color = dictionaryProperties["Color"];
            dog.Age = int.Parse(dictionaryProperties["Age"]);

            return dog;
        }
    }
}
