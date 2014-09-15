using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HealthyGamingMgr : MonoBehaviour
{
    private static Dictionary<string, int> tempDic
    {
        get { return null; }
        set { }
    }
    private const float CAIS_ACTIVE_MESSAGE_DISPLAY_TIME = 60f;
    private const float CAIS_MESSAGE_DISPLAY_TIME = 60f;
    private const float CHECK_INTERVAL = 300f;
    private const float KOREA_MESSAGE_DISPLAY_TIME = 5f;
    private string m_AccountCountry = string.Empty;
    private bool m_BattleNetReady;
    private bool m_DebugMode;
    private bool m_HealthyGamingArenaEnabled = true;
    private bool m_NetworkDataReady;
    private float m_NextCheckTime;
    private float m_NextMessageDisplayTime;
    //private BattleNet.DllLockouts m_Restrictions;
    private int m_TimePlayed;
    private int m_TimeRested;
    private static HealthyGamingMgr s_Instance;

    private void Awake()
    {
        s_Instance = this;
    }
}

