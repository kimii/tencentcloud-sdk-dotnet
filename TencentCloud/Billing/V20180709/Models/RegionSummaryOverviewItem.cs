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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionSummaryOverviewItem : AbstractModel
    {
        
        /// <summary>
        /// 地域ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 实际花费
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// 费用所占百分比，两位小数
        /// </summary>
        [JsonProperty("RealTotalCostRatio")]
        public string RealTotalCostRatio{ get; set; }

        /// <summary>
        /// 现金金额
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// 赠送金金额
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// 代金券金额
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// 账单月份，格式2019-08
        /// </summary>
        [JsonProperty("BillMonth")]
        public string BillMonth{ get; set; }

        /// <summary>
        /// 原价，单位为元。TotalCost字段自账单3.0（即2021-05）之后开始生效，账单3.0之前返回"-"。合同价的情况下，TotalCost字段与官网价格存在差异，也返回“-”。
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "RealTotalCostRatio", this.RealTotalCostRatio);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "BillMonth", this.BillMonth);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
        }
    }
}

