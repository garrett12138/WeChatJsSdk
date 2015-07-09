using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChatJsSdk.SdkCore
{
    [Flags]
    public enum JsApiEnum : ulong
    {
        onMenuShareTimeline = 0x1,
        onMenuShareAppMessage = 0x2,
        onMenuShareQQ = 0x4,
        onMenuShareWeibo = 0x8,
        startRecord = 0x10,
        stopRecord = 0x20,
        onVoiceRecordEnd = 0x40,
        playVoice = 0x80,
        pauseVoice = 100,
        stopVoice = 0x200,
        onVoicePlayEnd = 0x400,
        uploadVoice = 0x800,
        downloadVoice = 0x1000,
        chooseImage = 0x2000,
        previewImage = 0x4000,
        uploadImage = 0x8000,
        downloadImage = 0x10000,
        translateVoice = 0x20000,
        getNetworkType = 0x40000,
        openLocation = 0x80000,
        getLocation = 0x100000,
        hideOptionMenu = 0x200000,
        showOptionMenu = 0x400000,
        hideMenuItems = 0x800000,
        showMenuItems = 0x1000000,
        hideAllNonBaseMenuItem = 0x2000000,
        showAllNonBaseMenuItem = 0x4000000,
        closeWindow = 0x8000000,
        scanQRCode = 0x10000000,
        chooseWXPay = 0x20000000,
        openProductSpecificView = 0x40000000,
        addCard = 0x80000000,
        chooseCard = 0x100000000,
        openCard = 0x200000000
    }
}
