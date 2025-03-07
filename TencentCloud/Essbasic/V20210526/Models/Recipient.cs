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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Recipient : AbstractModel
    {
        
        /// <summary>
        /// 签署人唯一标识
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 签署方类型：ENTERPRISE-企业INDIVIDUAL-自然人
        /// </summary>
        [JsonProperty("RecipientType")]
        public string RecipientType{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 签署方备注信息
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 是否需要校验
        /// </summary>
        [JsonProperty("RequireValidation")]
        public bool? RequireValidation{ get; set; }

        /// <summary>
        /// 是否必须填写
        /// </summary>
        [JsonProperty("RequireSign")]
        public bool? RequireSign{ get; set; }

        /// <summary>
        /// 签署类型
        /// </summary>
        [JsonProperty("SignType")]
        public long? SignType{ get; set; }

        /// <summary>
        /// 签署顺序：数字越小优先级越高
        /// </summary>
        [JsonProperty("RoutingOrder")]
        public long? RoutingOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "RecipientType", this.RecipientType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RequireValidation", this.RequireValidation);
            this.SetParamSimple(map, prefix + "RequireSign", this.RequireSign);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamSimple(map, prefix + "RoutingOrder", this.RoutingOrder);
        }
    }
}

