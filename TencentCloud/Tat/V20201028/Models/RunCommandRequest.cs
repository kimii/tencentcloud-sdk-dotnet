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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64编码后的命令内容，长度不可超过64KB。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 待执行命令的实例ID列表，上限100。支持实例类型：
        /// <li> CVM
        /// <li> LIGHTHOUSE
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 命令名称。名称仅支持中文、英文、数字、下划线、分隔符"-"、小数点，最大长度不能超60个字节。
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }

        /// <summary>
        /// 命令描述。不超过120字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 命令类型，目前仅支持取值：SHELL。默认：SHELL。
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// 命令执行路径，默认：/root。
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// 命令超时时间，默认60秒。取值范围[1, 86400]。
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 是否保存命令，取值范围：
        /// <li> True：保存
        /// <li> False：不保存
        /// 默认为 False。
        /// </summary>
        [JsonProperty("SaveCommand")]
        public bool? SaveCommand{ get; set; }

        /// <summary>
        /// 是否启用自定义参数功能。
        /// 一旦创建，此值不提供修改。
        /// 默认值：false。
        /// </summary>
        [JsonProperty("EnableParameter")]
        public bool? EnableParameter{ get; set; }

        /// <summary>
        /// 启用自定义参数功能时，自定义参数的默认取值。字段类型为json encoded string。如：{\"varA\": \"222\"}。
        /// key为自定义参数名称，value为该参数的默认取值。kv均为字符串型。
        /// 如果 Parameters 未提供，将使用这里的默认值进行替换。
        /// 自定义参数最多20个。
        /// 自定义参数名称需符合以下规范：字符数目上限64，可选范围【a-zA-Z0-9-_】。
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// Command 的自定义参数。字段类型为json encoded string。如：{\"varA\": \"222\"}。
        /// key为自定义参数名称，value为该参数的默认取值。kv均为字符串型。
        /// 如果未提供该参数取值，将使用 DefaultParameters 进行替换。
        /// 自定义参数最多20个。
        /// 自定义参数名称需符合以下规范：字符数目上限64，可选范围【a-zA-Z0-9-_】。
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 如果保存命令，可为命令设置标签。列表长度不超过10。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 在 CVM 或 Lighthouse 实例中执行命令的用户名称。
        /// 使用最小权限执行命令是权限管理的最佳实践，建议您以普通用户身份执行云助手命令。默认情况下，在Linux实例中以root用户执行命令。
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "SaveCommand", this.SaveCommand);
            this.SetParamSimple(map, prefix + "EnableParameter", this.EnableParameter);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Username", this.Username);
        }
    }
}

