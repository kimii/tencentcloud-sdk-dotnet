/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PushUrlsCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// URL 列表，需要包含协议头部 http:// 或 https://
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 指定预热请求回源时 HTTP 请求的 User-Agent 头部
        /// 默认为 TencentCdn
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 预热生效区域
        /// mainland：预热至境内节点
        /// overseas：预热至境外节点
        /// global：预热全球节点
        /// 不填充情况下，默认为 mainland， URL 中域名必须在对应区域启用了加速服务才能提交对应区域的预热任务
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 填写"middle"或不填充时预热至中间层节点。
        /// 注意：中国境外区域预热，资源默认加载至中国境外边缘节点，所产生的边缘层流量会计入计费流量。
        /// </summary>
        [JsonProperty("Layer")]
        public string Layer{ get; set; }

        /// <summary>
        /// 是否递归解析m3u8文件中的ts分片预热
        /// 注意事项：
        /// 1. 该功能要求m3u8索引文件能直接请求获取
        /// 2. 当前只支持递归解析一级索引和子索引中的ts分片，递归深度不超过3层
        /// 3. 解析获取的ts分片会正常累加每日预热用量，当用量超出配额时，会静默处理，不再执行预热
        /// </summary>
        [JsonProperty("ParseM3U8")]
        public bool? ParseM3U8{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Layer", this.Layer);
            this.SetParamSimple(map, prefix + "ParseM3U8", this.ParseM3U8);
        }
    }
}

