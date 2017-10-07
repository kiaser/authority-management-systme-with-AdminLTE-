using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdminLTE.Core.Web.Json
{
    /// <summary>
    /// 自定义<see cref="decimal"/>类型的序列化方式，解决在javascript中，数字过大会自动降低数字的精度；
    /// 如果数字的长度大于10,则改序化成为字符串格式的字符串。
    /// </summary>
    internal sealed class DecimalJsonConverter : JsonConverter
    {

        public static DecimalJsonConverter Instance = new DecimalJsonConverter();

        private static decimal s_maxDecimal = (decimal)Math.Pow(10, 10);
        private static decimal s_minDecimal = -(decimal)Math.Pow(10, 10);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            decimal num = (decimal)value;
            if (num > s_maxDecimal || num < s_minDecimal)
            {
                writer.WriteValue(num.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteValue(num);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(decimal) || objectType == typeof(decimal?);
        }

        /// <summary>
        /// 不提供返序列化的功能。
        /// </summary>
        public override bool CanRead
        {
            get { return false; }
        }
    }
}
