using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active : MonoBehaviour
{
    public GameObject setting;
    public void opens()
    {
        setting.SetActive(true);
    }
    public void nonopens()
    {
        setting.SetActive(false);
    }
}
