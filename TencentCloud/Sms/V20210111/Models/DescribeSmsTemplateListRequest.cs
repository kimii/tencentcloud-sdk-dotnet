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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSmsTemplateListRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板 ID 数组。
        /// <dx-alert infotype="notice" title="注意">默认数组长度最大100</dx-alert>
        /// </summary>
        [JsonProperty("TemplateIdSet")]
        public ulong?[] TemplateIdSet{ get; set; }

        /// <summary>
        /// 是否国际/港澳台短信：
        /// 0：表示国内短信。
        /// 1：表示国际/港澳台短信。
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TemplateIdSet.", this.TemplateIdSet);
            this.SetParamSimple(map, prefix + "International", this.International);
        }
    }
}

