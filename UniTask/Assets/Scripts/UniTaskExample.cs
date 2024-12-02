using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;

public class UniTaskExample : MonoBehaviour
{
    void Start()
    {
        RunExampleTasks().Forget();
    }

    async UniTask Task1()
    {
        await UniTask.Delay(1000);
        Debug.Log("Task 1 completed");
    }

    async UniTask Task2()
    {
        await UniTask.Delay(2000);
        Debug.Log("Task 2 completed");
    }
    async UniTask TaskWhenAll()
    {
        Debug.Log("Waiting for all tasks to complete...");
        await UniTask.WhenAll(Task1(),Task2());
        Debug.Log("All task completed");
    }

    async UniTask TaskWhenAny()
    {
        Debug.Log("Waiting for any task to complete...");
        await UniTask.WhenAny(Task1(),Task2());
        Debug.Log("At least one task completed");
    }

    async UniTaskVoid RunExampleTasks()
    {
        Debug.Log("Starting task examples...");

        await TaskWhenAll();

        await TaskWhenAny();

        Debug.Log("Task examples finished!");
    }
}
