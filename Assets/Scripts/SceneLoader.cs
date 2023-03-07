using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    [Header("移行したいシーンの名前")]
    string _sceneName;
    public void OnClick()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
