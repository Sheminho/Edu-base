using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class selectscene : MonoBehaviour
{
    public Toggle tog_let, tog_3d, ar;
    public GameObject test_en, test_ar;
    public int ar_sc_let, en_sc_let, ar_sc_num, en_sc_num, ar_sc_num_3d, en_sc_num_3d, ar_sc_let_3d, en_sc_let_3d;
    public void learn_select()
    {
        if (ar.isOn)
        {
            if (tog_3d.isOn)
            {
                if (tog_let.isOn)
                    SceneManager.LoadScene(ar_sc_let_3d);
                else
                    SceneManager.LoadScene(ar_sc_num_3d);
            }
            else
            {
                if (tog_let.isOn)
                    SceneManager.LoadScene(ar_sc_let);
                else
                    SceneManager.LoadScene(ar_sc_num);
            }
        }
        else
        {
            if (tog_3d.isOn)
            {
                if (tog_let.isOn)
                    SceneManager.LoadScene(en_sc_let_3d);
                else
                    SceneManager.LoadScene(en_sc_num_3d);
            }
            else
            {
                if (tog_let.isOn)
                    SceneManager.LoadScene(en_sc_let);
                else
                    SceneManager.LoadScene(en_sc_num);
            }
        }
    }
    public void test_select()
    {
        if (ar.isOn)
            test_ar.SetActive(true);
        else
            test_en.SetActive(true);
    }
}
