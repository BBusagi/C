using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chapter01_2 : MonoBehaviour
{
    public Button DelayButton;
    public Button DelayFrameButton;

    void Start()
    {
        DelayButton.onClick.AddListener(OnClickDelay);
        DelayFrameButton.onClick.AddListener(OnClickDelayFrame);
    }

    private async void OnClickDelay()
    { 
        Debug.Log("Delay 1 second");
        Debug.Log(Time.time);
        await UniTask.Delay(TimeSpan.FromSeconds(1));
        Debug.Log(Time.time);
    }
    private async void OnClickDelayFrame()
    {
        Debug.Log("Delay 5 frame");
        Debug.Log(Time.frameCount);
        await UniTask.DelayFrame(5);
        Debug.Log(Time.frameCount);
    }
}
