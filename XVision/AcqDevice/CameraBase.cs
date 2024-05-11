using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

namespace AcqDevice
{
    public abstract class CameraBase
    {
        /// <summary>
        /// 获取或设置曝光时间，微秒
        /// </summary>
        public abstract float Exposure { get; set; }

        /// <summary>
        /// 支持的最大曝光值
        /// </summary>
        public abstract float ExposureMax { get; }

        /// <summary>
        /// 支持的最小曝光值
        /// </summary>
        public abstract float ExposureMin { get; }

        /// <summary>
        /// 获取或设置增益值
        /// </summary>
        public abstract float Gain { get; set; }

        /// <summary>
        /// 获取或设置心跳时间，毫秒
        /// </summary>
        public abstract float Heartbeat { get; set; }

        /// <summary>
        /// 相机的名称或者IP
        /// </summary>
        public abstract string NameOrIP { get; set; }

        /// <summary>
        /// 创建本地资源
        /// </summary>
        /// <returns>错误码</returns>
        public abstract int CreateHandle();

        /// <summary>
        /// 释放本地申请的资源
        /// </summary>
        /// <returns>错误码</returns>
        public abstract int DestroyHandle();

        /// <summary>
        /// 打开相机设备
        /// </summary>
        /// <returns>错误码</returns>
        public abstract int OpenDevice();

        /// <summary>
        /// 关闭相机设备
        /// </summary>
        /// <returns>错误码</returns>
        public abstract int CloseDevice();

        /// <summary>
        /// 开始采集
        /// </summary>
        /// <returns>错误码</returns>
        public abstract int StartGrabbing();

        /// <summary>
        /// 停止采集
        /// </summary>
        /// <returns>错误码</returns>
        public abstract int StopGrabbing();
    }
}
