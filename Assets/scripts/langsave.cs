using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class langsave : MonoBehaviour
{
    public Toggle ar;
    private void Start()
    {
        if (PlayerPrefs.GetInt("lang") == 0)
            ar.isOn = true;
        else
            ar.isOn = false;
    }
    private void Update()
    {
        if (ar.isOn)
            PlayerPrefs.SetInt("lang", 0);
        else
            PlayerPrefs.SetInt("lang", 1);
    }
}
