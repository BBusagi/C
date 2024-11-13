using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chapter01 : MonoBehaviour
{
    public TMP_Text TextBoard;
    public Button LoadTextButton;
    public Button LoadSceneButton;
    public Slider slider;

    void Start()
    {
        LoadTextButton.onClick.AddListener(OnLoadText);

        LoadSceneButton.onClick.AddListener(OnLoadScene);
    }

    private async void OnLoadScene()
    {
        await SceneManager.LoadSceneAsync("Scenes/TargetScene").ToUniTask(
            (Progress.Create<float>(
                (p) =>
                {
                    Debug.Log("OnLoadScene Progress: " + p);
                    slider.value = p;
                }
            ))
        );
    }

    private async void OnLoadText()
    {
        // ResourceRequest loadOperation = Resources.LoadAsync<TextAsset>("Test"); //Async
        // var text = await loadOperation; //await => ResourceRequestAwaiter, GetResult(), asyncOperation.asset
        // TextBoard.text = ((TextAsset) text).text;

        UniTaskTools unitaskAsyncLoader = new UniTaskTools();
        TextBoard.text = ((TextAsset)(await unitaskAsyncLoader.LoadAsync<TextAsset>("Test"))).text;
    }

    void Update()
    {
        
    }
}
