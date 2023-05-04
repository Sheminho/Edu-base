using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class go : MonoBehaviour
{
    IEnumerator waiter(int sceneid)
    {
        //Wait for 2 seconds
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene(sceneid);
    }
    public void gos(int scene) {
        StartCoroutine(waiter(scene));
    }
}