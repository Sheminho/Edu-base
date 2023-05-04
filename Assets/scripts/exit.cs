using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public void outs()
    {
        StartCoroutine(waiter());
        
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.3f);
        Debug.Log("exittttt");
        Application.Quit();
    }
}

