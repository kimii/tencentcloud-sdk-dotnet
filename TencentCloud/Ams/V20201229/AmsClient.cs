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

namespace TencentCloud.Ams.V20201229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ams.V20201229.Models;

   public class AmsClient : AbstractClient{

       private const string endpoint = "ams.tencentcloudapi.com";
       private const string version = "2020-12-29";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 可使用该接口取消审核任务。请求成功后，接口返回RequestId则说明取消成功。<br>默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可使用该接口取消审核任务。请求成功后，接口返回RequestId则说明取消成功。<br>默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAudioModerationSyncTask） 用于提交短音频内容进行智能审核任务，使用前请您登录控制台开通音频内容安全服务。
        /// 
        /// 功能使用说明：
        /// 前往“内容安全控制台-音频内容安全”开启使用音频内容安全服务，首次开通可获得10小时免费调用时长；
        /// 
        /// 接口限制：
        /// - 音频文件大小支持：文件 < 5M;
        /// - 音频文件时长小于60s，超过60s音频调用则报错；
        /// - 音频码率类型支持：8Kbps - 16Kbps；
        /// - 音频文件支持格式：wav、mp3；
        /// - 接口仅限音频文件传入，视频文件传入请调用长音频异步接口；
        /// - 接口默认QPS为10，默认接口请求频率限制20次/秒，如需要更高的并发或请求频率，请工单咨询；
        /// - 接口超时为5s，每一次请求超过该时长会报错；
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationSyncTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationSyncTaskResponse"/></returns>
        public async Task<CreateAudioModerationSyncTaskResponse> CreateAudioModerationSyncTask(CreateAudioModerationSyncTaskRequest req)
        {
             JsonResponseModel<CreateAudioModerationSyncTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAudioModerationSyncTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioModerationSyncTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAudioModerationSyncTask） 用于提交短音频内容进行智能审核任务，使用前请您登录控制台开通音频内容安全服务。
        /// 
        /// 功能使用说明：
        /// 前往“内容安全控制台-音频内容安全”开启使用音频内容安全服务，首次开通可获得10小时免费调用时长；
        /// 
        /// 接口限制：
        /// - 音频文件大小支持：文件 < 5M;
        /// - 音频文件时长小于60s，超过60s音频调用则报错；
        /// - 音频码率类型支持：8Kbps - 16Kbps；
        /// - 音频文件支持格式：wav、mp3；
        /// - 接口仅限音频文件传入，视频文件传入请调用长音频异步接口；
        /// - 接口默认QPS为10，默认接口请求频率限制20次/秒，如需要更高的并发或请求频率，请工单咨询；
        /// - 接口超时为5s，每一次请求超过该时长会报错；
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationSyncTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationSyncTaskResponse"/></returns>
        public CreateAudioModerationSyncTaskResponse CreateAudioModerationSyncTaskSync(CreateAudioModerationSyncTaskRequest req)
        {
             JsonResponseModel<CreateAudioModerationSyncTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAudioModerationSyncTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioModerationSyncTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（Audio Moderation）用于提交音频内容（包括音频文件或流地址）进行智能审核任务，使用前请您使用腾讯云主账号登录控制台[开通音频内容安全服务](https://console.cloud.tencent.com/cms/audio/package)并调整好对应的业务配置。<br>
        /// 
        /// ### 功能使用说明：
        /// - 前往“[内容安全控制台-音频内容安全](https://console.cloud.tencent.com/cms/audio/package)”开启使用音频内容安全服务，首次开通可获得**10小时**免费调用时长，有效期为1个月。
        /// - 默认接口请求频率限制：**20次/秒**；对于异步审核任务（点播音频），超出频率限制的请求会自动排入待审核队列，对于同步审核任务（直播音频），超出频率限制将会报错。
        /// 
        /// ### 接口功能说明：
        /// - 支持对音频流或音频文件进行检测，判断其中是否包含违规内容；
        /// - 支持设置回调地址 Callback 获取检测结果（对于已在审核的任务，最长回调时间为用户配置的**切片时长 + 2s**），或通过接口(查询音频检测结果)主动轮询获取检测结果；
        /// - 支持识别违规内容，包括：低俗、谩骂、色情、涉政、广告等场景；
        /// - 支持批量提交检测任务，检测任务列表**最多支持10个**。
        /// 
        /// ### 音频文件调用说明：
        /// - 音频文件大小支持：**文件 < 500M**；
        /// - 音频文件时长支持：**< 1小时**；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频文件支持格式：wav、mp3、aac、flac、amr、3gp、 m4a、wma、ogg、ape；
        /// - （**当输入为视频文件时**）支持分离视频文件音轨，并对音频内容进行独立审核。
        /// 
        /// ### 音频流调用说明：
        /// - 音频流时长支持：**< 3小时**；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频流支持的传输协议：RTMP、HTTP、HTTPS；
        /// - 音频流格式支持的类型：rtp、srtp、rtmp、rtmps、mmsh、 mmst、hls、http、tcp、https、m3u8；
        /// - （**当输入为视频流时**）支持提取视频流音轨，并对音频内容进行独立审核。
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationTaskResponse"/></returns>
        public async Task<CreateAudioModerationTaskResponse> CreateAudioModerationTask(CreateAudioModerationTaskRequest req)
        {
             JsonResponseModel<CreateAudioModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAudioModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（Audio Moderation）用于提交音频内容（包括音频文件或流地址）进行智能审核任务，使用前请您使用腾讯云主账号登录控制台[开通音频内容安全服务](https://console.cloud.tencent.com/cms/audio/package)并调整好对应的业务配置。<br>
        /// 
        /// ### 功能使用说明：
        /// - 前往“[内容安全控制台-音频内容安全](https://console.cloud.tencent.com/cms/audio/package)”开启使用音频内容安全服务，首次开通可获得**10小时**免费调用时长，有效期为1个月。
        /// - 默认接口请求频率限制：**20次/秒**；对于异步审核任务（点播音频），超出频率限制的请求会自动排入待审核队列，对于同步审核任务（直播音频），超出频率限制将会报错。
        /// 
        /// ### 接口功能说明：
        /// - 支持对音频流或音频文件进行检测，判断其中是否包含违规内容；
        /// - 支持设置回调地址 Callback 获取检测结果（对于已在审核的任务，最长回调时间为用户配置的**切片时长 + 2s**），或通过接口(查询音频检测结果)主动轮询获取检测结果；
        /// - 支持识别违规内容，包括：低俗、谩骂、色情、涉政、广告等场景；
        /// - 支持批量提交检测任务，检测任务列表**最多支持10个**。
        /// 
        /// ### 音频文件调用说明：
        /// - 音频文件大小支持：**文件 < 500M**；
        /// - 音频文件时长支持：**< 1小时**；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频文件支持格式：wav、mp3、aac、flac、amr、3gp、 m4a、wma、ogg、ape；
        /// - （**当输入为视频文件时**）支持分离视频文件音轨，并对音频内容进行独立审核。
        /// 
        /// ### 音频流调用说明：
        /// - 音频流时长支持：**< 3小时**；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频流支持的传输协议：RTMP、HTTP、HTTPS；
        /// - 音频流格式支持的类型：rtp、srtp、rtmp、rtmps、mmsh、 mmst、hls、http、tcp、https、m3u8；
        /// - （**当输入为视频流时**）支持提取视频流音轨，并对音频内容进行独立审核。
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationTaskResponse"/></returns>
        public CreateAudioModerationTaskResponse CreateAudioModerationTaskSync(CreateAudioModerationTaskRequest req)
        {
             JsonResponseModel<CreateAudioModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAudioModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过该接口可查看音频审核任务的详情信息，包括任务状态、检测结果、音频文件识别出的对应文本内容、检测结果所对应的恶意标签及推荐的后续操作等，具体输出内容可查看输出参数示例。<br>默认接口请求频率限制：**100次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过该接口可查看音频审核任务的详情信息，包括任务状态、检测结果、音频文件识别出的对应文本内容、检测结果所对应的恶意标签及推荐的后续操作等，具体输出内容可查看输出参数示例。<br>默认接口请求频率限制：**100次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过该接口可查看审核任务列表；您也可根据多种业务信息（业务类型、审核结果、任务状态等）筛选审核任务列表。任务列表输出内容包括当前查询的任务总量、任务名称、任务状态、音频审核类型、基于检测结果的恶意标签及其后续操作等，具体输出内容可查看输出参数示例。<br>默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过该接口可查看审核任务列表；您也可根据多种业务信息（业务类型、审核结果、任务状态等）筛选审核任务列表。任务列表输出内容包括当前查询的任务总量、任务名称、任务状态、音频审核类型、基于检测结果的恶意标签及其后续操作等，具体输出内容可查看输出参数示例。<br>默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
