using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    public GameObject M1, M2, M3, M4;
    public void activerand()
    {
        int rand = Random.Range(1, 5);
        while (rand != 5) {
            Debug.Log(rand);
            if (rand == 1) { 
                M1.SetActive(true);
                break;
            }
            else if (rand == 2)
            {
                M2.SetActive(true);
                break;
            }
            else if (rand == 3)
            {
                M3.SetActive(true);
                break;
            }
            else
            {
                M4.SetActive(true);
                break;
            }
        }
    }
}