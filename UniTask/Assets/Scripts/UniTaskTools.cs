using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
/// <summary>
/// 该脚本不继承monobehavriour，即可在非Unity托管中运行
/// </summary>
public class UniTaskTools
{
    public async UniTask<Object> LoadAsync<T>(string path) where T : Object
    {
        ResourceRequest loadOperation = Resources.LoadAsync<T>(path);
        return await loadOperation;
    }
}
