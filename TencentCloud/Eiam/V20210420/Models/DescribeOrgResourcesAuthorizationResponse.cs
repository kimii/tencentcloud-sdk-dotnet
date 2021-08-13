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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrgResourcesAuthorizationResponse : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 授权机构ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodeId")]
        public string OrgNodeId{ get; set; }

        /// <summary>
        /// 机构名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodeName")]
        public string OrgNodeName{ get; set; }

        /// <summary>
        /// 机构目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodePath")]
        public string OrgNodePath{ get; set; }

        /// <summary>
        /// 资源列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthorizationOrgResourceList")]
        public AuthorizationResouceEntityInfo[] AuthorizationOrgResourceList{ get; set; }

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
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "OrgNodeId", this.OrgNodeId);
            this.SetParamSimple(map, prefix + "OrgNodeName", this.OrgNodeName);
            this.SetParamSimple(map, prefix + "OrgNodePath", this.OrgNodePath);
            this.SetParamArrayObj(map, prefix + "AuthorizationOrgResourceList.", this.AuthorizationOrgResourceList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

