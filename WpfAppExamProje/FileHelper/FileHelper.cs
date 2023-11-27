using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace WpfAppExamProje.FileHelper
{
    public class FileHelper
    {
        public static void Write(object obj, string filename)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            using (var sw = new StreamWriter(filename))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, obj);
                }
            }
        }

        public static T Read<T>(string filename) where T : class
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            using (var sr = new StreamReader(filename))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    var result = serializer.Deserialize<T>(jr);
                    return result;
                }
            }
        }
    }
}
