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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceCreateProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 加速区域名称。
        /// </summary>
        [JsonProperty("AccessRegion")]
        public string AccessRegion{ get; set; }

        /// <summary>
        /// 通道带宽上限，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// （旧参数，请切换到RealServerRegion）源站区域名称。
        /// </summary>
        [JsonProperty("DestRegion")]
        public string DestRegion{ get; set; }

        /// <summary>
        /// （旧参数，请切换到Concurrent）通道并发量上限，表示同时在线的连接数，单位：万。
        /// </summary>
        [JsonProperty("Concurrency")]
        public long? Concurrency{ get; set; }

        /// <summary>
        /// （新参数）源站区域名称。
        /// </summary>
        [JsonProperty("RealServerRegion")]
        public string RealServerRegion{ get; set; }

        /// <summary>
        /// （新参数）通道并发量上限，表示同时在线的连接数，单位：万。
        /// </summary>
        [JsonProperty("Concurrent")]
        public long? Concurrent{ get; set; }

        /// <summary>
        /// 计费方式，0表示按带宽计费，1表示按流量计费。默认按带宽计费
        /// </summary>
        [JsonProperty("BillingType")]
        public long? BillingType{ get; set; }

        /// <summary>
        /// IP版本，可取值：IPv4、IPv6，默认值IPv4
        /// </summary>
        [JsonProperty("IPAddressVersion")]
        public string IPAddressVersion{ get; set; }

        /// <summary>
        /// 网络类型，可取值：normal、cn2，默认值normal
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 通道组类型。Thunder表示标准通道组，Accelerator表示游戏加速器通道。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessRegion", this.AccessRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "DestRegion", this.DestRegion);
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
            this.SetParamSimple(map, prefix + "RealServerRegion", this.RealServerRegion);
            this.SetParamSimple(map, prefix + "Concurrent", this.Concurrent);
            this.SetParamSimple(map, prefix + "BillingType", this.BillingType);
            this.SetParamSimple(map, prefix + "IPAddressVersion", this.IPAddressVersion);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
        }
    }
}

