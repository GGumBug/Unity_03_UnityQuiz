using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scene
{
    Menu,
    Main,
    Quiz
}

public class ScenesManager : MonoBehaviour
{
    #region SingleTone
    public static ScenesManager Instance;

    public static ScenesManager GetInstance()
    {
        GameObject go = new GameObject("@ScenesManager");
        Instance = go.AddComponent<ScenesManager>();

        DontDestroyOnLoad(go);

        return Instance;
    }
    #endregion


    public void ChangeScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
