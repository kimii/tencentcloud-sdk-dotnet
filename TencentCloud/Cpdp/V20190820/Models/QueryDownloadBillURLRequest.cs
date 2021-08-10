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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryDownloadBillURLRequest : AbstractModel
    {
        
        /// <summary>
        /// 分配给商户的AppId。进件成功后返给商户方的AppId。
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 渠道编号。固定值：ZSB2B
        /// </summary>
        [JsonProperty("ChannelCode")]
        public string ChannelCode{ get; set; }

        /// <summary>
        /// 对账单日期，格式yyyyMMdd
        /// </summary>
        [JsonProperty("BillDate")]
        public string BillDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "ChannelCode", this.ChannelCode);
            this.SetParamSimple(map, prefix + "BillDate", this.BillDate);
        }
    }
}

