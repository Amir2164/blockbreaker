using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{// parameters
    [SerializeField]
    int breakableblocks; // using serialize for debugging
    //cached veriable
    SceneLoader sceneloader;
    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void countBlocks()
    {
        breakableblocks++;
    }
    public void destroyedobject()
    {
        breakableblocks--;
        if (breakableblocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
     
}
