using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using WeChatJsSdk.SdkCore;
namespace WeChatJsSdk.Demo.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /index/

        public ActionResult index()
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
            /* web.config 设置appid,appsecret,dubug
               <appSettings>
                <add key="WeChatAppId" value="your appid here"/>
                <add key="WeChatAppSecret" value="your appsecret here"/>
                <add key="WeChatJsDebug" value="true"/>
              </appSettings> 
            */
            string appId = System.Configuration.ConfigurationManager.AppSettings["WeChatAppId"];
            string appSecret = System.Configuration.ConfigurationManager.AppSettings["WeChatAppSecret"];
            bool debug = System.Configuration.ConfigurationManager.AppSettings["WeChatAppSecret"].ToLower() == "true";
            JSSDK sdk = new JSSDK(appId,appSecret,debug);
            SignPackage config = sdk.GetSignPackage(JsApiEnum.scanQRCode|JsApiEnum.onMenuShareQQ);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            ViewBag.config = serializer.Serialize(config);
            //string str_config = "{";
            //str_config += string.Format("debug:{0},", config.debug ? "true" : "false");
            //str_config += string.Format("appId:'{0}',", config.appId);
            //str_config += string.Format("timestamp:{0},", config.timestamp);
            //str_config += string.Format("nonceStr:'{0}',", config.nonceStr);
            //str_config += string.Format("signature:'{0}',", config.signature);
            //str_config += "jsApiList:[";
            //for (int i = 0; i < config.jsApiList.Length; i++)
            //{
            //    if (i > 0)
            //        str_config += ",";
            //    str_config += string.Format("'{0}'", config.jsApiList[i]);
            //}
            //str_config += "]}";
            //ViewBag.config = str_config;
            return View();
        }

    }
}
