using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChatJsSdk.SdkCore
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class SignPackage
    {
        /*
        wx.config({
         debug: true, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
         appId: '', // 必填，公众号的唯一标识
         timestamp: , // 必填，生成签名的时间戳
         nonceStr: '', // 必填，生成签名的随机串
         signature: '',// 必填，签名，见附录1
         jsApiList: [] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2
        }); 
         */
        public bool debug { get; set; }
        public string appId{get;set;} // 必填，公众号的唯一标识
        public long timestamp{get;set;} // 必填，生成签名的时间戳
        public string nonceStr{get;set;} // 必填，生成签名的随机串
        public string signature{get;set;}// 必填，签名，见附录1
        public string[] jsApiList { get; set; } // 必填，需要使用的JS接口列表，所有JS接口列表见附录2
    }
}
