using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnalyticsInitialize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameAnalytics.Initialize();
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "World1_Level2", "WeaponUpgrade", "Sword", 65);
        GameAnalytics.NewErrorEvent(GAErrorSeverity.Info, "Could not find available server.");
    }
}
