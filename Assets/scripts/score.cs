using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text highestmark;
    public Text markpercent;
    public Text wrongans;
    int mark = 0;
    public void addscore()
    {
        mark++;
        highestmark.text = mark.ToString();
        markpercent.text = (mark * 10).ToString() + "%";
        wrongans.text = (10 - mark).ToString();
    }
}