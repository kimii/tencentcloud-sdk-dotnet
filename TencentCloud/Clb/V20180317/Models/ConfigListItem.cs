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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigListItem : AbstractModel
    {
        
        /// <summary>
        /// 配置ID
        /// </summary>
        [JsonProperty("UconfigId")]
        public string UconfigId{ get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        [JsonProperty("ConfigType")]
        public string ConfigType{ get; set; }

        /// <summary>
        /// 配置名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置内容
        /// </summary>
        [JsonProperty("ConfigContent")]
        public string ConfigContent{ get; set; }

        /// <summary>
        /// 增加配置时间
        /// </summary>
        [JsonProperty("CreateTimestamp")]
        public string CreateTimestamp{ get; set; }

        /// <summary>
        /// 修改配置时间
        /// </summary>
        [JsonProperty("UpdateTimestamp")]
        public string UpdateTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UconfigId", this.UconfigId);
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigContent", this.ConfigContent);
            this.SetParamSimple(map, prefix + "CreateTimestamp", this.CreateTimestamp);
            this.SetParamSimple(map, prefix + "UpdateTimestamp", this.UpdateTimestamp);
        }
    }
}

