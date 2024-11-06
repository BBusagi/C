using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class Chapter06 : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        cube.OnMouseDownAsObservable()
            .Subscribe(_ =>
            {
                Init();
            });
    }

    void Init()
    {
        StartCoroutine(Ie());

        Ie().ToObservable()
        .DoOnCompleted(() => 
        {
            Debug.Log("Coroutine finished.");
        })
        .Subscribe().AddTo(this);
    }


    IEnumerator Ie()
    {
        Debug.Log("1");
        yield return null;
        Debug.Log("2");
    }
}
