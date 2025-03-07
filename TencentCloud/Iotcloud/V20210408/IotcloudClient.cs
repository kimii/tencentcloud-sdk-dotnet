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

namespace TencentCloud.Iotcloud.V20210408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotcloud.V20210408.Models;

   public class IotcloudClient : AbstractClient{

       private const string endpoint = "iotcloud.tencentcloudapi.com";
       private const string version = "2021-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotcloudClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotcloudClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public async Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建私有CA证书
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public async Task<CreatePrivateCAResponse> CreatePrivateCA(CreatePrivateCARequest req)
        {
             JsonResponseModel<CreatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建私有CA证书
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public CreatePrivateCAResponse CreatePrivateCASync(CreatePrivateCARequest req)
        {
             JsonResponseModel<CreatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public async Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public async Task<DeletePrivateCAResponse> DeletePrivateCA(DeletePrivateCARequest req)
        {
             JsonResponseModel<DeletePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public DeletePrivateCAResponse DeletePrivateCASync(DeletePrivateCARequest req)
        {
             JsonResponseModel<DeletePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevice）用于查看设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public async Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevice）用于查看设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有化CA信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public async Task<DescribePrivateCAResponse> DescribePrivateCA(DescribePrivateCARequest req)
        {
             JsonResponseModel<DescribePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有化CA信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public DescribePrivateCAResponse DescribePrivateCASync(DescribePrivateCARequest req)
        {
             JsonResponseModel<DescribePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA绑定的产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public async Task<DescribePrivateCABindedProductsResponse> DescribePrivateCABindedProducts(DescribePrivateCABindedProductsRequest req)
        {
             JsonResponseModel<DescribePrivateCABindedProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateCABindedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCABindedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA绑定的产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public DescribePrivateCABindedProductsResponse DescribePrivateCABindedProductsSync(DescribePrivateCABindedProductsRequest req)
        {
             JsonResponseModel<DescribePrivateCABindedProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateCABindedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCABindedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public async Task<DescribePrivateCAsResponse> DescribePrivateCAs(DescribePrivateCAsRequest req)
        {
             JsonResponseModel<DescribePrivateCAsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateCAs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public DescribePrivateCAsResponse DescribePrivateCAsSync(DescribePrivateCAsRequest req)
        {
             JsonResponseModel<DescribePrivateCAsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateCAs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于查看产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public async Task<DescribeProductResponse> DescribeProduct(DescribeProductRequest req)
        {
             JsonResponseModel<DescribeProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于查看产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public DescribeProductResponse DescribeProductSync(DescribeProductRequest req)
        {
             JsonResponseModel<DescribeProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品绑定的CA证书
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public async Task<DescribeProductCAResponse> DescribeProductCA(DescribeProductCARequest req)
        {
             JsonResponseModel<DescribeProductCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品绑定的CA证书
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public DescribeProductCAResponse DescribeProductCASync(DescribeProductCARequest req)
        {
             JsonResponseModel<DescribeProductCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置设备上报的日志级别  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public async Task<UpdateDeviceLogLevelResponse> UpdateDeviceLogLevel(UpdateDeviceLogLevelRequest req)
        {
             JsonResponseModel<UpdateDeviceLogLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceLogLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceLogLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置设备上报的日志级别  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public UpdateDeviceLogLevelResponse UpdateDeviceLogLevelSync(UpdateDeviceLogLevelRequest req)
        {
             JsonResponseModel<UpdateDeviceLogLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceLogLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceLogLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public async Task<UpdateDevicesEnableStateResponse> UpdateDevicesEnableState(UpdateDevicesEnableStateRequest req)
        {
             JsonResponseModel<UpdateDevicesEnableStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDevicesEnableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicesEnableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public UpdateDevicesEnableStateResponse UpdateDevicesEnableStateSync(UpdateDevicesEnableStateRequest req)
        {
             JsonResponseModel<UpdateDevicesEnableStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDevicesEnableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicesEnableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新私有CA证书
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public async Task<UpdatePrivateCAResponse> UpdatePrivateCA(UpdatePrivateCARequest req)
        {
             JsonResponseModel<UpdatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新私有CA证书
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public UpdatePrivateCAResponse UpdatePrivateCASync(UpdatePrivateCARequest req)
        {
             JsonResponseModel<UpdatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
