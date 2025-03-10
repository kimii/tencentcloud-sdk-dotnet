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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulTopRequest : AbstractModel
    {
        
        /// <summary>
        /// 漏洞风险服务器top，1-100
        /// </summary>
        [JsonProperty("Top")]
        public ulong? Top{ get; set; }

        /// <summary>
        /// 1: web应用漏洞 2=系统组件漏洞3:安全基线 4: Linux系统漏洞 5: windows补丁，传0的时候表示查应急漏洞
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Top", this.Top);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
        }
    }
}

