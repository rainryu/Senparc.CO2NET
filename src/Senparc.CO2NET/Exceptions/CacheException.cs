﻿/*----------------------------------------------------------------
    Copyright(C) 2018 Senparc

    文件名：CacheException.cs
    文件功能描述：缓存异常


    创建标识：Senparc - 20180728

----------------------------------------------------------------*/

namespace Senparc.CO2NET.Exceptions
{
    /// <summary>
    /// 缓存异常
    /// </summary>
    public class CacheException : BaseException
    {
        /// <summary>
        /// 缓存异常构造函数
        /// </summary>
        /// <param name="message"></param>
        public CacheException(string message) : base(message, false)
        {
        }
    }
}
