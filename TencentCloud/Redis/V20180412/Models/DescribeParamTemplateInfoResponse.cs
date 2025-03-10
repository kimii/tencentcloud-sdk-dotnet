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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeParamTemplateInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例参数个数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 参数模板 ID。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 参数模板名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 产品类型：1 – Redis2.8内存版（集群架构），2 – Redis2.8内存版（标准架构），3 – CKV 3.2内存版(标准架构)，4 – CKV 3.2内存版(集群架构)，5 – Redis2.8内存版（单机），6 – Redis4.0内存版（标准架构），7 – Redis4.0内存版（集群架构），8 – Redis5.0内存版（标准架构），9 – Redis5.0内存版（集群架构）
        /// </summary>
        [JsonProperty("ProductType")]
        public ulong? ProductType{ get; set; }

        /// <summary>
        /// 参数模板描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 参数详情
        /// </summary>
        [JsonProperty("Items")]
        public ParameterDetail[] Items{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

