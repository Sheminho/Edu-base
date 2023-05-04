using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer audiomix;
    public void setvolume(float volume)
    {
        audiomix.SetFloat("audio", volume);
    }
    public void volum0()
    {
        audiomix.SetFloat("audio", -80);
    }
}
