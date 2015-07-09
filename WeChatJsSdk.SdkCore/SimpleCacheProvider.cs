using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChatJsSdk.Utility;

namespace WeChatJsSdk.SdkCore
{
    /// <summary>
    /// SimpleProvider
    /// </summary>
    public class SimpleCacheProvider:ICacheProvider
    {

        private static SimpleCacheProvider _instance;

        public static SimpleCacheProvider GetInstance()
        {
            if (_instance == null) _instance = new SimpleCacheProvider();
            return _instance;
        }
        private Dictionary<string, CacheItem> _caches;
        private SimpleCacheProvider()
        {
            this._caches = new Dictionary<string, CacheItem>();
        }
        public object GetCache(string key)
        {
            return this._caches.ContainsKey(key) ? this._caches[key].Expired() ? null : this._caches[key].Value : null;
        }

        public void SetCache(string key, object value, int expire = 300)
        {
            this._caches[key] = new CacheItem(key,value,expire);
        }

        class CacheItem {

            private long _insertTime;

         
            private int _expire;

            private object _value;

            public object Value
            {
                get { return _value; }
                set { _value = value; }
            }
            private string _key;

            public string Key
            {
                get { return _key; }
                set { _key = value; }
            }

            public CacheItem(string key, object value,int expire)
            {
                this._key = key;
                this._value = value;
                this._expire = expire;
                this._insertTime = TimeStamp.Now();
            }

            public bool Expired() {
                return TimeStamp.Now() > this._insertTime + _expire;
            }
        }
    }
}
