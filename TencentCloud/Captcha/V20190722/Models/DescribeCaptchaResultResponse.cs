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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 1 OK 验证通过
        /// 6 user code len error 验证码长度不匹配，请检查请求是否带Randstr参数，Randstr参数大小写是否有误
        /// 7 captcha no match 验证码答案不匹配/Randstr参数不匹配，请重新生成Randstr、Ticket进行校验
        /// 8 verify timeout 验证码签名超时，票据已过期，请重新生成Randstr、Ticket票进行校验
        /// 9 Sequnce repeat 验证码签名重放，票据重复使用，请重新生成Randstr、Ticket进行校验
        /// 10 Sequnce invalid 验证码签名序列
        /// 11 Cookie invalid 验证码cookie信息不合法，非法请求，可能存在不规范接入
        /// 12 sig len error 签名长度错误
        /// 13 verify ip no match ip不匹配，非法请求，可能存在不规范接入
        /// 15 decrypt fail 验证码签名解密失败，票据校验失败，请检查Ticket票据是否与前端返回Ticket一致
        /// 16 appid no match 验证码强校验appid错误，前端代码 data-appid 和后端 CaptchaAppId 所填写的值，必须和 验证码控制台 中【验证详情】>【基础配置】内的 AppID 一致,请检查CaptchaAppId是否为控制台基础配置界面系统分配的APPID
        /// 17 cmd no much 验证码系统命令不匹配
        /// 18 uin no match 号码不匹配
        /// 19 seq redirect 重定向验证
        /// 20 opt no vcode 操作使用pt免验证码校验错误
        /// 21 diff 差别，验证错误
        /// 22 captcha type not match 验证码类型与拉取时不一致
        /// 23 verify type error 验证类型错误
        /// 24 invalid pkg 非法请求包
        /// 25 bad visitor 策略拦截
        /// 26 system busy 系统内部错误
        /// 100 param err appsecretkey 参数校验错误，CaptchaAppId 与对应 AppSecretKey 不一致，需检查 AppSecretKey 参数是否有误。其中 CaptchaAppId、 AppSecretKey 在 验证码控制台 的【验证详情】>【基础配置】中获取
        /// 104 Ticket Reuse 票据重复使用，同个票据验证多次，请重新生成Randstr、Ticket进行校验
        /// </summary>
        [JsonProperty("CaptchaCode")]
        public long? CaptchaCode{ get; set; }

        /// <summary>
        /// 状态描述及验证错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CaptchaMsg")]
        public string CaptchaMsg{ get; set; }

        /// <summary>
        /// [0,100]，恶意等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvilLevel")]
        public long? EvilLevel{ get; set; }

        /// <summary>
        /// 前端获取验证码时间，时间戳格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GetCaptchaTime")]
        public long? GetCaptchaTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "CaptchaCode", this.CaptchaCode);
            this.SetParamSimple(map, prefix + "CaptchaMsg", this.CaptchaMsg);
            this.SetParamSimple(map, prefix + "EvilLevel", this.EvilLevel);
            this.SetParamSimple(map, prefix + "GetCaptchaTime", this.GetCaptchaTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

