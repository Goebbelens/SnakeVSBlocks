using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetCurrentSceneIdx : MonoBehaviour
{
    private int SceneIndex;
    void Start()
    {
        SceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(SceneIndex);
    }

}
