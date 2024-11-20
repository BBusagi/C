using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chapter01_2 : MonoBehaviour
{
    public PlayerLoopTiming TestYieldTiming = PlayerLoopTiming.PreUpdate;
    public Button DelayButton;
    public Button DelayFrameButton;
    public Button YieldButton;
    public Button NextFrameButton;
    public Button EndofFrameButton;

    private UniTaskTools uniTaskWaiter;


    void Start()
    {
        DelayButton.onClick.AddListener(OnClickDelay);
        DelayFrameButton.onClick.AddListener(OnClickDelayFrame);
        YieldButton.onClick.AddListener(OnClickYield);
        NextFrameButton.onClick.AddListener(OnClickNextFrame);
        EndofFrameButton.onClick.AddListener(OnClickEndofFrame);
        uniTaskWaiter = new UniTaskTools();
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
    private async void OnClickYield()
    {
        Debug.Log("Wait Yield ");
        Debug.Log("Start " + TestYieldTiming);
        await uniTaskWaiter.WaitYield(TestYieldTiming);
        Debug.Log("End " + TestYieldTiming);
    }

    private async void OnClickNextFrame()
    {
        Debug.Log("Wait NextFrame");
        Debug.Log("Start " + Time.frameCount);
        await uniTaskWaiter.WaitNextFrame();
        Debug.Log("End " + Time.frameCount);
    }
    private async void OnClickEndofFrame()
    {
        Debug.Log("Wait EndofFrame");
        Debug.Log("Start " + Time.frameCount);
        await uniTaskWaiter.WaitEndofFrame(this);
        Debug.Log("End " + Time.frameCount);
    }

    /// <summary>
    /// 查看底层系统
    /// </summary>
    // private void InjectFunction()
    // {
    //     PlayerLoopSystem playerLoop = PlayerLoop.GetCurrentPlayerLoop();    //获得所有的更新内容
    //     var subsystems = playerLoop.subSystemList;
    //     playerLoop.updateDelegate += OnUpdate;
    //     for (int i = 0; i< subsystems.Length; i++)
    //     {
    //         int index = i;
    //         PlayerLoopSystem.UpdateFunction injectFunction = () =>
    //         {
    //             if (!_showUpdateLog) return;
    //             //输出当前的子系统
    //             Debug.Log($"subsystem{_showUpdateLog} {subsystems[index]} framecount {Time.frameCount}");

    //         }
    //     }
    // }
}
