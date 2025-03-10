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

namespace TencentCloud.Clb.V20180317
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Clb.V20180317.Models;

   public class ClbClient : AbstractClient{

       private const string endpoint = "clb.tencentcloudapi.com";
       private const string version = "2018-03-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ClbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(AssociateTargetGroups)用来将目标组绑定到负载均衡的监听器（四层协议）或转发规则（七层协议）上。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public async Task<AssociateTargetGroupsResponse> AssociateTargetGroups(AssociateTargetGroupsRequest req)
        {
             JsonResponseModel<AssociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AssociateTargetGroups)用来将目标组绑定到负载均衡的监听器（四层协议）或转发规则（七层协议）上。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public AssociateTargetGroupsResponse AssociateTargetGroupsSync(AssociateTargetGroupsRequest req)
        {
             JsonResponseModel<AssociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户需要先创建出一个HTTPS:443监听器，并在其下创建转发规则。通过调用本接口，系统会自动创建出一个HTTP:80监听器（如果之前不存在），并在其下创建转发规则，与HTTPS:443监听器下的Domains（在入参中指定）对应。创建成功后可以通过HTTP:80地址自动跳转为HTTPS:443地址进行访问。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public async Task<AutoRewriteResponse> AutoRewrite(AutoRewriteRequest req)
        {
             JsonResponseModel<AutoRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AutoRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AutoRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户需要先创建出一个HTTPS:443监听器，并在其下创建转发规则。通过调用本接口，系统会自动创建出一个HTTP:80监听器（如果之前不存在），并在其下创建转发规则，与HTTPS:443监听器下的Domains（在入参中指定）对应。创建成功后可以通过HTTP:80地址自动跳转为HTTPS:443地址进行访问。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public AutoRewriteResponse AutoRewriteSync(AutoRewriteRequest req)
        {
             JsonResponseModel<AutoRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AutoRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AutoRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑四七层后端服务。批量解绑的资源数量上限为500。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public async Task<BatchDeregisterTargetsResponse> BatchDeregisterTargets(BatchDeregisterTargetsRequest req)
        {
             JsonResponseModel<BatchDeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑四七层后端服务。批量解绑的资源数量上限为500。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public BatchDeregisterTargetsResponse BatchDeregisterTargetsSync(BatchDeregisterTargetsRequest req)
        {
             JsonResponseModel<BatchDeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BatchModifyTargetWeight 接口用于批量修改负载均衡监听器绑定的后端机器的转发权重。批量修改的资源数量上限为500。本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。<br/>负载均衡的4层和7层监听器支持此接口，传统型负载均衡不支持。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public async Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
             JsonResponseModel<BatchModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BatchModifyTargetWeight 接口用于批量修改负载均衡监听器绑定的后端机器的转发权重。批量修改的资源数量上限为500。本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。<br/>负载均衡的4层和7层监听器支持此接口，传统型负载均衡不支持。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public BatchModifyTargetWeightResponse BatchModifyTargetWeightSync(BatchModifyTargetWeightRequest req)
        {
             JsonResponseModel<BatchModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量绑定虚拟主机或弹性网卡，支持跨域绑定，支持四层、七层（TCP、UDP、HTTP、HTTPS）协议绑定。批量绑定的资源数量上限为500。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public async Task<BatchRegisterTargetsResponse> BatchRegisterTargets(BatchRegisterTargetsRequest req)
        {
             JsonResponseModel<BatchRegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchRegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量绑定虚拟主机或弹性网卡，支持跨域绑定，支持四层、七层（TCP、UDP、HTTP、HTTPS）协议绑定。批量绑定的资源数量上限为500。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public BatchRegisterTargetsResponse BatchRegisterTargetsSync(BatchRegisterTargetsRequest req)
        {
             JsonResponseModel<BatchRegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchRegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建CLB专有日志集，此日志集用于存储CLB的日志。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public async Task<CreateClsLogSetResponse> CreateClsLogSet(CreateClsLogSetRequest req)
        {
             JsonResponseModel<CreateClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建CLB专有日志集，此日志集用于存储CLB的日志。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public CreateClsLogSetResponse CreateClsLogSetSync(CreateClsLogSetRequest req)
        {
             JsonResponseModel<CreateClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在一个负载均衡实例下创建监听器。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public async Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
             JsonResponseModel<CreateListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在一个负载均衡实例下创建监听器。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
             JsonResponseModel<CreateListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateLoadBalancer)用来创建负载均衡实例（本接口只支持购买按量计费的负载均衡，包年包月的负载均衡请通过控制台购买）。为了使用负载均衡服务，您必须购买一个或多个负载均衡实例。成功调用该接口后，会返回负载均衡实例的唯一 ID。负载均衡实例的类型分为：公网、内网。详情可参考产品说明中的产品类型。
        /// 注意：(1)指定可用区申请负载均衡、跨zone容灾(仅香港支持)【如果您需要体验该功能，请通过 [工单申请](https://console.cloud.tencent.com/workorder/category)】；(2)目前只有北京、上海、广州支持IPv6；(3)一个账号在每个地域的默认购买配额为：公网100个，内网100个。
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
             JsonResponseModel<CreateLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateLoadBalancer)用来创建负载均衡实例（本接口只支持购买按量计费的负载均衡，包年包月的负载均衡请通过控制台购买）。为了使用负载均衡服务，您必须购买一个或多个负载均衡实例。成功调用该接口后，会返回负载均衡实例的唯一 ID。负载均衡实例的类型分为：公网、内网。详情可参考产品说明中的产品类型。
        /// 注意：(1)指定可用区申请负载均衡、跨zone容灾(仅香港支持)【如果您需要体验该功能，请通过 [工单申请](https://console.cloud.tencent.com/workorder/category)】；(2)目前只有北京、上海、广州支持IPv6；(3)一个账号在每个地域的默认购买配额为：公网100个，内网100个。
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
             JsonResponseModel<CreateLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对SnatPro负载均衡，这个接口用于添加SnatIp，如果负载均衡没有开启SnatPro，添加SnatIp后会自动开启。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public async Task<CreateLoadBalancerSnatIpsResponse> CreateLoadBalancerSnatIps(CreateLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<CreateLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对SnatPro负载均衡，这个接口用于添加SnatIp，如果负载均衡没有开启SnatPro，添加SnatIp后会自动开启。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public CreateLoadBalancerSnatIpsResponse CreateLoadBalancerSnatIpsSync(CreateLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<CreateLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateRule 接口用于在一个已存在的负载均衡七层监听器下创建转发规则，七层监听器中，后端服务必须绑定到规则上而非监听器上。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateRule 接口用于在一个已存在的负载均衡七层监听器下创建转发规则，七层监听器中，后端服务必须绑定到规则上而非监听器上。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建目标组。该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public async Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
             JsonResponseModel<CreateTargetGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTargetGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTargetGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建目标组。该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
             JsonResponseModel<CreateTargetGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTargetGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTargetGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建主题，默认开启全文索引和键值索引。如果不存在CLB专有日志集，则创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建主题，默认开启全文索引和键值索引。如果不存在CLB专有日志集，则创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来删除负载均衡实例下的监听器（四层和七层）。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public async Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
             JsonResponseModel<DeleteListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来删除负载均衡实例下的监听器（四层和七层）。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
             JsonResponseModel<DeleteListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLoadBalancer 接口用以删除指定的一个或多个负载均衡实例。成功删除后，会把负载均衡实例下的监听器、转发规则一起删除，并把后端服务解绑。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLoadBalancer 接口用以删除指定的一个或多个负载均衡实例。成功删除后，会把负载均衡实例下的监听器、转发规则一起删除，并把后端服务解绑。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口支持删除负载均衡的多个监听器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public async Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancerListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口支持删除负载均衡的多个监听器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancerListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 这个接口用于删除SnatPro的负载均衡的SnatIp。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public async Task<DeleteLoadBalancerSnatIpsResponse> DeleteLoadBalancerSnatIps(DeleteLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 这个接口用于删除SnatPro的负载均衡的SnatIp。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public DeleteLoadBalancerSnatIpsResponse DeleteLoadBalancerSnatIpsSync(DeleteLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteRewrite 接口支持删除指定转发规则之间的重定向关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public async Task<DeleteRewriteResponse> DeleteRewrite(DeleteRewriteRequest req)
        {
             JsonResponseModel<DeleteRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteRewrite 接口支持删除指定转发规则之间的重定向关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public DeleteRewriteResponse DeleteRewriteSync(DeleteRewriteRequest req)
        {
             JsonResponseModel<DeleteRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteRule 接口用来删除负载均衡实例七层监听器下的转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteRule 接口用来删除负载均衡实例七层监听器下的转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除目标组
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public async Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
             JsonResponseModel<DeleteTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除目标组
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
             JsonResponseModel<DeleteTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从目标组中解绑服务器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public async Task<DeregisterTargetGroupInstancesResponse> DeregisterTargetGroupInstances(DeregisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DeregisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从目标组中解绑服务器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public DeregisterTargetGroupInstancesResponse DeregisterTargetGroupInstancesSync(DeregisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DeregisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeregisterTargets 接口用来将一台或多台后端服务从负载均衡的监听器或转发规则上解绑，对于四层监听器，只需指定监听器ID即可，对于七层监听器，还需通过LocationId或Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public async Task<DeregisterTargetsResponse> DeregisterTargets(DeregisterTargetsRequest req)
        {
             JsonResponseModel<DeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeregisterTargets 接口用来将一台或多台后端服务从负载均衡的监听器或转发规则上解绑，对于四层监听器，只需指定监听器ID即可，对于七层监听器，还需通过LocationId或Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public DeregisterTargetsResponse DeregisterTargetsSync(DeregisterTargetsRequest req)
        {
             JsonResponseModel<DeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeregisterTargetsFromClassicalLB 接口用于解绑负载均衡后端服务。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public async Task<DeregisterTargetsFromClassicalLBResponse> DeregisterTargetsFromClassicalLB(DeregisterTargetsFromClassicalLBRequest req)
        {
             JsonResponseModel<DeregisterTargetsFromClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargetsFromClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsFromClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeregisterTargetsFromClassicalLB 接口用于解绑负载均衡后端服务。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public DeregisterTargetsFromClassicalLBResponse DeregisterTargetsFromClassicalLBSync(DeregisterTargetsFromClassicalLBRequest req)
        {
             JsonResponseModel<DeregisterTargetsFromClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterTargetsFromClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsFromClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一个负载均衡所封禁的IP列表（黑名单）。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public async Task<DescribeBlockIPListResponse> DescribeBlockIPList(DescribeBlockIPListRequest req)
        {
             JsonResponseModel<DescribeBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一个负载均衡所封禁的IP列表（黑名单）。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public DescribeBlockIPListResponse DescribeBlockIPListSync(DescribeBlockIPListRequest req)
        {
             JsonResponseModel<DescribeBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据 ModifyBlockIPList 接口返回的异步任务的ID，查询封禁IP（黑名单）异步任务的执行状态。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public async Task<DescribeBlockIPTaskResponse> DescribeBlockIPTask(DescribeBlockIPTaskRequest req)
        {
             JsonResponseModel<DescribeBlockIPTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockIPTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据 ModifyBlockIPList 接口返回的异步任务的ID，查询封禁IP（黑名单）异步任务的执行状态。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public DescribeBlockIPTaskResponse DescribeBlockIPTaskSync(DescribeBlockIPTaskRequest req)
        {
             JsonResponseModel<DescribeBlockIPTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockIPTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBByInstanceId用于通过后端实例ID获取传统型负载均衡ID列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public async Task<DescribeClassicalLBByInstanceIdResponse> DescribeClassicalLBByInstanceId(DescribeClassicalLBByInstanceIdRequest req)
        {
             JsonResponseModel<DescribeClassicalLBByInstanceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBByInstanceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBByInstanceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBByInstanceId用于通过后端实例ID获取传统型负载均衡ID列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public DescribeClassicalLBByInstanceIdResponse DescribeClassicalLBByInstanceIdSync(DescribeClassicalLBByInstanceIdRequest req)
        {
             JsonResponseModel<DescribeClassicalLBByInstanceIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBByInstanceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBByInstanceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBHealthStatus用于获取传统型负载均衡后端的健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public async Task<DescribeClassicalLBHealthStatusResponse> DescribeClassicalLBHealthStatus(DescribeClassicalLBHealthStatusRequest req)
        {
             JsonResponseModel<DescribeClassicalLBHealthStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBHealthStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBHealthStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBHealthStatus用于获取传统型负载均衡后端的健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public DescribeClassicalLBHealthStatusResponse DescribeClassicalLBHealthStatusSync(DescribeClassicalLBHealthStatusRequest req)
        {
             JsonResponseModel<DescribeClassicalLBHealthStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBHealthStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBHealthStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBListeners 接口用于获取传统型负载均衡的监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public async Task<DescribeClassicalLBListenersResponse> DescribeClassicalLBListeners(DescribeClassicalLBListenersRequest req)
        {
             JsonResponseModel<DescribeClassicalLBListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBListeners 接口用于获取传统型负载均衡的监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public DescribeClassicalLBListenersResponse DescribeClassicalLBListenersSync(DescribeClassicalLBListenersRequest req)
        {
             JsonResponseModel<DescribeClassicalLBListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBTargets用于获取传统型负载均衡绑定的后端服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public async Task<DescribeClassicalLBTargetsResponse> DescribeClassicalLBTargets(DescribeClassicalLBTargetsRequest req)
        {
             JsonResponseModel<DescribeClassicalLBTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBTargets用于获取传统型负载均衡绑定的后端服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public DescribeClassicalLBTargetsResponse DescribeClassicalLBTargetsSync(DescribeClassicalLBTargetsRequest req)
        {
             JsonResponseModel<DescribeClassicalLBTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户的CLB专有日志集。
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public async Task<DescribeClsLogSetResponse> DescribeClsLogSet(DescribeClsLogSetRequest req)
        {
             JsonResponseModel<DescribeClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户的CLB专有日志集。
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public DescribeClsLogSetResponse DescribeClsLogSetSync(DescribeClsLogSetRequest req)
        {
             JsonResponseModel<DescribeClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询独占集群中的资源列表，支持按集群ID、VIP、负载均衡ID、是否闲置为过滤条件检索。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterResourcesRequest"/></param>
        /// <returns><see cref="DescribeClusterResourcesResponse"/></returns>
        public async Task<DescribeClusterResourcesResponse> DescribeClusterResources(DescribeClusterResourcesRequest req)
        {
             JsonResponseModel<DescribeClusterResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询独占集群中的资源列表，支持按集群ID、VIP、负载均衡ID、是否闲置为过滤条件检索。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterResourcesRequest"/></param>
        /// <returns><see cref="DescribeClusterResourcesResponse"/></returns>
        public DescribeClusterResourcesResponse DescribeClusterResourcesSync(DescribeClusterResourcesRequest req)
        {
             JsonResponseModel<DescribeClusterResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取配置绑定的 server 或 location，如果 domain 存在，结果将根据 domain 过滤。或拉取配置绑定的 loadbalancer。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public async Task<DescribeCustomizedConfigAssociateListResponse> DescribeCustomizedConfigAssociateList(DescribeCustomizedConfigAssociateListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigAssociateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomizedConfigAssociateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigAssociateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取配置绑定的 server 或 location，如果 domain 存在，结果将根据 domain 过滤。或拉取配置绑定的 loadbalancer。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public DescribeCustomizedConfigAssociateListResponse DescribeCustomizedConfigAssociateListSync(DescribeCustomizedConfigAssociateListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigAssociateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomizedConfigAssociateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigAssociateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取个性化配置列表，返回用户 AppId 下指定类型的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public async Task<DescribeCustomizedConfigListResponse> DescribeCustomizedConfigList(DescribeCustomizedConfigListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomizedConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取个性化配置列表，返回用户 AppId 下指定类型的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public DescribeCustomizedConfigListResponse DescribeCustomizedConfigListSync(DescribeCustomizedConfigListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomizedConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群信息列表，支持以集群类型、集群唯一ID、集群名字、集群标签、集群内vip、集群内负载均衡唯一id、集群网络类型、可用区等条件进行检索
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveClustersRequest"/></param>
        /// <returns><see cref="DescribeExclusiveClustersResponse"/></returns>
        public async Task<DescribeExclusiveClustersResponse> DescribeExclusiveClusters(DescribeExclusiveClustersRequest req)
        {
             JsonResponseModel<DescribeExclusiveClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExclusiveClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExclusiveClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群信息列表，支持以集群类型、集群唯一ID、集群名字、集群标签、集群内vip、集群内负载均衡唯一id、集群网络类型、可用区等条件进行检索
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveClustersRequest"/></param>
        /// <returns><see cref="DescribeExclusiveClustersResponse"/></returns>
        public DescribeExclusiveClustersResponse DescribeExclusiveClustersSync(DescribeExclusiveClustersRequest req)
        {
             JsonResponseModel<DescribeExclusiveClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExclusiveClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExclusiveClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询后端云主机或弹性网卡绑定的负载均衡，支持弹性网卡和cvm查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public async Task<DescribeLBListenersResponse> DescribeLBListeners(DescribeLBListenersRequest req)
        {
             JsonResponseModel<DescribeLBListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询后端云主机或弹性网卡绑定的负载均衡，支持弹性网卡和cvm查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public DescribeLBListenersResponse DescribeLBListenersSync(DescribeLBListenersRequest req)
        {
             JsonResponseModel<DescribeLBListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeListeners 接口可根据负载均衡器 ID、监听器的协议或端口作为过滤条件获取监听器列表。如果不指定任何过滤条件，则返回该负载均衡实例下的所有监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public async Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
             JsonResponseModel<DescribeListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeListeners 接口可根据负载均衡器 ID、监听器的协议或端口作为过滤条件获取监听器列表。如果不指定任何过滤条件，则返回该负载均衡实例下的所有监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
             JsonResponseModel<DescribeListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据证书ID查询其在一个地域中所关联到负载均衡实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public async Task<DescribeLoadBalancerListByCertIdResponse> DescribeLoadBalancerListByCertId(DescribeLoadBalancerListByCertIdRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerListByCertIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancerListByCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerListByCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据证书ID查询其在一个地域中所关联到负载均衡实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public DescribeLoadBalancerListByCertIdResponse DescribeLoadBalancerListByCertIdSync(DescribeLoadBalancerListByCertIdRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerListByCertIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancerListByCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerListByCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账号下的高流量负载均衡，返回前10个负载均衡。如果是子账号登录，只返回子账号有权限的负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public async Task<DescribeLoadBalancerTrafficResponse> DescribeLoadBalancerTraffic(DescribeLoadBalancerTrafficRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerTrafficResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancerTraffic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerTrafficResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账号下的高流量负载均衡，返回前10个负载均衡。如果是子账号登录，只返回子账号有权限的负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public DescribeLoadBalancerTrafficResponse DescribeLoadBalancerTrafficSync(DescribeLoadBalancerTrafficRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerTrafficResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancerTraffic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerTrafficResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一个地域的负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一个地域的负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡的详细信息，包括监听器，规则及后端目标。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public async Task<DescribeLoadBalancersDetailResponse> DescribeLoadBalancersDetail(DescribeLoadBalancersDetailRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancersDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡的详细信息，包括监听器，规则及后端目标。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public DescribeLoadBalancersDetailResponse DescribeLoadBalancersDetailSync(DescribeLoadBalancersDetailRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancersDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户当前地域下的各项配额
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public async Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest req)
        {
             JsonResponseModel<DescribeQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户当前地域下的各项配额
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public DescribeQuotaResponse DescribeQuotaSync(DescribeQuotaRequest req)
        {
             JsonResponseModel<DescribeQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRewrite 接口可根据负载均衡实例ID，查询一个负载均衡实例下转发规则的重定向关系。如果不指定监听器ID或转发规则ID，则返回该负载均衡实例下的所有重定向关系。
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public async Task<DescribeRewriteResponse> DescribeRewrite(DescribeRewriteRequest req)
        {
             JsonResponseModel<DescribeRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRewrite 接口可根据负载均衡实例ID，查询一个负载均衡实例下转发规则的重定向关系。如果不指定监听器ID或转发规则ID，则返回该负载均衡实例下的所有重定向关系。
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public DescribeRewriteResponse DescribeRewriteSync(DescribeRewriteRequest req)
        {
             JsonResponseModel<DescribeRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取目标组绑定的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public async Task<DescribeTargetGroupInstancesResponse> DescribeTargetGroupInstances(DescribeTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DescribeTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取目标组绑定的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public DescribeTargetGroupInstancesResponse DescribeTargetGroupInstancesSync(DescribeTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DescribeTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public async Task<DescribeTargetGroupListResponse> DescribeTargetGroupList(DescribeTargetGroupListRequest req)
        {
             JsonResponseModel<DescribeTargetGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public DescribeTargetGroupListResponse DescribeTargetGroupListSync(DescribeTargetGroupListRequest req)
        {
             JsonResponseModel<DescribeTargetGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询目标组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public async Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
             JsonResponseModel<DescribeTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询目标组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
             JsonResponseModel<DescribeTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTargetHealth 接口用来获取负载均衡后端服务的健康检查结果，不支持传统型负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public async Task<DescribeTargetHealthResponse> DescribeTargetHealth(DescribeTargetHealthRequest req)
        {
             JsonResponseModel<DescribeTargetHealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTargetHealth 接口用来获取负载均衡后端服务的健康检查结果，不支持传统型负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public DescribeTargetHealthResponse DescribeTargetHealthSync(DescribeTargetHealthRequest req)
        {
             JsonResponseModel<DescribeTargetHealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTargets 接口用来查询负载均衡实例的某些监听器绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public async Task<DescribeTargetsResponse> DescribeTargets(DescribeTargetsRequest req)
        {
             JsonResponseModel<DescribeTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTargets 接口用来查询负载均衡实例的某些监听器绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public DescribeTargetsResponse DescribeTargetsSync(DescribeTargetsRequest req)
        {
             JsonResponseModel<DescribeTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询异步任务的执行状态，对于非查询类的接口（创建/删除负载均衡实例、监听器、规则以及绑定或解绑后端服务等），在接口调用成功后，都需要使用本接口查询任务最终是否执行成功。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public async Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询异步任务的执行状态，对于非查询类的接口（创建/删除负载均衡实例、监听器、规则以及绑定或解绑后端服务等），在接口调用成功后，都需要使用本接口查询任务最终是否执行成功。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除规则的目标组关联关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public async Task<DisassociateTargetGroupsResponse> DisassociateTargetGroups(DisassociateTargetGroupsRequest req)
        {
             JsonResponseModel<DisassociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除规则的目标组关联关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public DisassociateTargetGroupsResponse DisassociateTargetGroupsSync(DisassociateTargetGroupsRequest req)
        {
             JsonResponseModel<DisassociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户手动配置原访问地址和重定向地址，系统自动将原访问地址的请求重定向至对应路径的目的地址。同一域名下可以配置多条路径作为重定向策略，实现http/https之间请求的自动跳转。设置重定向时，需满足如下约束条件：若A已经重定向至B，则A不能再重定向至C（除非先删除老的重定向关系，再建立新的重定向关系），B不能重定向至任何其它地址。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public async Task<ManualRewriteResponse> ManualRewrite(ManualRewriteRequest req)
        {
             JsonResponseModel<ManualRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManualRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户手动配置原访问地址和重定向地址，系统自动将原访问地址的请求重定向至对应路径的目的地址。同一域名下可以配置多条路径作为重定向策略，实现http/https之间请求的自动跳转。设置重定向时，需满足如下约束条件：若A已经重定向至B，则A不能再重定向至C（除非先删除老的重定向关系，再建立新的重定向关系），B不能重定向至任何其它地址。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public ManualRewriteResponse ManualRewriteSync(ManualRewriteRequest req)
        {
             JsonResponseModel<ManualRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManualRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡的IP（client IP）封禁黑名单列表，一个转发规则最多支持封禁 2000000 个IP，及黑名单容量为 2000000。
        /// （接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public async Task<ModifyBlockIPListResponse> ModifyBlockIPList(ModifyBlockIPListRequest req)
        {
             JsonResponseModel<ModifyBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡的IP（client IP）封禁黑名单列表，一个转发规则最多支持封禁 2000000 个IP，及黑名单容量为 2000000。
        /// （接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public ModifyBlockIPListResponse ModifyBlockIPListSync(ModifyBlockIPListRequest req)
        {
             JsonResponseModel<ModifyBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDomain接口用来修改负载均衡七层监听器下的域名。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public async Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDomain接口用来修改负载均衡七层监听器下的域名。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDomainAttributes接口用于修改负载均衡7层监听器转发规则的域名级别属性，如修改域名、修改DefaultServer、开启/关闭Http2、修改证书。
        /// 本接口为异步接口，本接口返回成功后，需以返回的RequestId为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public async Task<ModifyDomainAttributesResponse> ModifyDomainAttributes(ModifyDomainAttributesRequest req)
        {
             JsonResponseModel<ModifyDomainAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDomainAttributes接口用于修改负载均衡7层监听器转发规则的域名级别属性，如修改域名、修改DefaultServer、开启/关闭Http2、修改证书。
        /// 本接口为异步接口，本接口返回成功后，需以返回的RequestId为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public ModifyDomainAttributesResponse ModifyDomainAttributesSync(ModifyDomainAttributesRequest req)
        {
             JsonResponseModel<ModifyDomainAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyListener接口用来修改负载均衡监听器的属性，包括监听器名称、健康检查参数、证书信息、转发策略等。本接口不支持传统型负载均衡。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public async Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
             JsonResponseModel<ModifyListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyListener接口用来修改负载均衡监听器的属性，包括监听器名称、健康检查参数、证书信息、转发策略等。本接口不支持传统型负载均衡。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
             JsonResponseModel<ModifyListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡实例的属性。支持修改负载均衡实例的名称、设置负载均衡的跨域属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public async Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancerAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡实例的属性。支持修改负载均衡实例的名称、设置负载均衡的跨域属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancerAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyRule 接口用来修改负载均衡七层监听器下的转发规则的各项属性，包括转发路径、健康检查属性、转发策略等。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public async Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyRule 接口用来修改负载均衡七层监听器下的转发规则的各项属性，包括转发路径、健康检查属性、转发策略等。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改目标组的名称或者默认端口属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public async Task<ModifyTargetGroupAttributeResponse> ModifyTargetGroupAttribute(ModifyTargetGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyTargetGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改目标组的名称或者默认端口属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public ModifyTargetGroupAttributeResponse ModifyTargetGroupAttributeSync(ModifyTargetGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyTargetGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改目标组服务器端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public async Task<ModifyTargetGroupInstancesPortResponse> ModifyTargetGroupInstancesPort(ModifyTargetGroupInstancesPortRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetGroupInstancesPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改目标组服务器端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public ModifyTargetGroupInstancesPortResponse ModifyTargetGroupInstancesPortSync(ModifyTargetGroupInstancesPortRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetGroupInstancesPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改目标组的服务器权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public async Task<ModifyTargetGroupInstancesWeightResponse> ModifyTargetGroupInstancesWeight(ModifyTargetGroupInstancesWeightRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetGroupInstancesWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改目标组的服务器权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public ModifyTargetGroupInstancesWeightResponse ModifyTargetGroupInstancesWeightSync(ModifyTargetGroupInstancesWeightRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetGroupInstancesWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTargetPort接口用于修改监听器绑定的后端服务的端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public async Task<ModifyTargetPortResponse> ModifyTargetPort(ModifyTargetPortRequest req)
        {
             JsonResponseModel<ModifyTargetPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTargetPort接口用于修改监听器绑定的后端服务的端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public ModifyTargetPortResponse ModifyTargetPortSync(ModifyTargetPortRequest req)
        {
             JsonResponseModel<ModifyTargetPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTargetWeight 接口用于修改负载均衡绑定的后端服务的转发权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public async Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
             JsonResponseModel<ModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTargetWeight 接口用于修改负载均衡绑定的后端服务的转发权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
             JsonResponseModel<ModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册服务器到目标组。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public async Task<RegisterTargetGroupInstancesResponse> RegisterTargetGroupInstances(RegisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<RegisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册服务器到目标组。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public RegisterTargetGroupInstancesResponse RegisterTargetGroupInstancesSync(RegisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<RegisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RegisterTargets 接口用来将一台或多台后端服务绑定到负载均衡的监听器（或7层转发规则），在此之前您需要先行创建相关的4层监听器或7层转发规则。对于四层监听器（TCP、UDP），只需指定监听器ID即可，对于七层监听器（HTTP、HTTPS），还需通过LocationId或者Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public async Task<RegisterTargetsResponse> RegisterTargets(RegisterTargetsRequest req)
        {
             JsonResponseModel<RegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RegisterTargets 接口用来将一台或多台后端服务绑定到负载均衡的监听器（或7层转发规则），在此之前您需要先行创建相关的4层监听器或7层转发规则。对于四层监听器（TCP、UDP），只需指定监听器ID即可，对于七层监听器（HTTP、HTTPS），还需通过LocationId或者Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public RegisterTargetsResponse RegisterTargetsSync(RegisterTargetsRequest req)
        {
             JsonResponseModel<RegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RegisterTargetsWithClassicalLB 接口用于绑定后端服务到传统型负载均衡。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public async Task<RegisterTargetsWithClassicalLBResponse> RegisterTargetsWithClassicalLB(RegisterTargetsWithClassicalLBRequest req)
        {
             JsonResponseModel<RegisterTargetsWithClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargetsWithClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsWithClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RegisterTargetsWithClassicalLB 接口用于绑定后端服务到传统型负载均衡。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public RegisterTargetsWithClassicalLBResponse RegisterTargetsWithClassicalLBSync(RegisterTargetsWithClassicalLBRequest req)
        {
             JsonResponseModel<RegisterTargetsWithClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterTargetsWithClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsWithClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ReplaceCertForLoadBalancers 接口用以替换负载均衡实例所关联的证书，对于各个地域的负载均衡，如果指定的老的证书ID与其有关联关系，则会先解除关联，再建立新证书与该负载均衡的关联关系。
        /// 此接口支持替换服务端证书或客户端证书。
        /// 需要使用的新证书，可以通过传入证书ID来指定，如果不指定证书ID，则必须传入证书内容等相关信息，用以新建证书并绑定至负载均衡。
        /// 注：本接口仅可从广州地域调用。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertForLoadBalancersRequest"/></param>
        /// <returns><see cref="ReplaceCertForLoadBalancersResponse"/></returns>
        public async Task<ReplaceCertForLoadBalancersResponse> ReplaceCertForLoadBalancers(ReplaceCertForLoadBalancersRequest req)
        {
             JsonResponseModel<ReplaceCertForLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceCertForLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertForLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ReplaceCertForLoadBalancers 接口用以替换负载均衡实例所关联的证书，对于各个地域的负载均衡，如果指定的老的证书ID与其有关联关系，则会先解除关联，再建立新证书与该负载均衡的关联关系。
        /// 此接口支持替换服务端证书或客户端证书。
        /// 需要使用的新证书，可以通过传入证书ID来指定，如果不指定证书ID，则必须传入证书内容等相关信息，用以新建证书并绑定至负载均衡。
        /// 注：本接口仅可从广州地域调用。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertForLoadBalancersRequest"/></param>
        /// <returns><see cref="ReplaceCertForLoadBalancersResponse"/></returns>
        public ReplaceCertForLoadBalancersResponse ReplaceCertForLoadBalancersSync(ReplaceCertForLoadBalancersRequest req)
        {
             JsonResponseModel<ReplaceCertForLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceCertForLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertForLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 负载均衡维度的个性化配置相关操作：创建、删除、修改、绑定、解绑
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public async Task<SetCustomizedConfigForLoadBalancerResponse> SetCustomizedConfigForLoadBalancer(SetCustomizedConfigForLoadBalancerRequest req)
        {
             JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetCustomizedConfigForLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 负载均衡维度的个性化配置相关操作：创建、删除、修改、绑定、解绑
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public SetCustomizedConfigForLoadBalancerResponse SetCustomizedConfigForLoadBalancerSync(SetCustomizedConfigForLoadBalancerRequest req)
        {
             JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetCustomizedConfigForLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加、删除、更新负载均衡的日志服务(CLS)主题。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public async Task<SetLoadBalancerClsLogResponse> SetLoadBalancerClsLog(SetLoadBalancerClsLogRequest req)
        {
             JsonResponseModel<SetLoadBalancerClsLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLoadBalancerClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加、删除、更新负载均衡的日志服务(CLS)主题。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public SetLoadBalancerClsLogResponse SetLoadBalancerClsLogSync(SetLoadBalancerClsLogRequest req)
        {
             JsonResponseModel<SetLoadBalancerClsLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetLoadBalancerClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetLoadBalancerSecurityGroups 接口支持对一个公网负载均衡实例执行设置（绑定、解绑）安全组操作。查询一个负载均衡实例目前已绑定的安全组，可使用 DescribeLoadBalancers 接口。本接口是set语义，
        /// 绑定操作时，入参需要传入负载均衡实例要绑定的所有安全组（已绑定的+新增绑定的）。
        /// 解绑操作时，入参需要传入负载均衡实例执行解绑后所绑定的所有安全组；如果要解绑所有安全组，可不传此参数，或传入空数组。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public async Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
             JsonResponseModel<SetLoadBalancerSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLoadBalancerSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetLoadBalancerSecurityGroups 接口支持对一个公网负载均衡实例执行设置（绑定、解绑）安全组操作。查询一个负载均衡实例目前已绑定的安全组，可使用 DescribeLoadBalancers 接口。本接口是set语义，
        /// 绑定操作时，入参需要传入负载均衡实例要绑定的所有安全组（已绑定的+新增绑定的）。
        /// 解绑操作时，入参需要传入负载均衡实例执行解绑后所绑定的所有安全组；如果要解绑所有安全组，可不传此参数，或传入空数组。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
             JsonResponseModel<SetLoadBalancerSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetLoadBalancerSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个公网负载均衡实例。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public async Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
             JsonResponseModel<SetSecurityGroupForLoadbalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetSecurityGroupForLoadbalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetSecurityGroupForLoadbalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个公网负载均衡实例。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public SetSecurityGroupForLoadbalancersResponse SetSecurityGroupForLoadbalancersSync(SetSecurityGroupForLoadbalancersRequest req)
        {
             JsonResponseModel<SetSecurityGroupForLoadbalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetSecurityGroupForLoadbalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetSecurityGroupForLoadbalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
