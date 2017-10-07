using Newtonsoft.Json;

namespace AdminLTE.Core.Web
{
    /// <summary>
    /// Ajax调用返回的结果。
    /// </summary>
    public class AjaxResult
    {
        /// <summary>
        /// 返回的状态。
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 信息描述。
        /// </summary>
        [JsonProperty("message")]

        public string Message { get; set; }

        /// <summary>
        /// 需要返回的数据。
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }

        /// <summary>
        ///  表示未登录的请求。
        /// </summary>
        [JsonProperty("unLoggedRequest")]
        public bool UnLoggedRequest { get; set; }

    }
}