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

namespace TencentCloud.Ocr.V20181119
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ocr.V20181119.Models;

   public class OcrClient : AbstractClient{

       private const string endpoint = "ocr.tencentcloudapi.com";
       private const string version = "2018-11-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OcrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口支持广告商品图片内文字的检测和识别，返回文本框位置与文字内容。
        /// 
        /// 产品优势：针对广告商品图片普遍存在较多繁体字、艺术字的特点，进行了识别能力的增强。支持中英文、横排、竖排以及倾斜场景文字识别。文字识别的召回率和准确率能达到96%以上。
        /// </summary>
        /// <param name="req"><see cref="AdvertiseOCRRequest"/></param>
        /// <returns><see cref="AdvertiseOCRResponse"/></returns>
        public async Task<AdvertiseOCRResponse> AdvertiseOCR(AdvertiseOCRRequest req)
        {
             JsonResponseModel<AdvertiseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AdvertiseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdvertiseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持广告商品图片内文字的检测和识别，返回文本框位置与文字内容。
        /// 
        /// 产品优势：针对广告商品图片普遍存在较多繁体字、艺术字的特点，进行了识别能力的增强。支持中英文、横排、竖排以及倾斜场景文字识别。文字识别的召回率和准确率能达到96%以上。
        /// </summary>
        /// <param name="req"><see cref="AdvertiseOCRRequest"/></param>
        /// <returns><see cref="AdvertiseOCRResponse"/></returns>
        public AdvertiseOCRResponse AdvertiseOCRSync(AdvertiseOCRRequest req)
        {
             JsonResponseModel<AdvertiseOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AdvertiseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdvertiseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持作业算式题目的自动识别和判分，目前覆盖 K12 学力范围内的 11 种题型，包括加减乘除四则、加减乘除已知结果求运算因子、判断大小、约等于估算、带余数除法、分数四则运算、单位换算、竖式加减法、竖式乘除法、脱式计算和解方程，平均识别精度达到93%以上。
        /// </summary>
        /// <param name="req"><see cref="ArithmeticOCRRequest"/></param>
        /// <returns><see cref="ArithmeticOCRResponse"/></returns>
        public async Task<ArithmeticOCRResponse> ArithmeticOCR(ArithmeticOCRRequest req)
        {
             JsonResponseModel<ArithmeticOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ArithmeticOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ArithmeticOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持作业算式题目的自动识别和判分，目前覆盖 K12 学力范围内的 11 种题型，包括加减乘除四则、加减乘除已知结果求运算因子、判断大小、约等于估算、带余数除法、分数四则运算、单位换算、竖式加减法、竖式乘除法、脱式计算和解方程，平均识别精度达到93%以上。
        /// </summary>
        /// <param name="req"><see cref="ArithmeticOCRRequest"/></param>
        /// <returns><see cref="ArithmeticOCRResponse"/></returns>
        public ArithmeticOCRResponse ArithmeticOCRSync(ArithmeticOCRRequest req)
        {
             JsonResponseModel<ArithmeticOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ArithmeticOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ArithmeticOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对中国大陆主流银行卡正反面关键字段的检测与识别，包括卡号、卡类型、卡名字、银行信息、有效期。支持竖排异形卡识别、多角度旋转图片识别。支持对复印件、翻拍件、边框遮挡的银行卡进行告警，可应用于各种银行卡信息有效性校验场景，如金融行业身份认证、第三方支付绑卡等场景。
        /// </summary>
        /// <param name="req"><see cref="BankCardOCRRequest"/></param>
        /// <returns><see cref="BankCardOCRResponse"/></returns>
        public async Task<BankCardOCRResponse> BankCardOCR(BankCardOCRRequest req)
        {
             JsonResponseModel<BankCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对中国大陆主流银行卡正反面关键字段的检测与识别，包括卡号、卡类型、卡名字、银行信息、有效期。支持竖排异形卡识别、多角度旋转图片识别。支持对复印件、翻拍件、边框遮挡的银行卡进行告警，可应用于各种银行卡信息有效性校验场景，如金融行业身份认证、第三方支付绑卡等场景。
        /// </summary>
        /// <param name="req"><see cref="BankCardOCRRequest"/></param>
        /// <returns><see cref="BankCardOCRResponse"/></returns>
        public BankCardOCRResponse BankCardOCRSync(BankCardOCRRequest req)
        {
             JsonResponseModel<BankCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持银行回单全字段的识别，包括付款开户行、收款开户行、付款账号、收款账号、回单类型、回单编号、币种、流水号、凭证号码、交易机构、交易金额、手续费、日期等字段信息。
        ///            
        /// </summary>
        /// <param name="req"><see cref="BankSlipOCRRequest"/></param>
        /// <returns><see cref="BankSlipOCRResponse"/></returns>
        public async Task<BankSlipOCRResponse> BankSlipOCR(BankSlipOCRRequest req)
        {
             JsonResponseModel<BankSlipOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankSlipOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankSlipOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持银行回单全字段的识别，包括付款开户行、收款开户行、付款账号、收款账号、回单类型、回单编号、币种、流水号、凭证号码、交易机构、交易金额、手续费、日期等字段信息。
        ///            
        /// </summary>
        /// <param name="req"><see cref="BankSlipOCRRequest"/></param>
        /// <returns><see cref="BankSlipOCRResponse"/></returns>
        public BankSlipOCRResponse BankSlipOCRSync(BankSlipOCRRequest req)
        {
             JsonResponseModel<BankSlipOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankSlipOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankSlipOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持快速精准识别营业执照上的字段，包括统一社会信用代码、公司名称、经营场所、主体类型、法定代表人、注册资金、组成形式、成立日期、营业期限和经营范围等字段。
        /// </summary>
        /// <param name="req"><see cref="BizLicenseOCRRequest"/></param>
        /// <returns><see cref="BizLicenseOCRResponse"/></returns>
        public async Task<BizLicenseOCRResponse> BizLicenseOCR(BizLicenseOCRRequest req)
        {
             JsonResponseModel<BizLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BizLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BizLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持快速精准识别营业执照上的字段，包括统一社会信用代码、公司名称、经营场所、主体类型、法定代表人、注册资金、组成形式、成立日期、营业期限和经营范围等字段。
        /// </summary>
        /// <param name="req"><see cref="BizLicenseOCRRequest"/></param>
        /// <returns><see cref="BizLicenseOCRResponse"/></returns>
        public BizLicenseOCRResponse BizLicenseOCRSync(BizLicenseOCRRequest req)
        {
             JsonResponseModel<BizLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BizLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BizLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别公路汽车客票的发票代码、发票号码、日期、姓名、票价等字段。
        /// </summary>
        /// <param name="req"><see cref="BusInvoiceOCRRequest"/></param>
        /// <returns><see cref="BusInvoiceOCRResponse"/></returns>
        public async Task<BusInvoiceOCRResponse> BusInvoiceOCR(BusInvoiceOCRRequest req)
        {
             JsonResponseModel<BusInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BusInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BusInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别公路汽车客票的发票代码、发票号码、日期、姓名、票价等字段。
        /// </summary>
        /// <param name="req"><see cref="BusInvoiceOCRRequest"/></param>
        /// <returns><see cref="BusInvoiceOCRResponse"/></returns>
        public BusInvoiceOCRResponse BusInvoiceOCRSync(BusInvoiceOCRRequest req)
        {
             JsonResponseModel<BusInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BusInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BusInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持名片各字段的自动定位与识别，包含姓名、电话、手机号、邮箱、公司、部门、职位、网址、地址、QQ、微信、MSN等。
        /// </summary>
        /// <param name="req"><see cref="BusinessCardOCRRequest"/></param>
        /// <returns><see cref="BusinessCardOCRResponse"/></returns>
        public async Task<BusinessCardOCRResponse> BusinessCardOCR(BusinessCardOCRRequest req)
        {
             JsonResponseModel<BusinessCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BusinessCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BusinessCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持名片各字段的自动定位与识别，包含姓名、电话、手机号、邮箱、公司、部门、职位、网址、地址、QQ、微信、MSN等。
        /// </summary>
        /// <param name="req"><see cref="BusinessCardOCRRequest"/></param>
        /// <returns><see cref="BusinessCardOCRResponse"/></returns>
        public BusinessCardOCRResponse BusinessCardOCRSync(BusinessCardOCRRequest req)
        {
             JsonResponseModel<BusinessCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BusinessCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BusinessCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持机动车销售统一发票和二手车销售统一发票的识别，包括发票号码、发票代码、合计金额、合计税额等二十多个字段。
        /// </summary>
        /// <param name="req"><see cref="CarInvoiceOCRRequest"/></param>
        /// <returns><see cref="CarInvoiceOCRResponse"/></returns>
        public async Task<CarInvoiceOCRResponse> CarInvoiceOCR(CarInvoiceOCRRequest req)
        {
             JsonResponseModel<CarInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CarInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CarInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持机动车销售统一发票和二手车销售统一发票的识别，包括发票号码、发票代码、合计金额、合计税额等二十多个字段。
        /// </summary>
        /// <param name="req"><see cref="CarInvoiceOCRRequest"/></param>
        /// <returns><see cref="CarInvoiceOCRResponse"/></returns>
        public CarInvoiceOCRResponse CarInvoiceOCRSync(CarInvoiceOCRRequest req)
        {
             JsonResponseModel<CarInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CarInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CarInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持身份证、护照、名片、银行卡、行驶证、驾驶证、港澳台通行证、户口本、港澳台来往内地通行证、港澳台居住证、不动产证、营业执照的智能分类。
        /// </summary>
        /// <param name="req"><see cref="ClassifyDetectOCRRequest"/></param>
        /// <returns><see cref="ClassifyDetectOCRResponse"/></returns>
        public async Task<ClassifyDetectOCRResponse> ClassifyDetectOCR(ClassifyDetectOCRRequest req)
        {
             JsonResponseModel<ClassifyDetectOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClassifyDetectOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClassifyDetectOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持身份证、护照、名片、银行卡、行驶证、驾驶证、港澳台通行证、户口本、港澳台来往内地通行证、港澳台居住证、不动产证、营业执照的智能分类。
        /// </summary>
        /// <param name="req"><see cref="ClassifyDetectOCRRequest"/></param>
        /// <returns><see cref="ClassifyDetectOCRResponse"/></returns>
        public ClassifyDetectOCRResponse ClassifyDetectOCRSync(ClassifyDetectOCRRequest req)
        {
             JsonResponseModel<ClassifyDetectOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClassifyDetectOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClassifyDetectOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持驾驶证主页和副页所有字段的自动定位与识别，重点字段的识别准确度达到99%以上。
        /// 
        /// 驾驶证主页：包括证号、姓名、性别、国籍、住址、出生日期、初次领证日期、准驾车型、有效期限、发证单位
        /// 
        /// 驾驶证副页：包括证号、姓名、档案编号、记录。
        /// 
        /// 另外，本接口还支持复印件、翻拍和PS告警功能。
        /// </summary>
        /// <param name="req"><see cref="DriverLicenseOCRRequest"/></param>
        /// <returns><see cref="DriverLicenseOCRResponse"/></returns>
        public async Task<DriverLicenseOCRResponse> DriverLicenseOCR(DriverLicenseOCRRequest req)
        {
             JsonResponseModel<DriverLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DriverLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DriverLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持驾驶证主页和副页所有字段的自动定位与识别，重点字段的识别准确度达到99%以上。
        /// 
        /// 驾驶证主页：包括证号、姓名、性别、国籍、住址、出生日期、初次领证日期、准驾车型、有效期限、发证单位
        /// 
        /// 驾驶证副页：包括证号、姓名、档案编号、记录。
        /// 
        /// 另外，本接口还支持复印件、翻拍和PS告警功能。
        /// </summary>
        /// <param name="req"><see cref="DriverLicenseOCRRequest"/></param>
        /// <returns><see cref="DriverLicenseOCRResponse"/></returns>
        public DriverLicenseOCRResponse DriverLicenseOCRSync(DriverLicenseOCRRequest req)
        {
             JsonResponseModel<DriverLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DriverLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DriverLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对完税证明的税号、纳税人识别号、纳税人名称、金额合计大写、金额合计小写、填发日期、税务机关、填票人等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="DutyPaidProofOCRRequest"/></param>
        /// <returns><see cref="DutyPaidProofOCRResponse"/></returns>
        public async Task<DutyPaidProofOCRResponse> DutyPaidProofOCR(DutyPaidProofOCRRequest req)
        {
             JsonResponseModel<DutyPaidProofOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DutyPaidProofOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DutyPaidProofOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对完税证明的税号、纳税人识别号、纳税人名称、金额合计大写、金额合计小写、填发日期、税务机关、填票人等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="DutyPaidProofOCRRequest"/></param>
        /// <returns><see cref="DutyPaidProofOCRResponse"/></returns>
        public DutyPaidProofOCRResponse DutyPaidProofOCRSync(DutyPaidProofOCRRequest req)
        {
             JsonResponseModel<DutyPaidProofOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DutyPaidProofOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DutyPaidProofOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持数学试题内容的识别和结构化输出，包括通用文本解析和小学/初中/高中数学公式解析能力（包括91种题型，180种符号），公式返回格式为 Latex 格式文本。
        /// </summary>
        /// <param name="req"><see cref="EduPaperOCRRequest"/></param>
        /// <returns><see cref="EduPaperOCRResponse"/></returns>
        public async Task<EduPaperOCRResponse> EduPaperOCR(EduPaperOCRRequest req)
        {
             JsonResponseModel<EduPaperOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EduPaperOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EduPaperOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持数学试题内容的识别和结构化输出，包括通用文本解析和小学/初中/高中数学公式解析能力（包括91种题型，180种符号），公式返回格式为 Latex 格式文本。
        /// </summary>
        /// <param name="req"><see cref="EduPaperOCRRequest"/></param>
        /// <returns><see cref="EduPaperOCRResponse"/></returns>
        public EduPaperOCRResponse EduPaperOCRSync(EduPaperOCRRequest req)
        {
             JsonResponseModel<EduPaperOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EduPaperOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EduPaperOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像英文文字的检测和识别，返回文字框位置与文字内容。支持多场景、任意版面下的英文、字母、数字和常见字符的识别，同时覆盖英文印刷体和英文手写体识别。
        /// </summary>
        /// <param name="req"><see cref="EnglishOCRRequest"/></param>
        /// <returns><see cref="EnglishOCRResponse"/></returns>
        public async Task<EnglishOCRResponse> EnglishOCR(EnglishOCRRequest req)
        {
             JsonResponseModel<EnglishOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnglishOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnglishOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像英文文字的检测和识别，返回文字框位置与文字内容。支持多场景、任意版面下的英文、字母、数字和常见字符的识别，同时覆盖英文印刷体和英文手写体识别。
        /// </summary>
        /// <param name="req"><see cref="EnglishOCRRequest"/></param>
        /// <returns><see cref="EnglishOCRResponse"/></returns>
        public EnglishOCRResponse EnglishOCRSync(EnglishOCRRequest req)
        {
             JsonResponseModel<EnglishOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnglishOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnglishOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持智能化识别各类企业登记证书、许可证书、企业执照、三证合一类证书，结构化输出统一社会信用代码、公司名称、法定代表人、公司地址、注册资金、企业类型、经营范围等关键字段。
        /// </summary>
        /// <param name="req"><see cref="EnterpriseLicenseOCRRequest"/></param>
        /// <returns><see cref="EnterpriseLicenseOCRResponse"/></returns>
        public async Task<EnterpriseLicenseOCRResponse> EnterpriseLicenseOCR(EnterpriseLicenseOCRRequest req)
        {
             JsonResponseModel<EnterpriseLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnterpriseLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnterpriseLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持智能化识别各类企业登记证书、许可证书、企业执照、三证合一类证书，结构化输出统一社会信用代码、公司名称、法定代表人、公司地址、注册资金、企业类型、经营范围等关键字段。
        /// </summary>
        /// <param name="req"><see cref="EnterpriseLicenseOCRRequest"/></param>
        /// <returns><see cref="EnterpriseLicenseOCRResponse"/></returns>
        public EnterpriseLicenseOCRResponse EnterpriseLicenseOCRSync(EnterpriseLicenseOCRRequest req)
        {
             JsonResponseModel<EnterpriseLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnterpriseLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnterpriseLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持不动产权证关键字段的识别，包括使用期限、面积、用途、权利性质、权利类型、坐落、共有情况、权利人、权利其他状况等。
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="EstateCertOCRRequest"/></param>
        /// <returns><see cref="EstateCertOCRResponse"/></returns>
        public async Task<EstateCertOCRResponse> EstateCertOCR(EstateCertOCRRequest req)
        {
             JsonResponseModel<EstateCertOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EstateCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstateCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持不动产权证关键字段的识别，包括使用期限、面积、用途、权利性质、权利类型、坐落、共有情况、权利人、权利其他状况等。
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="EstateCertOCRRequest"/></param>
        /// <returns><see cref="EstateCertOCRResponse"/></returns>
        public EstateCertOCRResponse EstateCertOCRSync(EstateCertOCRRequest req)
        {
             JsonResponseModel<EstateCertOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EstateCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstateCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持常见银行票据的自动分类和识别。整单识别包括支票（含现金支票、普通支票、转账支票），承兑汇票（含银行承兑汇票、商业承兑汇票）以及进账单等，适用于中国人民银行印发的 2010 版银行票据凭证版式（银发[2010]299 号）。
        /// </summary>
        /// <param name="req"><see cref="FinanBillOCRRequest"/></param>
        /// <returns><see cref="FinanBillOCRResponse"/></returns>
        public async Task<FinanBillOCRResponse> FinanBillOCR(FinanBillOCRRequest req)
        {
             JsonResponseModel<FinanBillOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FinanBillOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FinanBillOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持常见银行票据的自动分类和识别。整单识别包括支票（含现金支票、普通支票、转账支票），承兑汇票（含银行承兑汇票、商业承兑汇票）以及进账单等，适用于中国人民银行印发的 2010 版银行票据凭证版式（银发[2010]299 号）。
        /// </summary>
        /// <param name="req"><see cref="FinanBillOCRRequest"/></param>
        /// <returns><see cref="FinanBillOCRResponse"/></returns>
        public FinanBillOCRResponse FinanBillOCRSync(FinanBillOCRRequest req)
        {
             JsonResponseModel<FinanBillOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FinanBillOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FinanBillOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持常见银行票据的自动分类和识别。切片识别包括金融行业常见票据的重要切片字段识别，包括金额、账号、日期、凭证号码等。（金融票据切片：金融票据中待识别字段及其周围局部区域的裁剪图像。）
        /// </summary>
        /// <param name="req"><see cref="FinanBillSliceOCRRequest"/></param>
        /// <returns><see cref="FinanBillSliceOCRResponse"/></returns>
        public async Task<FinanBillSliceOCRResponse> FinanBillSliceOCR(FinanBillSliceOCRRequest req)
        {
             JsonResponseModel<FinanBillSliceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FinanBillSliceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FinanBillSliceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持常见银行票据的自动分类和识别。切片识别包括金融行业常见票据的重要切片字段识别，包括金额、账号、日期、凭证号码等。（金融票据切片：金融票据中待识别字段及其周围局部区域的裁剪图像。）
        /// </summary>
        /// <param name="req"><see cref="FinanBillSliceOCRRequest"/></param>
        /// <returns><see cref="FinanBillSliceOCRResponse"/></returns>
        public FinanBillSliceOCRResponse FinanBillSliceOCRSync(FinanBillSliceOCRRequest req)
        {
             JsonResponseModel<FinanBillSliceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FinanBillSliceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FinanBillSliceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持机票行程单关键字段的识别，包括旅客姓名、有效身份证件号码、电子客票号码、验证码、填开单位、其他税费、燃油附加费、民航发展基金、保险费、销售单位代号、始发地、目的地、航班号、时间、日期、座位等级、承运人、发票消费类型、票价、合计金额、填开日期、国内国际标签、印刷序号、客票级别/类别、客票生效日期、有效期截止日期、免费行李等字段，支持航班信息多行明细输出。
        /// </summary>
        /// <param name="req"><see cref="FlightInvoiceOCRRequest"/></param>
        /// <returns><see cref="FlightInvoiceOCRResponse"/></returns>
        public async Task<FlightInvoiceOCRResponse> FlightInvoiceOCR(FlightInvoiceOCRRequest req)
        {
             JsonResponseModel<FlightInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FlightInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlightInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持机票行程单关键字段的识别，包括旅客姓名、有效身份证件号码、电子客票号码、验证码、填开单位、其他税费、燃油附加费、民航发展基金、保险费、销售单位代号、始发地、目的地、航班号、时间、日期、座位等级、承运人、发票消费类型、票价、合计金额、填开日期、国内国际标签、印刷序号、客票级别/类别、客票生效日期、有效期截止日期、免费行李等字段，支持航班信息多行明细输出。
        /// </summary>
        /// <param name="req"><see cref="FlightInvoiceOCRRequest"/></param>
        /// <returns><see cref="FlightInvoiceOCRResponse"/></returns>
        public FlightInvoiceOCRResponse FlightInvoiceOCRSync(FlightInvoiceOCRRequest req)
        {
             JsonResponseModel<FlightInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FlightInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlightInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别主流初高中数学符号和公式，返回公式的 Latex 格式文本。
        /// </summary>
        /// <param name="req"><see cref="FormulaOCRRequest"/></param>
        /// <returns><see cref="FormulaOCRResponse"/></returns>
        public async Task<FormulaOCRResponse> FormulaOCR(FormulaOCRRequest req)
        {
             JsonResponseModel<FormulaOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FormulaOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FormulaOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别主流初高中数学符号和公式，返回公式的 Latex 格式文本。
        /// </summary>
        /// <param name="req"><see cref="FormulaOCRRequest"/></param>
        /// <returns><see cref="FormulaOCRResponse"/></returns>
        public FormulaOCRResponse FormulaOCRSync(FormulaOCRRequest req)
        {
             JsonResponseModel<FormulaOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FormulaOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FormulaOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像整体文字的检测和识别。支持中文、英文、中英文、数字和特殊字符号的识别，并返回文字框位置和文字内容。
        /// 
        /// 适用于文字较多、版式复杂、对识别准召率要求较高的场景，如试卷试题、网络图片、街景店招牌、法律卷宗等场景。
        /// 
        /// 产品优势：与通用印刷体识别相比，提供更高精度的文字识别服务，在文字较多、长串数字、小字、模糊字、倾斜文本等困难场景下，高精度版的准确率和召回率更高。
        /// 
        /// 通用印刷体识别不同版本的差异如下：
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th >【荐】通用印刷体识别（高精度版）</th>
        ///           <th style="width:200px"><a href="https://cloud.tencent.com/document/product/866/33526">【荐】通用印刷体识别</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/37831">通用印刷体识别（精简版）</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> 适用场景</td>
        ///           <td>适用于文字较多、长串数字、小字、模糊字、倾斜文本等困难场景</td>
        ///           <td>适用于所有通用场景的印刷体识别</td>
        ///           <td>适用于快速文本识别场景，准召率有一定损失，价格更优惠</td>
        ///         </tr>
        ///         <tr>
        ///           <td>识别准确率</td>
        ///           <td>99%</td>
        ///           <td>96%</td>
        ///           <td>91%</td>
        ///         </tr>
        ///         <tr>
        ///           <td>价格</td>
        ///           <td>高</td>
        ///           <td>中</td>
        ///           <td>低</td>
        ///         </tr>
        ///         <tr>
        ///           <td>支持的语言</td>
        ///           <td>中文、英文、中英文</td>
        ///           <td>中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语</td>  
        ///           <td>中文、英文、中英文</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动语言检测</td>
        ///           <td>支持</td>
        ///           <td>支持</td>  
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>返回文本行坐标</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动旋转纠正</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralAccurateOCRRequest"/></param>
        /// <returns><see cref="GeneralAccurateOCRResponse"/></returns>
        public async Task<GeneralAccurateOCRResponse> GeneralAccurateOCR(GeneralAccurateOCRRequest req)
        {
             JsonResponseModel<GeneralAccurateOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralAccurateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralAccurateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像整体文字的检测和识别。支持中文、英文、中英文、数字和特殊字符号的识别，并返回文字框位置和文字内容。
        /// 
        /// 适用于文字较多、版式复杂、对识别准召率要求较高的场景，如试卷试题、网络图片、街景店招牌、法律卷宗等场景。
        /// 
        /// 产品优势：与通用印刷体识别相比，提供更高精度的文字识别服务，在文字较多、长串数字、小字、模糊字、倾斜文本等困难场景下，高精度版的准确率和召回率更高。
        /// 
        /// 通用印刷体识别不同版本的差异如下：
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th >【荐】通用印刷体识别（高精度版）</th>
        ///           <th style="width:200px"><a href="https://cloud.tencent.com/document/product/866/33526">【荐】通用印刷体识别</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/37831">通用印刷体识别（精简版）</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> 适用场景</td>
        ///           <td>适用于文字较多、长串数字、小字、模糊字、倾斜文本等困难场景</td>
        ///           <td>适用于所有通用场景的印刷体识别</td>
        ///           <td>适用于快速文本识别场景，准召率有一定损失，价格更优惠</td>
        ///         </tr>
        ///         <tr>
        ///           <td>识别准确率</td>
        ///           <td>99%</td>
        ///           <td>96%</td>
        ///           <td>91%</td>
        ///         </tr>
        ///         <tr>
        ///           <td>价格</td>
        ///           <td>高</td>
        ///           <td>中</td>
        ///           <td>低</td>
        ///         </tr>
        ///         <tr>
        ///           <td>支持的语言</td>
        ///           <td>中文、英文、中英文</td>
        ///           <td>中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语</td>  
        ///           <td>中文、英文、中英文</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动语言检测</td>
        ///           <td>支持</td>
        ///           <td>支持</td>  
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>返回文本行坐标</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动旋转纠正</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralAccurateOCRRequest"/></param>
        /// <returns><see cref="GeneralAccurateOCRResponse"/></returns>
        public GeneralAccurateOCRResponse GeneralAccurateOCRSync(GeneralAccurateOCRRequest req)
        {
             JsonResponseModel<GeneralAccurateOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GeneralAccurateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralAccurateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像整体文字的检测和识别。可以识别中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语，阿拉伯语20种语言，且各种语言均支持与英文混合的文字识别。
        /// 
        /// 适用于印刷文档识别、网络图片识别、广告图文字识别、街景店招牌识别、菜单识别、视频标题识别、头像文字识别等场景。
        /// 
        /// 产品优势：支持自动识别语言类型，可返回文本框坐标信息，对于倾斜文本支持自动旋转纠正。
        /// 
        /// 通用印刷体识别不同版本的差异如下：
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th style="width:200px">【荐】通用印刷体识别</th>
        ///           <th ><a href="https://cloud.tencent.com/document/product/866/34937">【荐】通用印刷体识别（高精度版）</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/37831">通用印刷体识别（精简版）</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> 适用场景</td>
        ///           <td>适用于所有通用场景的印刷体识别</td>
        ///           <td>适用于文字较多、长串数字、小字、模糊字、倾斜文本等困难场景</td>
        ///           <td>适用于快速文本识别场景，准召率有一定损失，价格更优惠</td>
        ///         </tr>
        ///         <tr>
        ///           <td>识别准确率</td>
        ///           <td>96%</td>
        ///           <td>99%</td>
        ///           <td>91%</td>
        ///         </tr>
        ///         <tr>
        ///           <td>价格</td>
        ///           <td>中</td>
        ///           <td>高</td>
        ///           <td>低</td>
        ///         </tr>
        ///         <tr>
        ///           <td>支持的语言</td>
        ///           <td>中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语</td>
        ///           <td>中文、英文、中英文</td>
        ///           <td>中文、英文、中英文</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动语言检测</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>返回文本行坐标</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动旋转纠正</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralBasicOCRRequest"/></param>
        /// <returns><see cref="GeneralBasicOCRResponse"/></returns>
        public async Task<GeneralBasicOCRResponse> GeneralBasicOCR(GeneralBasicOCRRequest req)
        {
             JsonResponseModel<GeneralBasicOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralBasicOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralBasicOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像整体文字的检测和识别。可以识别中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语，阿拉伯语20种语言，且各种语言均支持与英文混合的文字识别。
        /// 
        /// 适用于印刷文档识别、网络图片识别、广告图文字识别、街景店招牌识别、菜单识别、视频标题识别、头像文字识别等场景。
        /// 
        /// 产品优势：支持自动识别语言类型，可返回文本框坐标信息，对于倾斜文本支持自动旋转纠正。
        /// 
        /// 通用印刷体识别不同版本的差异如下：
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th style="width:200px">【荐】通用印刷体识别</th>
        ///           <th ><a href="https://cloud.tencent.com/document/product/866/34937">【荐】通用印刷体识别（高精度版）</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/37831">通用印刷体识别（精简版）</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> 适用场景</td>
        ///           <td>适用于所有通用场景的印刷体识别</td>
        ///           <td>适用于文字较多、长串数字、小字、模糊字、倾斜文本等困难场景</td>
        ///           <td>适用于快速文本识别场景，准召率有一定损失，价格更优惠</td>
        ///         </tr>
        ///         <tr>
        ///           <td>识别准确率</td>
        ///           <td>96%</td>
        ///           <td>99%</td>
        ///           <td>91%</td>
        ///         </tr>
        ///         <tr>
        ///           <td>价格</td>
        ///           <td>中</td>
        ///           <td>高</td>
        ///           <td>低</td>
        ///         </tr>
        ///         <tr>
        ///           <td>支持的语言</td>
        ///           <td>中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语</td>
        ///           <td>中文、英文、中英文</td>
        ///           <td>中文、英文、中英文</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动语言检测</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>返回文本行坐标</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///         </tr>
        ///         <tr>
        ///           <td>自动旋转纠正</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralBasicOCRRequest"/></param>
        /// <returns><see cref="GeneralBasicOCRResponse"/></returns>
        public GeneralBasicOCRResponse GeneralBasicOCRSync(GeneralBasicOCRRequest req)
        {
             JsonResponseModel<GeneralBasicOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GeneralBasicOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralBasicOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像整体文字的检测和识别。支持中文、英文、中英文、数字和特殊字符号的识别，并返回文字框位置和文字内容。
        /// 
        /// 适用于快速文本识别场景。
        /// 
        /// 产品优势：与通用印刷体识别接口相比，精简版虽然在准确率和召回率上有一定损失，但价格更加优惠。
        /// 
        /// 通用印刷体识别不同版本的差异如下：
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th >通用印刷体识别（精简版）</th>
        ///           <th style="width:200px"><a href="https://cloud.tencent.com/document/product/866/33526">【荐】通用印刷体识别</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/34937">【荐】通用印刷体识别（高精度版）</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> 适用场景</td>
        ///           <td>适用于快速文本识别场景，准召率有一定损失，价格更优惠</td>
        ///           <td>适用于所有通用场景的印刷体识别</td>
        ///           <td>适用于文字较多、长串数字、小字、模糊字、倾斜文本等困难场景</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>识别准确率</td>
        ///           <td>91%</td>
        ///           <td>96%</td>
        ///           <td>99%</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>价格</td>
        ///           <td>低</td>
        ///           <td>中</td>
        ///           <td>高</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>支持的语言</td>
        ///           <td>中文、英文、中英文</td>
        ///           <td>中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语</td>  
        ///           <td>中文、英文、中英文</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>自动语言检测</td>
        ///           <td>支持</td>
        ///           <td>支持</td>  
        ///           <td>支持</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>返回文本行坐标</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>自动旋转纠正</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           
        ///          
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralEfficientOCRRequest"/></param>
        /// <returns><see cref="GeneralEfficientOCRResponse"/></returns>
        public async Task<GeneralEfficientOCRResponse> GeneralEfficientOCR(GeneralEfficientOCRRequest req)
        {
             JsonResponseModel<GeneralEfficientOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralEfficientOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralEfficientOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像整体文字的检测和识别。支持中文、英文、中英文、数字和特殊字符号的识别，并返回文字框位置和文字内容。
        /// 
        /// 适用于快速文本识别场景。
        /// 
        /// 产品优势：与通用印刷体识别接口相比，精简版虽然在准确率和召回率上有一定损失，但价格更加优惠。
        /// 
        /// 通用印刷体识别不同版本的差异如下：
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th >通用印刷体识别（精简版）</th>
        ///           <th style="width:200px"><a href="https://cloud.tencent.com/document/product/866/33526">【荐】通用印刷体识别</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/34937">【荐】通用印刷体识别（高精度版）</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> 适用场景</td>
        ///           <td>适用于快速文本识别场景，准召率有一定损失，价格更优惠</td>
        ///           <td>适用于所有通用场景的印刷体识别</td>
        ///           <td>适用于文字较多、长串数字、小字、模糊字、倾斜文本等困难场景</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>识别准确率</td>
        ///           <td>91%</td>
        ///           <td>96%</td>
        ///           <td>99%</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>价格</td>
        ///           <td>低</td>
        ///           <td>中</td>
        ///           <td>高</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>支持的语言</td>
        ///           <td>中文、英文、中英文</td>
        ///           <td>中文、英文、中英文、日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语</td>  
        ///           <td>中文、英文、中英文</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>自动语言检测</td>
        ///           <td>支持</td>
        ///           <td>支持</td>  
        ///           <td>支持</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>返回文本行坐标</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           <td>支持</td>
        ///           
        ///           
        ///         </tr>
        ///         <tr>
        ///           <td>自动旋转纠正</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           <td>支持旋转识别，返回角度信息</td>
        ///           
        ///          
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralEfficientOCRRequest"/></param>
        /// <returns><see cref="GeneralEfficientOCRResponse"/></returns>
        public GeneralEfficientOCRResponse GeneralEfficientOCRSync(GeneralEfficientOCRRequest req)
        {
             JsonResponseModel<GeneralEfficientOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GeneralEfficientOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralEfficientOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片中整体文字的检测和识别，返回文字框位置与文字内容。相比通用印刷体识别接口，识别速度更快、支持的 QPS 更高。
        /// </summary>
        /// <param name="req"><see cref="GeneralFastOCRRequest"/></param>
        /// <returns><see cref="GeneralFastOCRResponse"/></returns>
        public async Task<GeneralFastOCRResponse> GeneralFastOCR(GeneralFastOCRRequest req)
        {
             JsonResponseModel<GeneralFastOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralFastOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralFastOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片中整体文字的检测和识别，返回文字框位置与文字内容。相比通用印刷体识别接口，识别速度更快、支持的 QPS 更高。
        /// </summary>
        /// <param name="req"><see cref="GeneralFastOCRRequest"/></param>
        /// <returns><see cref="GeneralFastOCRResponse"/></returns>
        public GeneralFastOCRResponse GeneralFastOCRSync(GeneralFastOCRRequest req)
        {
             JsonResponseModel<GeneralFastOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GeneralFastOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralFastOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片内手写体文字的检测和识别，针对手写字体无规则、字迹潦草、模糊等特点进行了识别能力的增强。
        /// </summary>
        /// <param name="req"><see cref="GeneralHandwritingOCRRequest"/></param>
        /// <returns><see cref="GeneralHandwritingOCRResponse"/></returns>
        public async Task<GeneralHandwritingOCRResponse> GeneralHandwritingOCR(GeneralHandwritingOCRRequest req)
        {
             JsonResponseModel<GeneralHandwritingOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralHandwritingOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralHandwritingOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片内手写体文字的检测和识别，针对手写字体无规则、字迹潦草、模糊等特点进行了识别能力的增强。
        /// </summary>
        /// <param name="req"><see cref="GeneralHandwritingOCRRequest"/></param>
        /// <returns><see cref="GeneralHandwritingOCRResponse"/></returns>
        public GeneralHandwritingOCRResponse GeneralHandwritingOCRSync(GeneralHandwritingOCRRequest req)
        {
             JsonResponseModel<GeneralHandwritingOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GeneralHandwritingOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralHandwritingOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国香港身份证人像面中关键字段的识别，包括中文姓名、英文姓名、姓名电码、出生日期、性别、证件符号、首次签发日期、最近领用日期、身份证号、是否是永久性居民身份证；具备防伪识别、人像照片裁剪等扩展功能。
        /// 本接口暂未完全对外开放，如需咨询，请[联系商务](https://cloud.tencent.com/about/connect)
        /// </summary>
        /// <param name="req"><see cref="HKIDCardOCRRequest"/></param>
        /// <returns><see cref="HKIDCardOCRResponse"/></returns>
        public async Task<HKIDCardOCRResponse> HKIDCardOCR(HKIDCardOCRRequest req)
        {
             JsonResponseModel<HKIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HKIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HKIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国香港身份证人像面中关键字段的识别，包括中文姓名、英文姓名、姓名电码、出生日期、性别、证件符号、首次签发日期、最近领用日期、身份证号、是否是永久性居民身份证；具备防伪识别、人像照片裁剪等扩展功能。
        /// 本接口暂未完全对外开放，如需咨询，请[联系商务](https://cloud.tencent.com/about/connect)
        /// </summary>
        /// <param name="req"><see cref="HKIDCardOCRRequest"/></param>
        /// <returns><see cref="HKIDCardOCRResponse"/></returns>
        public HKIDCardOCRResponse HKIDCardOCRSync(HKIDCardOCRRequest req)
        {
             JsonResponseModel<HKIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HKIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HKIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 港澳台居住证OCR支持港澳台居住证正反面全字段内容检测识别功能，包括姓名、性别、出生日期、地址、身份证ID、签发机关、有效期限、签发次数、通行证号码关键字段识别。可以应用于港澳台居住证信息有效性校验场景，例如银行开户、用户注册等场景。
        /// </summary>
        /// <param name="req"><see cref="HmtResidentPermitOCRRequest"/></param>
        /// <returns><see cref="HmtResidentPermitOCRResponse"/></returns>
        public async Task<HmtResidentPermitOCRResponse> HmtResidentPermitOCR(HmtResidentPermitOCRRequest req)
        {
             JsonResponseModel<HmtResidentPermitOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HmtResidentPermitOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HmtResidentPermitOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 港澳台居住证OCR支持港澳台居住证正反面全字段内容检测识别功能，包括姓名、性别、出生日期、地址、身份证ID、签发机关、有效期限、签发次数、通行证号码关键字段识别。可以应用于港澳台居住证信息有效性校验场景，例如银行开户、用户注册等场景。
        /// </summary>
        /// <param name="req"><see cref="HmtResidentPermitOCRRequest"/></param>
        /// <returns><see cref="HmtResidentPermitOCRResponse"/></returns>
        public HmtResidentPermitOCRResponse HmtResidentPermitOCRSync(HmtResidentPermitOCRRequest req)
        {
             JsonResponseModel<HmtResidentPermitOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HmtResidentPermitOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HmtResidentPermitOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国大陆居民二代身份证正反面所有字段的识别，包括姓名、性别、民族、出生日期、住址、公民身份证号、签发机关、有效期限，识别准确度达到99%以上。
        /// 
        /// 另外，本接口还支持多种增值能力，满足不同场景的需求。如身份证照片、人像照片的裁剪功能，同时具备9种告警功能，如下表所示。
        /// 
        /// <table style="width:650px">
        ///       <thead>
        ///         <tr>
        ///        <th width="150">增值能力</th>
        ///           <th width="500">能力项</th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td rowspan="2">裁剪功能</td>
        ///           <td>身份证照片裁剪（去掉证件外多余的边缘、自动矫正拍摄角度）</td>
        ///         </tr>
        ///         <tr>
        ///           <td>人像照片裁剪（自动抠取身份证头像区域）</td>
        ///         </tr>
        ///         <tr>
        ///           <td rowspan="9">告警功能</td>
        ///           <td>身份证有效日期不合法告警</td>
        ///         </tr>
        ///         <tr>
        ///           <td>身份证边框不完整告警</td>
        ///         </tr>
        ///         <tr>
        ///           <td>身份证复印件告警</td>
        ///         </tr>
        ///         <tr>
        ///           <td>身份证翻拍告警</td>
        ///         </tr>
        ///           <tr>
        ///           <td>身份证框内遮挡告警</td>
        ///         </tr>
        ///          <tr>
        ///           <td>临时身份证告警</td>
        ///         </tr>
        ///           <tr>
        ///           <td>身份证 PS 告警</td>
        ///         </tr>
        ///           <tr>
        ///           <td>图片模糊告警（可根据图片质量分数判断）</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="IDCardOCRRequest"/></param>
        /// <returns><see cref="IDCardOCRResponse"/></returns>
        public async Task<IDCardOCRResponse> IDCardOCR(IDCardOCRRequest req)
        {
             JsonResponseModel<IDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国大陆居民二代身份证正反面所有字段的识别，包括姓名、性别、民族、出生日期、住址、公民身份证号、签发机关、有效期限，识别准确度达到99%以上。
        /// 
        /// 另外，本接口还支持多种增值能力，满足不同场景的需求。如身份证照片、人像照片的裁剪功能，同时具备9种告警功能，如下表所示。
        /// 
        /// <table style="width:650px">
        ///       <thead>
        ///         <tr>
        ///        <th width="150">增值能力</th>
        ///           <th width="500">能力项</th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td rowspan="2">裁剪功能</td>
        ///           <td>身份证照片裁剪（去掉证件外多余的边缘、自动矫正拍摄角度）</td>
        ///         </tr>
        ///         <tr>
        ///           <td>人像照片裁剪（自动抠取身份证头像区域）</td>
        ///         </tr>
        ///         <tr>
        ///           <td rowspan="9">告警功能</td>
        ///           <td>身份证有效日期不合法告警</td>
        ///         </tr>
        ///         <tr>
        ///           <td>身份证边框不完整告警</td>
        ///         </tr>
        ///         <tr>
        ///           <td>身份证复印件告警</td>
        ///         </tr>
        ///         <tr>
        ///           <td>身份证翻拍告警</td>
        ///         </tr>
        ///           <tr>
        ///           <td>身份证框内遮挡告警</td>
        ///         </tr>
        ///          <tr>
        ///           <td>临时身份证告警</td>
        ///         </tr>
        ///           <tr>
        ///           <td>身份证 PS 告警</td>
        ///         </tr>
        ///           <tr>
        ///           <td>图片模糊告警（可根据图片质量分数判断）</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="IDCardOCRRequest"/></param>
        /// <returns><see cref="IDCardOCRResponse"/></returns>
        public IDCardOCRResponse IDCardOCRSync(IDCardOCRRequest req)
        {
             JsonResponseModel<IDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持事业单位法人证书关键字段识别，包括注册号、有效期、住所、名称、法定代表人等。
        /// </summary>
        /// <param name="req"><see cref="InstitutionOCRRequest"/></param>
        /// <returns><see cref="InstitutionOCRResponse"/></returns>
        public async Task<InstitutionOCRResponse> InstitutionOCR(InstitutionOCRRequest req)
        {
             JsonResponseModel<InstitutionOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InstitutionOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstitutionOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持事业单位法人证书关键字段识别，包括注册号、有效期、住所、名称、法定代表人等。
        /// </summary>
        /// <param name="req"><see cref="InstitutionOCRRequest"/></param>
        /// <returns><see cref="InstitutionOCRResponse"/></returns>
        public InstitutionOCRResponse InstitutionOCRSync(InstitutionOCRRequest req)
        {
             JsonResponseModel<InstitutionOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InstitutionOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstitutionOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持病案首页、费用清单、结算单、医疗发票四种保险理赔单据的文本识别和结构化输出。
        /// </summary>
        /// <param name="req"><see cref="InsuranceBillOCRRequest"/></param>
        /// <returns><see cref="InsuranceBillOCRResponse"/></returns>
        public async Task<InsuranceBillOCRResponse> InsuranceBillOCR(InsuranceBillOCRRequest req)
        {
             JsonResponseModel<InsuranceBillOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InsuranceBillOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InsuranceBillOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持病案首页、费用清单、结算单、医疗发票四种保险理赔单据的文本识别和结构化输出。
        /// </summary>
        /// <param name="req"><see cref="InsuranceBillOCRRequest"/></param>
        /// <returns><see cref="InsuranceBillOCRResponse"/></returns>
        public InsuranceBillOCRResponse InsuranceBillOCRSync(InsuranceBillOCRRequest req)
        {
             JsonResponseModel<InsuranceBillOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InsuranceBillOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InsuranceBillOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对通用机打发票的发票代码、发票号码、日期、购买方识别号、销售方识别号、校验码、小写金额等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="InvoiceGeneralOCRRequest"/></param>
        /// <returns><see cref="InvoiceGeneralOCRResponse"/></returns>
        public async Task<InvoiceGeneralOCRResponse> InvoiceGeneralOCR(InvoiceGeneralOCRRequest req)
        {
             JsonResponseModel<InvoiceGeneralOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InvoiceGeneralOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvoiceGeneralOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对通用机打发票的发票代码、发票号码、日期、购买方识别号、销售方识别号、校验码、小写金额等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="InvoiceGeneralOCRRequest"/></param>
        /// <returns><see cref="InvoiceGeneralOCRResponse"/></returns>
        public InvoiceGeneralOCRResponse InvoiceGeneralOCRSync(InvoiceGeneralOCRRequest req)
        {
             JsonResponseModel<InvoiceGeneralOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InvoiceGeneralOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvoiceGeneralOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对中国大陆机动车车牌的自动定位和识别，返回地域编号和车牌号信息。
        /// </summary>
        /// <param name="req"><see cref="LicensePlateOCRRequest"/></param>
        /// <returns><see cref="LicensePlateOCRResponse"/></returns>
        public async Task<LicensePlateOCRResponse> LicensePlateOCR(LicensePlateOCRRequest req)
        {
             JsonResponseModel<LicensePlateOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LicensePlateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LicensePlateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对中国大陆机动车车牌的自动定位和识别，返回地域编号和车牌号信息。
        /// </summary>
        /// <param name="req"><see cref="LicensePlateOCRRequest"/></param>
        /// <returns><see cref="LicensePlateOCRResponse"/></returns>
        public LicensePlateOCRResponse LicensePlateOCRSync(LicensePlateOCRRequest req)
        {
             JsonResponseModel<LicensePlateOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LicensePlateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LicensePlateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持马来西亚身份证识别，识别字段包括身份证号、姓名、性别、地址；具备身份证人像照片的裁剪功能和翻拍、复印件告警功能。
        /// 本接口暂未完全对外开放，如需咨询，请[联系商务](https://cloud.tencent.com/about/connect)
        /// </summary>
        /// <param name="req"><see cref="MLIDCardOCRRequest"/></param>
        /// <returns><see cref="MLIDCardOCRResponse"/></returns>
        public async Task<MLIDCardOCRResponse> MLIDCardOCR(MLIDCardOCRRequest req)
        {
             JsonResponseModel<MLIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MLIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持马来西亚身份证识别，识别字段包括身份证号、姓名、性别、地址；具备身份证人像照片的裁剪功能和翻拍、复印件告警功能。
        /// 本接口暂未完全对外开放，如需咨询，请[联系商务](https://cloud.tencent.com/about/connect)
        /// </summary>
        /// <param name="req"><see cref="MLIDCardOCRRequest"/></param>
        /// <returns><see cref="MLIDCardOCRResponse"/></returns>
        public MLIDCardOCRResponse MLIDCardOCRSync(MLIDCardOCRRequest req)
        {
             JsonResponseModel<MLIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MLIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国港澳台地区以及其他国家、地区的护照识别。识别字段包括护照ID、姓名、出生日期、性别、有效期、发行国、国籍，具备护照人像照片的裁剪功能和翻拍、复印件告警功能。
        /// </summary>
        /// <param name="req"><see cref="MLIDPassportOCRRequest"/></param>
        /// <returns><see cref="MLIDPassportOCRResponse"/></returns>
        public async Task<MLIDPassportOCRResponse> MLIDPassportOCR(MLIDPassportOCRRequest req)
        {
             JsonResponseModel<MLIDPassportOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MLIDPassportOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDPassportOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国港澳台地区以及其他国家、地区的护照识别。识别字段包括护照ID、姓名、出生日期、性别、有效期、发行国、国籍，具备护照人像照片的裁剪功能和翻拍、复印件告警功能。
        /// </summary>
        /// <param name="req"><see cref="MLIDPassportOCRRequest"/></param>
        /// <returns><see cref="MLIDPassportOCRResponse"/></returns>
        public MLIDPassportOCRResponse MLIDPassportOCRSync(MLIDPassportOCRRequest req)
        {
             JsonResponseModel<MLIDPassportOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MLIDPassportOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDPassportOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能识别并结构化港澳台居民来往内地通行证正面全部字段，包含中文姓名、英文姓名、性别、出生日期、签发机关、有效期限、证件号、签发地点、签发次数、证件类别。
        /// </summary>
        /// <param name="req"><see cref="MainlandPermitOCRRequest"/></param>
        /// <returns><see cref="MainlandPermitOCRResponse"/></returns>
        public async Task<MainlandPermitOCRResponse> MainlandPermitOCR(MainlandPermitOCRRequest req)
        {
             JsonResponseModel<MainlandPermitOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MainlandPermitOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MainlandPermitOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能识别并结构化港澳台居民来往内地通行证正面全部字段，包含中文姓名、英文姓名、性别、出生日期、签发机关、有效期限、证件号、签发地点、签发次数、证件类别。
        /// </summary>
        /// <param name="req"><see cref="MainlandPermitOCRRequest"/></param>
        /// <returns><see cref="MainlandPermitOCRResponse"/></returns>
        public MainlandPermitOCRResponse MainlandPermitOCRSync(MainlandPermitOCRRequest req)
        {
             JsonResponseModel<MainlandPermitOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MainlandPermitOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MainlandPermitOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持多张、多类型票据的混合检测和自动分类，返回对应票据类型。目前已支持增值税发票、增值税发票（卷票）、定额发票、通用机打发票、购车发票、火车票、出租车发票、机票行程单、汽车票、轮船票、过路过桥费发票、酒店账单、客运限额发票、购物小票、完税证明共15种票据。
        /// </summary>
        /// <param name="req"><see cref="MixedInvoiceDetectRequest"/></param>
        /// <returns><see cref="MixedInvoiceDetectResponse"/></returns>
        public async Task<MixedInvoiceDetectResponse> MixedInvoiceDetect(MixedInvoiceDetectRequest req)
        {
             JsonResponseModel<MixedInvoiceDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MixedInvoiceDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MixedInvoiceDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持多张、多类型票据的混合检测和自动分类，返回对应票据类型。目前已支持增值税发票、增值税发票（卷票）、定额发票、通用机打发票、购车发票、火车票、出租车发票、机票行程单、汽车票、轮船票、过路过桥费发票、酒店账单、客运限额发票、购物小票、完税证明共15种票据。
        /// </summary>
        /// <param name="req"><see cref="MixedInvoiceDetectRequest"/></param>
        /// <returns><see cref="MixedInvoiceDetectResponse"/></returns>
        public MixedInvoiceDetectResponse MixedInvoiceDetectSync(MixedInvoiceDetectRequest req)
        {
             JsonResponseModel<MixedInvoiceDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MixedInvoiceDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MixedInvoiceDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持多张、多类型票据的混合识别，系统自动实现分割、分类和识别，同时支持自选需要识别的票据类型。目前已支持增值税发票、增值税发票（卷票）、定额发票、通用机打发票、购车发票、火车票、出租车发票、机票行程单、汽车票、轮船票、过路过桥费发票共11种票据。
        /// </summary>
        /// <param name="req"><see cref="MixedInvoiceOCRRequest"/></param>
        /// <returns><see cref="MixedInvoiceOCRResponse"/></returns>
        public async Task<MixedInvoiceOCRResponse> MixedInvoiceOCR(MixedInvoiceOCRRequest req)
        {
             JsonResponseModel<MixedInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MixedInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MixedInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持多张、多类型票据的混合识别，系统自动实现分割、分类和识别，同时支持自选需要识别的票据类型。目前已支持增值税发票、增值税发票（卷票）、定额发票、通用机打发票、购车发票、火车票、出租车发票、机票行程单、汽车票、轮船票、过路过桥费发票共11种票据。
        /// </summary>
        /// <param name="req"><see cref="MixedInvoiceOCRRequest"/></param>
        /// <returns><see cref="MixedInvoiceOCRResponse"/></returns>
        public MixedInvoiceOCRResponse MixedInvoiceOCRSync(MixedInvoiceOCRRequest req)
        {
             JsonResponseModel<MixedInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MixedInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MixedInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持组织机构代码证关键字段的识别，包括代码、有效期、地址、机构名称等。
        /// </summary>
        /// <param name="req"><see cref="OrgCodeCertOCRRequest"/></param>
        /// <returns><see cref="OrgCodeCertOCRResponse"/></returns>
        public async Task<OrgCodeCertOCRResponse> OrgCodeCertOCR(OrgCodeCertOCRRequest req)
        {
             JsonResponseModel<OrgCodeCertOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OrgCodeCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OrgCodeCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持组织机构代码证关键字段的识别，包括代码、有效期、地址、机构名称等。
        /// </summary>
        /// <param name="req"><see cref="OrgCodeCertOCRRequest"/></param>
        /// <returns><see cref="OrgCodeCertOCRResponse"/></returns>
        public OrgCodeCertOCRResponse OrgCodeCertOCRSync(OrgCodeCertOCRRequest req)
        {
             JsonResponseModel<OrgCodeCertOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OrgCodeCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OrgCodeCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国大陆地区护照个人资料页多个字段的检测与识别。已支持字段包括英文姓名、中文姓名、国家码、护照号、出生地、出生日期、国籍英文、性别英文、有效期、签发地点英文、签发日期、持证人签名、护照机读码（MRZ码）等。
        /// </summary>
        /// <param name="req"><see cref="PassportOCRRequest"/></param>
        /// <returns><see cref="PassportOCRResponse"/></returns>
        public async Task<PassportOCRResponse> PassportOCR(PassportOCRRequest req)
        {
             JsonResponseModel<PassportOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PassportOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PassportOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中国大陆地区护照个人资料页多个字段的检测与识别。已支持字段包括英文姓名、中文姓名、国家码、护照号、出生地、出生日期、国籍英文、性别英文、有效期、签发地点英文、签发日期、持证人签名、护照机读码（MRZ码）等。
        /// </summary>
        /// <param name="req"><see cref="PassportOCRRequest"/></param>
        /// <returns><see cref="PassportOCRResponse"/></returns>
        public PassportOCRResponse PassportOCRSync(PassportOCRRequest req)
        {
             JsonResponseModel<PassportOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PassportOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PassportOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对卡式港澳台通行证的识别，包括签发地点、签发机关、有效期限、性别、出生日期、英文姓名、姓名、证件号等字段。
        /// </summary>
        /// <param name="req"><see cref="PermitOCRRequest"/></param>
        /// <returns><see cref="PermitOCRResponse"/></returns>
        public async Task<PermitOCRResponse> PermitOCR(PermitOCRRequest req)
        {
             JsonResponseModel<PermitOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PermitOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PermitOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对卡式港澳台通行证的识别，包括签发地点、签发机关、有效期限、性别、出生日期、英文姓名、姓名、证件号等字段。
        /// </summary>
        /// <param name="req"><see cref="PermitOCRRequest"/></param>
        /// <returns><see cref="PermitOCRResponse"/></returns>
        public PermitOCRResponse PermitOCRSync(PermitOCRRequest req)
        {
             JsonResponseModel<PermitOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PermitOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PermitOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持房产证关键字段的识别，包括房地产权利人、共有情况、登记时间、规划用途、房屋性质、房屋坐落等。
        /// 目前接口对合肥、成都、佛山三个城市的房产证版式识别较好。
        /// </summary>
        /// <param name="req"><see cref="PropOwnerCertOCRRequest"/></param>
        /// <returns><see cref="PropOwnerCertOCRResponse"/></returns>
        public async Task<PropOwnerCertOCRResponse> PropOwnerCertOCR(PropOwnerCertOCRRequest req)
        {
             JsonResponseModel<PropOwnerCertOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PropOwnerCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PropOwnerCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持房产证关键字段的识别，包括房地产权利人、共有情况、登记时间、规划用途、房屋性质、房屋坐落等。
        /// 目前接口对合肥、成都、佛山三个城市的房产证版式识别较好。
        /// </summary>
        /// <param name="req"><see cref="PropOwnerCertOCRRequest"/></param>
        /// <returns><see cref="PropOwnerCertOCRResponse"/></returns>
        public PropOwnerCertOCRResponse PropOwnerCertOCRSync(PropOwnerCertOCRRequest req)
        {
             JsonResponseModel<PropOwnerCertOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PropOwnerCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PropOwnerCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持条形码和二维码的识别（包括 DataMatrix 和 PDF417）。
        /// </summary>
        /// <param name="req"><see cref="QrcodeOCRRequest"/></param>
        /// <returns><see cref="QrcodeOCRResponse"/></returns>
        public async Task<QrcodeOCRResponse> QrcodeOCR(QrcodeOCRRequest req)
        {
             JsonResponseModel<QrcodeOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QrcodeOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QrcodeOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持条形码和二维码的识别（包括 DataMatrix 和 PDF417）。
        /// </summary>
        /// <param name="req"><see cref="QrcodeOCRRequest"/></param>
        /// <returns><see cref="QrcodeOCRResponse"/></returns>
        public QrcodeOCRResponse QrcodeOCRSync(QrcodeOCRRequest req)
        {
             JsonResponseModel<QrcodeOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QrcodeOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QrcodeOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持条形码备案信息查询，返回条形码查询结果的相关信息，包括产品名称、产品英文名称、品牌名称、规格型号、宽度、高度、深度、关键字、产品描述、厂家名称、厂家地址、企业社会信用代码13个字段信息。
        /// 
        /// 产品优势：直联中国物品编码中心，查询结果更加准确、可靠。
        /// </summary>
        /// <param name="req"><see cref="QueryBarCodeRequest"/></param>
        /// <returns><see cref="QueryBarCodeResponse"/></returns>
        public async Task<QueryBarCodeResponse> QueryBarCode(QueryBarCodeRequest req)
        {
             JsonResponseModel<QueryBarCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBarCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBarCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持条形码备案信息查询，返回条形码查询结果的相关信息，包括产品名称、产品英文名称、品牌名称、规格型号、宽度、高度、深度、关键字、产品描述、厂家名称、厂家地址、企业社会信用代码13个字段信息。
        /// 
        /// 产品优势：直联中国物品编码中心，查询结果更加准确、可靠。
        /// </summary>
        /// <param name="req"><see cref="QueryBarCodeRequest"/></param>
        /// <returns><see cref="QueryBarCodeResponse"/></returns>
        public QueryBarCodeResponse QueryBarCodeSync(QueryBarCodeRequest req)
        {
             JsonResponseModel<QueryBarCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBarCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBarCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持定额发票的发票号码、发票代码、金额(大小写)、发票消费类型、地区及是否有公司印章等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="QuotaInvoiceOCRRequest"/></param>
        /// <returns><see cref="QuotaInvoiceOCRResponse"/></returns>
        public async Task<QuotaInvoiceOCRResponse> QuotaInvoiceOCR(QuotaInvoiceOCRRequest req)
        {
             JsonResponseModel<QuotaInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QuotaInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuotaInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持定额发票的发票号码、发票代码、金额(大小写)、发票消费类型、地区及是否有公司印章等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="QuotaInvoiceOCRRequest"/></param>
        /// <returns><see cref="QuotaInvoiceOCRResponse"/></returns>
        public QuotaInvoiceOCRResponse QuotaInvoiceOCRSync(QuotaInvoiceOCRRequest req)
        {
             JsonResponseModel<QuotaInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QuotaInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuotaInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中英文图片/ PDF内常规表格、无线表格、多表格的检测和识别，支持日文有线表格识别，返回每个单元格的文字内容，支持旋转的表格图片识别，且支持将识别结果保存为 Excel 格式。
        /// </summary>
        /// <param name="req"><see cref="RecognizeTableOCRRequest"/></param>
        /// <returns><see cref="RecognizeTableOCRResponse"/></returns>
        public async Task<RecognizeTableOCRResponse> RecognizeTableOCR(RecognizeTableOCRRequest req)
        {
             JsonResponseModel<RecognizeTableOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeTableOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeTableOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持中英文图片/ PDF内常规表格、无线表格、多表格的检测和识别，支持日文有线表格识别，返回每个单元格的文字内容，支持旋转的表格图片识别，且支持将识别结果保存为 Excel 格式。
        /// </summary>
        /// <param name="req"><see cref="RecognizeTableOCRRequest"/></param>
        /// <returns><see cref="RecognizeTableOCRResponse"/></returns>
        public RecognizeTableOCRResponse RecognizeTableOCRSync(RecognizeTableOCRRequest req)
        {
             JsonResponseModel<RecognizeTableOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeTableOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeTableOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持泰国身份证识别，识别字段包括泰文姓名、英文姓名、地址、出生日期、身份证号码。
        /// 本接口暂未完全对外开放，如需咨询，请[联系商务](https://cloud.tencent.com/about/connect)
        /// </summary>
        /// <param name="req"><see cref="RecognizeThaiIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeThaiIDCardOCRResponse"/></returns>
        public async Task<RecognizeThaiIDCardOCRResponse> RecognizeThaiIDCardOCR(RecognizeThaiIDCardOCRRequest req)
        {
             JsonResponseModel<RecognizeThaiIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeThaiIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeThaiIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持泰国身份证识别，识别字段包括泰文姓名、英文姓名、地址、出生日期、身份证号码。
        /// 本接口暂未完全对外开放，如需咨询，请[联系商务](https://cloud.tencent.com/about/connect)
        /// </summary>
        /// <param name="req"><see cref="RecognizeThaiIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeThaiIDCardOCRResponse"/></returns>
        public RecognizeThaiIDCardOCRResponse RecognizeThaiIDCardOCRSync(RecognizeThaiIDCardOCRRequest req)
        {
             JsonResponseModel<RecognizeThaiIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeThaiIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeThaiIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持居民户口簿户主页及成员页关键字段的识别，包括姓名、户别、地址、籍贯、身份证号码等。
        /// </summary>
        /// <param name="req"><see cref="ResidenceBookletOCRRequest"/></param>
        /// <returns><see cref="ResidenceBookletOCRResponse"/></returns>
        public async Task<ResidenceBookletOCRResponse> ResidenceBookletOCR(ResidenceBookletOCRRequest req)
        {
             JsonResponseModel<ResidenceBookletOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResidenceBookletOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResidenceBookletOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持居民户口簿户主页及成员页关键字段的识别，包括姓名、户别、地址、籍贯、身份证号码等。
        /// </summary>
        /// <param name="req"><see cref="ResidenceBookletOCRRequest"/></param>
        /// <returns><see cref="ResidenceBookletOCRResponse"/></returns>
        public ResidenceBookletOCRResponse ResidenceBookletOCRSync(ResidenceBookletOCRRequest req)
        {
             JsonResponseModel<ResidenceBookletOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResidenceBookletOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResidenceBookletOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持网约车驾驶证关键字段的识别，包括姓名、证号、起始日期、截止日期、发证日期。
        /// </summary>
        /// <param name="req"><see cref="RideHailingDriverLicenseOCRRequest"/></param>
        /// <returns><see cref="RideHailingDriverLicenseOCRResponse"/></returns>
        public async Task<RideHailingDriverLicenseOCRResponse> RideHailingDriverLicenseOCR(RideHailingDriverLicenseOCRRequest req)
        {
             JsonResponseModel<RideHailingDriverLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RideHailingDriverLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RideHailingDriverLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持网约车驾驶证关键字段的识别，包括姓名、证号、起始日期、截止日期、发证日期。
        /// </summary>
        /// <param name="req"><see cref="RideHailingDriverLicenseOCRRequest"/></param>
        /// <returns><see cref="RideHailingDriverLicenseOCRResponse"/></returns>
        public RideHailingDriverLicenseOCRResponse RideHailingDriverLicenseOCRSync(RideHailingDriverLicenseOCRRequest req)
        {
             JsonResponseModel<RideHailingDriverLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RideHailingDriverLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RideHailingDriverLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持网约车运输证关键字段的识别，包括交运管许可字号、车辆所有人、车辆号牌、起始日期、截止日期、发证日期。
        ///            
        /// </summary>
        /// <param name="req"><see cref="RideHailingTransportLicenseOCRRequest"/></param>
        /// <returns><see cref="RideHailingTransportLicenseOCRResponse"/></returns>
        public async Task<RideHailingTransportLicenseOCRResponse> RideHailingTransportLicenseOCR(RideHailingTransportLicenseOCRRequest req)
        {
             JsonResponseModel<RideHailingTransportLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RideHailingTransportLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RideHailingTransportLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持网约车运输证关键字段的识别，包括交运管许可字号、车辆所有人、车辆号牌、起始日期、截止日期、发证日期。
        ///            
        /// </summary>
        /// <param name="req"><see cref="RideHailingTransportLicenseOCRRequest"/></param>
        /// <returns><see cref="RideHailingTransportLicenseOCRResponse"/></returns>
        public RideHailingTransportLicenseOCRResponse RideHailingTransportLicenseOCRSync(RideHailingTransportLicenseOCRRequest req)
        {
             JsonResponseModel<RideHailingTransportLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RideHailingTransportLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RideHailingTransportLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 印章识别已支持各类印章，包括发票章，财务章等，适用于公文，票据等场景。
        /// </summary>
        /// <param name="req"><see cref="SealOCRRequest"/></param>
        /// <returns><see cref="SealOCRResponse"/></returns>
        public async Task<SealOCRResponse> SealOCR(SealOCRRequest req)
        {
             JsonResponseModel<SealOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SealOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SealOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 印章识别已支持各类印章，包括发票章，财务章等，适用于公文，票据等场景。
        /// </summary>
        /// <param name="req"><see cref="SealOCRRequest"/></param>
        /// <returns><see cref="SealOCRResponse"/></returns>
        public SealOCRResponse SealOCRSync(SealOCRRequest req)
        {
             JsonResponseModel<SealOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SealOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SealOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别轮船票的发票代码、发票号码、日期、姓名、票价、始发地、目的地、姓名、时间、发票消费类型、省、市、币种字段。
        /// </summary>
        /// <param name="req"><see cref="ShipInvoiceOCRRequest"/></param>
        /// <returns><see cref="ShipInvoiceOCRResponse"/></returns>
        public async Task<ShipInvoiceOCRResponse> ShipInvoiceOCR(ShipInvoiceOCRRequest req)
        {
             JsonResponseModel<ShipInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ShipInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShipInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别轮船票的发票代码、发票号码、日期、姓名、票价、始发地、目的地、姓名、时间、发票消费类型、省、市、币种字段。
        /// </summary>
        /// <param name="req"><see cref="ShipInvoiceOCRRequest"/></param>
        /// <returns><see cref="ShipInvoiceOCRResponse"/></returns>
        public ShipInvoiceOCRResponse ShipInvoiceOCRSync(ShipInvoiceOCRRequest req)
        {
             JsonResponseModel<ShipInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ShipInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShipInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别并提取各类证照、票据、表单、合同等结构化场景的字段信息。无需任何配置，灵活高效。适用于各类结构化信息录入场景。
        /// </summary>
        /// <param name="req"><see cref="SmartStructuralOCRRequest"/></param>
        /// <returns><see cref="SmartStructuralOCRResponse"/></returns>
        public async Task<SmartStructuralOCRResponse> SmartStructuralOCR(SmartStructuralOCRRequest req)
        {
             JsonResponseModel<SmartStructuralOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SmartStructuralOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SmartStructuralOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持识别并提取各类证照、票据、表单、合同等结构化场景的字段信息。无需任何配置，灵活高效。适用于各类结构化信息录入场景。
        /// </summary>
        /// <param name="req"><see cref="SmartStructuralOCRRequest"/></param>
        /// <returns><see cref="SmartStructuralOCRResponse"/></returns>
        public SmartStructuralOCRResponse SmartStructuralOCRSync(SmartStructuralOCRRequest req)
        {
             JsonResponseModel<SmartStructuralOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SmartStructuralOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SmartStructuralOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <b>此接口为表格识别的旧版本服务，不再进行服务升级，建议您使用识别能力更强、服务性能更优的<a href="https://cloud.tencent.com/document/product/866/49525">新版表格识别</a>。</b>
        /// 
        /// 本接口支持图片内表格文档的检测和识别，返回每个单元格的文字内容，支持将识别结果保存为 Excel 格式。
        /// 
        /// </summary>
        /// <param name="req"><see cref="TableOCRRequest"/></param>
        /// <returns><see cref="TableOCRResponse"/></returns>
        public async Task<TableOCRResponse> TableOCR(TableOCRRequest req)
        {
             JsonResponseModel<TableOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TableOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TableOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <b>此接口为表格识别的旧版本服务，不再进行服务升级，建议您使用识别能力更强、服务性能更优的<a href="https://cloud.tencent.com/document/product/866/49525">新版表格识别</a>。</b>
        /// 
        /// 本接口支持图片内表格文档的检测和识别，返回每个单元格的文字内容，支持将识别结果保存为 Excel 格式。
        /// 
        /// </summary>
        /// <param name="req"><see cref="TableOCRRequest"/></param>
        /// <returns><see cref="TableOCRResponse"/></returns>
        public TableOCRResponse TableOCRSync(TableOCRRequest req)
        {
             JsonResponseModel<TableOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TableOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TableOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持出租车发票关键字段的识别，包括发票号码、发票代码、金额、日期、上下车时间、里程、车牌号、发票类型及所属地区等字段。
        /// </summary>
        /// <param name="req"><see cref="TaxiInvoiceOCRRequest"/></param>
        /// <returns><see cref="TaxiInvoiceOCRResponse"/></returns>
        public async Task<TaxiInvoiceOCRResponse> TaxiInvoiceOCR(TaxiInvoiceOCRRequest req)
        {
             JsonResponseModel<TaxiInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TaxiInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TaxiInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持出租车发票关键字段的识别，包括发票号码、发票代码、金额、日期、上下车时间、里程、车牌号、发票类型及所属地区等字段。
        /// </summary>
        /// <param name="req"><see cref="TaxiInvoiceOCRRequest"/></param>
        /// <returns><see cref="TaxiInvoiceOCRResponse"/></returns>
        public TaxiInvoiceOCRResponse TaxiInvoiceOCRSync(TaxiInvoiceOCRRequest req)
        {
             JsonResponseModel<TaxiInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TaxiInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TaxiInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口通过检测图片中的文字信息特征，快速判断图片中有无文字并返回判断结果，帮助用户过滤无文字的图片。
        /// </summary>
        /// <param name="req"><see cref="TextDetectRequest"/></param>
        /// <returns><see cref="TextDetectResponse"/></returns>
        public async Task<TextDetectResponse> TextDetect(TextDetectRequest req)
        {
             JsonResponseModel<TextDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口通过检测图片中的文字信息特征，快速判断图片中有无文字并返回判断结果，帮助用户过滤无文字的图片。
        /// </summary>
        /// <param name="req"><see cref="TextDetectRequest"/></param>
        /// <returns><see cref="TextDetectResponse"/></returns>
        public TextDetectResponse TextDetectSync(TextDetectRequest req)
        {
             JsonResponseModel<TextDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对过路过桥费发票的发票代码、发票号码、日期、小写金额等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="TollInvoiceOCRRequest"/></param>
        /// <returns><see cref="TollInvoiceOCRResponse"/></returns>
        public async Task<TollInvoiceOCRResponse> TollInvoiceOCR(TollInvoiceOCRRequest req)
        {
             JsonResponseModel<TollInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TollInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TollInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对过路过桥费发票的发票代码、发票号码、日期、小写金额等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="TollInvoiceOCRRequest"/></param>
        /// <returns><see cref="TollInvoiceOCRResponse"/></returns>
        public TollInvoiceOCRResponse TollInvoiceOCRSync(TollInvoiceOCRRequest req)
        {
             JsonResponseModel<TollInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TollInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TollInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持火车票全字段的识别，包括编号、票价、姓名、座位号、出发时间、出发站、到达站、车次、席别、发票类型及序列号等。
        /// </summary>
        /// <param name="req"><see cref="TrainTicketOCRRequest"/></param>
        /// <returns><see cref="TrainTicketOCRResponse"/></returns>
        public async Task<TrainTicketOCRResponse> TrainTicketOCR(TrainTicketOCRRequest req)
        {
             JsonResponseModel<TrainTicketOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TrainTicketOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrainTicketOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持火车票全字段的识别，包括编号、票价、姓名、座位号、出发时间、出发站、到达站、车次、席别、发票类型及序列号等。
        /// </summary>
        /// <param name="req"><see cref="TrainTicketOCRRequest"/></param>
        /// <returns><see cref="TrainTicketOCRResponse"/></returns>
        public TrainTicketOCRResponse TrainTicketOCRSync(TrainTicketOCRRequest req)
        {
             JsonResponseModel<TrainTicketOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TrainTicketOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrainTicketOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持增值税专用发票、增值税普通发票、增值税电子发票全字段的内容检测和识别，包括发票代码、发票号码、打印发票代码、打印发票号码、开票日期、合计金额、校验码、税率、合计税额、价税合计、购买方识别号、复核、销售方识别号、开票人、密码区1、密码区2、密码区3、密码区4、发票名称、购买方名称、销售方名称、服务名称、备注、规格型号、数量、单价、金额、税额、收款人等字段。
        /// </summary>
        /// <param name="req"><see cref="VatInvoiceOCRRequest"/></param>
        /// <returns><see cref="VatInvoiceOCRResponse"/></returns>
        public async Task<VatInvoiceOCRResponse> VatInvoiceOCR(VatInvoiceOCRRequest req)
        {
             JsonResponseModel<VatInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VatInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VatInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持增值税专用发票、增值税普通发票、增值税电子发票全字段的内容检测和识别，包括发票代码、发票号码、打印发票代码、打印发票号码、开票日期、合计金额、校验码、税率、合计税额、价税合计、购买方识别号、复核、销售方识别号、开票人、密码区1、密码区2、密码区3、密码区4、发票名称、购买方名称、销售方名称、服务名称、备注、规格型号、数量、单价、金额、税额、收款人等字段。
        /// </summary>
        /// <param name="req"><see cref="VatInvoiceOCRRequest"/></param>
        /// <returns><see cref="VatInvoiceOCRResponse"/></returns>
        public VatInvoiceOCRResponse VatInvoiceOCRSync(VatInvoiceOCRRequest req)
        {
             JsonResponseModel<VatInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VatInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VatInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持增值税发票的准确性核验，您可以通过输入增值税发票的关键字段提供所需的验证信息，接口返回真实的票面相关信息，包括发票代码、发票号码、开票日期、金额、消费类型、购方名称、购方税号、销方名称、销方税号等多个常用字段。支持多种发票类型核验，包括增值税专用发票、增值税普通发票（含电子普通发票、卷式发票、通行费发票）、机动车销售统一发票、货物运输业增值税专用发票、二手车销售统一发票。
        /// </summary>
        /// <param name="req"><see cref="VatInvoiceVerifyRequest"/></param>
        /// <returns><see cref="VatInvoiceVerifyResponse"/></returns>
        public async Task<VatInvoiceVerifyResponse> VatInvoiceVerify(VatInvoiceVerifyRequest req)
        {
             JsonResponseModel<VatInvoiceVerifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VatInvoiceVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VatInvoiceVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持增值税发票的准确性核验，您可以通过输入增值税发票的关键字段提供所需的验证信息，接口返回真实的票面相关信息，包括发票代码、发票号码、开票日期、金额、消费类型、购方名称、购方税号、销方名称、销方税号等多个常用字段。支持多种发票类型核验，包括增值税专用发票、增值税普通发票（含电子普通发票、卷式发票、通行费发票）、机动车销售统一发票、货物运输业增值税专用发票、二手车销售统一发票。
        /// </summary>
        /// <param name="req"><see cref="VatInvoiceVerifyRequest"/></param>
        /// <returns><see cref="VatInvoiceVerifyResponse"/></returns>
        public VatInvoiceVerifyResponse VatInvoiceVerifySync(VatInvoiceVerifyRequest req)
        {
             JsonResponseModel<VatInvoiceVerifyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VatInvoiceVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VatInvoiceVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对增值税发票（卷票）的发票代码、发票号码、日期、校验码、合计金额（小写）等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="VatRollInvoiceOCRRequest"/></param>
        /// <returns><see cref="VatRollInvoiceOCRResponse"/></returns>
        public async Task<VatRollInvoiceOCRResponse> VatRollInvoiceOCR(VatRollInvoiceOCRRequest req)
        {
             JsonResponseModel<VatRollInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VatRollInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VatRollInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对增值税发票（卷票）的发票代码、发票号码、日期、校验码、合计金额（小写）等关键字段的识别。
        /// </summary>
        /// <param name="req"><see cref="VatRollInvoiceOCRRequest"/></param>
        /// <returns><see cref="VatRollInvoiceOCRResponse"/></returns>
        public VatRollInvoiceOCRResponse VatRollInvoiceOCRSync(VatRollInvoiceOCRRequest req)
        {
             JsonResponseModel<VatRollInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VatRollInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VatRollInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持行驶证主页和副页所有字段的自动定位与识别。
        /// 
        /// 行驶证主页：车牌号码、车辆类型、所有人、住址、使用性质、品牌型号、识别代码、发动机号、注册日期、发证日期、发证单位。
        /// 
        /// 行驶证副页：号牌号码、档案编号、核定载人数、总质量、整备质量、核定载质量、外廓尺寸、准牵引总质量、备注、检验记录。
        /// 
        /// 另外，本接口还支持复印件、翻拍和PS告警功能。
        /// </summary>
        /// <param name="req"><see cref="VehicleLicenseOCRRequest"/></param>
        /// <returns><see cref="VehicleLicenseOCRResponse"/></returns>
        public async Task<VehicleLicenseOCRResponse> VehicleLicenseOCR(VehicleLicenseOCRRequest req)
        {
             JsonResponseModel<VehicleLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VehicleLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VehicleLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持行驶证主页和副页所有字段的自动定位与识别。
        /// 
        /// 行驶证主页：车牌号码、车辆类型、所有人、住址、使用性质、品牌型号、识别代码、发动机号、注册日期、发证日期、发证单位。
        /// 
        /// 行驶证副页：号牌号码、档案编号、核定载人数、总质量、整备质量、核定载质量、外廓尺寸、准牵引总质量、备注、检验记录。
        /// 
        /// 另外，本接口还支持复印件、翻拍和PS告警功能。
        /// </summary>
        /// <param name="req"><see cref="VehicleLicenseOCRRequest"/></param>
        /// <returns><see cref="VehicleLicenseOCRResponse"/></returns>
        public VehicleLicenseOCRResponse VehicleLicenseOCRSync(VehicleLicenseOCRRequest req)
        {
             JsonResponseModel<VehicleLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VehicleLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VehicleLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持国内机动车登记证书主要字段的结构化识别，包括机动车所有人、身份证明名称、号码、车辆型号、车辆识别代号、发动机号、制造厂名称等。
        /// </summary>
        /// <param name="req"><see cref="VehicleRegCertOCRRequest"/></param>
        /// <returns><see cref="VehicleRegCertOCRResponse"/></returns>
        public async Task<VehicleRegCertOCRResponse> VehicleRegCertOCR(VehicleRegCertOCRRequest req)
        {
             JsonResponseModel<VehicleRegCertOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VehicleRegCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VehicleRegCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持国内机动车登记证书主要字段的结构化识别，包括机动车所有人、身份证明名称、号码、车辆型号、车辆识别代号、发动机号、制造厂名称等。
        /// </summary>
        /// <param name="req"><see cref="VehicleRegCertOCRRequest"/></param>
        /// <returns><see cref="VehicleRegCertOCRResponse"/></returns>
        public VehicleRegCertOCRResponse VehicleRegCertOCRSync(VehicleRegCertOCRRequest req)
        {
             JsonResponseModel<VehicleRegCertOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VehicleRegCertOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VehicleRegCertOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持营业执照信息的识别与准确性核验。
        /// 
        /// 您可以通过输入营业执照注册号或营业执照图片（若两者都输入则只用注册号做查询）进行核验，接口返回查询到的工商照面信息，并比对要校验的字段与查询结果的一致性。查询到工商信息包括：统一社会信用代码、经营期限、法人姓名、经营状态、经营业务范围、注册资本等。
        /// </summary>
        /// <param name="req"><see cref="VerifyBasicBizLicenseRequest"/></param>
        /// <returns><see cref="VerifyBasicBizLicenseResponse"/></returns>
        public async Task<VerifyBasicBizLicenseResponse> VerifyBasicBizLicense(VerifyBasicBizLicenseRequest req)
        {
             JsonResponseModel<VerifyBasicBizLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyBasicBizLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyBasicBizLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持营业执照信息的识别与准确性核验。
        /// 
        /// 您可以通过输入营业执照注册号或营业执照图片（若两者都输入则只用注册号做查询）进行核验，接口返回查询到的工商照面信息，并比对要校验的字段与查询结果的一致性。查询到工商信息包括：统一社会信用代码、经营期限、法人姓名、经营状态、经营业务范围、注册资本等。
        /// </summary>
        /// <param name="req"><see cref="VerifyBasicBizLicenseRequest"/></param>
        /// <returns><see cref="VerifyBasicBizLicenseResponse"/></returns>
        public VerifyBasicBizLicenseResponse VerifyBasicBizLicenseSync(VerifyBasicBizLicenseRequest req)
        {
             JsonResponseModel<VerifyBasicBizLicenseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyBasicBizLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyBasicBizLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持营业执照信息的识别与准确性核验，返回的真实工商照面信息比营业执照识别及核验（基础版）接口更详细。
        /// 
        /// 您可以输入营业执照注册号或营业执照图片（若两者都输入则只用注册号做查询），接口返回查询到的工商照面信息，并比对要校验的字段与查询结果的一致性。
        /// 
        /// 查询到工商信息包括：统一社会信用代码、组织机构代码、经营期限、法人姓名、经营状态、经营业务范围及方式、注册资金、注册币种、登记机关、开业日期、企业（机构）类型、注销日期、吊销日期、许可经营项目、一般经营项目、核准时间、省、地级市、区/县、住所所在行政区划代码、行业门类代码、行业门类名称、国民经济行业代码、国民经济行业名称、经营（业务）范围等。
        /// </summary>
        /// <param name="req"><see cref="VerifyBizLicenseRequest"/></param>
        /// <returns><see cref="VerifyBizLicenseResponse"/></returns>
        public async Task<VerifyBizLicenseResponse> VerifyBizLicense(VerifyBizLicenseRequest req)
        {
             JsonResponseModel<VerifyBizLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyBizLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyBizLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持营业执照信息的识别与准确性核验，返回的真实工商照面信息比营业执照识别及核验（基础版）接口更详细。
        /// 
        /// 您可以输入营业执照注册号或营业执照图片（若两者都输入则只用注册号做查询），接口返回查询到的工商照面信息，并比对要校验的字段与查询结果的一致性。
        /// 
        /// 查询到工商信息包括：统一社会信用代码、组织机构代码、经营期限、法人姓名、经营状态、经营业务范围及方式、注册资金、注册币种、登记机关、开业日期、企业（机构）类型、注销日期、吊销日期、许可经营项目、一般经营项目、核准时间、省、地级市、区/县、住所所在行政区划代码、行业门类代码、行业门类名称、国民经济行业代码、国民经济行业名称、经营（业务）范围等。
        /// </summary>
        /// <param name="req"><see cref="VerifyBizLicenseRequest"/></param>
        /// <returns><see cref="VerifyBizLicenseResponse"/></returns>
        public VerifyBizLicenseResponse VerifyBizLicenseSync(VerifyBizLicenseRequest req)
        {
             JsonResponseModel<VerifyBizLicenseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyBizLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyBizLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口基于企业四要素授权“姓名、证件号码、企业标识、企业全称”，验证企业信息是否一致。
        /// </summary>
        /// <param name="req"><see cref="VerifyEnterpriseFourFactorsRequest"/></param>
        /// <returns><see cref="VerifyEnterpriseFourFactorsResponse"/></returns>
        public async Task<VerifyEnterpriseFourFactorsResponse> VerifyEnterpriseFourFactors(VerifyEnterpriseFourFactorsRequest req)
        {
             JsonResponseModel<VerifyEnterpriseFourFactorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyEnterpriseFourFactors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyEnterpriseFourFactorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口基于企业四要素授权“姓名、证件号码、企业标识、企业全称”，验证企业信息是否一致。
        /// </summary>
        /// <param name="req"><see cref="VerifyEnterpriseFourFactorsRequest"/></param>
        /// <returns><see cref="VerifyEnterpriseFourFactorsResponse"/></returns>
        public VerifyEnterpriseFourFactorsResponse VerifyEnterpriseFourFactorsSync(VerifyEnterpriseFourFactorsRequest req)
        {
             JsonResponseModel<VerifyEnterpriseFourFactorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyEnterpriseFourFactors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyEnterpriseFourFactorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持OFD格式的增值税电子普通发票和增值税电子专用发票的识别，返回发票代码、发票号码、开票日期、验证码、机器编号、密码区，购买方和销售方信息，包括名称、纳税人识别号、地址电话、开户行及账号，以及价税合计、开票人、收款人、复核人、税额、不含税金额等字段信息。
        /// </summary>
        /// <param name="req"><see cref="VerifyOfdVatInvoiceOCRRequest"/></param>
        /// <returns><see cref="VerifyOfdVatInvoiceOCRResponse"/></returns>
        public async Task<VerifyOfdVatInvoiceOCRResponse> VerifyOfdVatInvoiceOCR(VerifyOfdVatInvoiceOCRRequest req)
        {
             JsonResponseModel<VerifyOfdVatInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyOfdVatInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyOfdVatInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持OFD格式的增值税电子普通发票和增值税电子专用发票的识别，返回发票代码、发票号码、开票日期、验证码、机器编号、密码区，购买方和销售方信息，包括名称、纳税人识别号、地址电话、开户行及账号，以及价税合计、开票人、收款人、复核人、税额、不含税金额等字段信息。
        /// </summary>
        /// <param name="req"><see cref="VerifyOfdVatInvoiceOCRRequest"/></param>
        /// <returns><see cref="VerifyOfdVatInvoiceOCRResponse"/></returns>
        public VerifyOfdVatInvoiceOCRResponse VerifyOfdVatInvoiceOCRSync(VerifyOfdVatInvoiceOCRRequest req)
        {
             JsonResponseModel<VerifyOfdVatInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyOfdVatInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyOfdVatInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片内车辆识别代号（VIN）的检测和识别。
        /// </summary>
        /// <param name="req"><see cref="VinOCRRequest"/></param>
        /// <returns><see cref="VinOCRResponse"/></returns>
        public async Task<VinOCRResponse> VinOCR(VinOCRRequest req)
        {
             JsonResponseModel<VinOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VinOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VinOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片内车辆识别代号（VIN）的检测和识别。
        /// </summary>
        /// <param name="req"><see cref="VinOCRRequest"/></param>
        /// <returns><see cref="VinOCRResponse"/></returns>
        public VinOCRResponse VinOCRSync(VinOCRRequest req)
        {
             JsonResponseModel<VinOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VinOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VinOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持市面上主流版式电子运单的识别，包括收件人和寄件人的姓名、电话、地址以及运单号等字段。
        /// </summary>
        /// <param name="req"><see cref="WaybillOCRRequest"/></param>
        /// <returns><see cref="WaybillOCRResponse"/></returns>
        public async Task<WaybillOCRResponse> WaybillOCR(WaybillOCRRequest req)
        {
             JsonResponseModel<WaybillOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WaybillOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WaybillOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持市面上主流版式电子运单的识别，包括收件人和寄件人的姓名、电话、地址以及运单号等字段。
        /// </summary>
        /// <param name="req"><see cref="WaybillOCRRequest"/></param>
        /// <returns><see cref="WaybillOCRResponse"/></returns>
        public WaybillOCRResponse WaybillOCRSync(WaybillOCRRequest req)
        {
             JsonResponseModel<WaybillOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "WaybillOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WaybillOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
