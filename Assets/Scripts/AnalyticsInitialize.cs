using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Unity.FPS.Game;

public class AnalyticsInitialize : MonoBehaviour
{
    public int Level;
    // Start is called before the first frame update
    void Start()
    {
        GameAnalytics.Initialize();

        GameAnalytics.NewErrorEvent(GAErrorSeverity.Info, "Could not find available server.");
    }

    void Update()
    {
        if (FindObjectOfType<GameFlowManager>().NewLevel)
        {
            NewLevelEvent();
            FindObjectOfType<GameFlowManager>().NewLevel = false;
        }
    }

    public void NewLevelEvent()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Level" + Level);
    }
}
