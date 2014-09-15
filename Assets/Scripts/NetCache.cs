// 协议包
// using PegasusUtil;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class NetCache
{
    //private List<NetCacheRequest> m_cacheRequests = new List<NetCacheRequest>();
    //private Dictionary<System.Type, int> m_changeRequests = new Dictionary<System.Type, int>();
    //private List<DelGoldBalanceListener> m_goldBalanceListeners = new List<DelGoldBalanceListener>();
    //private List<System.Type> m_inTransitRequests = new List<System.Type>();
    //private Dictionary<System.Type, NetCacheBase> m_netCache = new Dictionary<System.Type, NetCacheBase>();
    //private List<DelNewNoticesListener> m_newNoticesListeners = new List<DelNewNoticesListener>();
    //private NetCacheHeroLevels m_prevHeroLevels;
    //private NetCacheMedalInfo m_previousMedalInfo;
    //private NetCacheClientOptions m_prevOptions = new NetCacheClientOptions();
    private static Dictionary<System.Type, int> m_typeIDs;
    private readonly TimeSpan MAX_WAIT = new TimeSpan(0, 0, 15);
    private static NetCache s_instance;

    static NetCache()
    {
        Dictionary<System.Type, int> dictionary = new Dictionary<System.Type, int>();
        //dictionary.Add(typeof(NetCacheLastLogin), 1);
        //dictionary.Add(typeof(NetCacheDecks), 2);
        //dictionary.Add(typeof(NetCacheCollection), 3);
        //dictionary.Add(typeof(NetCacheMedalInfo), 4);
        //dictionary.Add(typeof(NetCacheMedalHistory), 5);
        //dictionary.Add(typeof(NetCacheBoosters), 6);
        //dictionary.Add(typeof(NetCachePlayerRecords), 8);
        //dictionary.Add(typeof(NetCacheGamesPlayed), 9);
        //dictionary.Add(typeof(NetCacheDeckLimit), 10);
        //dictionary.Add(typeof(NetCacheProfileProgress), 11);
        //dictionary.Add(typeof(NetCacheProfileNotices), 12);
        //dictionary.Add(typeof(NetCacheMessageOfTheDay), 13);
        //dictionary.Add(typeof(NetCacheClientOptions), 14);
        //dictionary.Add(typeof(NetCacheCardValues), 15);
        //dictionary.Add(typeof(NetCacheDisconnectedGame), 0x10);
        //dictionary.Add(typeof(NetCacheArcaneDustBalance), 0x11);
        //dictionary.Add(typeof(NetCacheFeatures), 0x12);
        //dictionary.Add(typeof(NetCacheRewardProgress), 0x13);
        //dictionary.Add(typeof(NetCacheGoldBalance), 20);
        //dictionary.Add(typeof(NetCacheHeroLevels), 0x15);
        //dictionary.Add(typeof(NetCachePlayQueue), 0x16);
        m_typeIDs = dictionary;
        s_instance = new NetCache();
    }

}

