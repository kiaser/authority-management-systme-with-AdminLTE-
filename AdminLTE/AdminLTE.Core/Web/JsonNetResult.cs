using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web;
using AdminLTE.Core.Web.Json;

namespace AdminLTE.Core.Web
{
    /// <summary>
    /// 重写 MVC5 的JsonResult功能，因为默认的方式不支持自定义序列化。
    /// </summary>
    public class JsonNetResult : JsonResult
    {
        private JsonSerializerSettings _serializerSettings;

        public JsonSerializerSettings SerializerSettings
        {
            get { return _serializerSettings ?? (_serializerSettings = new JsonSerializerSettings()); }
            set { _serializerSettings = value; }
        }

        public JsonNetResult(object data) : this()
        {

            this.Data = data;

        }

        public JsonNetResult()
        {
            JsonRequestBehavior = JsonRequestBehavior.DenyGet;

            this.SerializerSettings.Converters.Add(DecimalJsonConverter.Instance);

            //this.SerializerSettings.Converters.Add();


        }


        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            //if (JsonRequestBehavior == JsonRequestBehavior.DenyGet && String.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
            //{
            //    throw new InvalidOperationException("此请求已被阻止，因为当用在 GET 请求中时，会将敏感信息透漏给第三方网站。若要允许 GET 请求，请将 JsonRequestBehavior 设置为 AllowGet。");
            //}

            HttpResponseBase response = context.HttpContext.Response;


            response.ContentType = !string.IsNullOrEmpty(ContentType) ? ContentType : "application/json";

            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            if (Data != null)
            {
                JsonSerializer serializer = JsonSerializer.CreateDefault(SerializerSettings);
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(response.Output)
                {
                    CloseOutput = false
                })
                {
                    serializer.Serialize(jsonTextWriter, this.Data);
                }
            }
        }
    }
}