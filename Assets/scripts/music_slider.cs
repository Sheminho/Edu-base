using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music_slider : MonoBehaviour
{
    AudioSource audio;
    public Slider audslide;
    public Toggle audio_mute;
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.FindGameObjectWithTag("BGM").GetComponent<AudioSource>();
        audslide.value = PlayerPrefs.GetFloat("audiolev");
        if (PlayerPrefs.GetInt("audio_mute") == 0)
            audio_mute.isOn = true;
        else
            audio_mute.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("audiolev", audslide.value);
        Debug.Log(audio.volume);
        audio.volume = PlayerPrefs.GetFloat("audiolev");
        if(audio_mute.isOn == true) {
            PlayerPrefs.SetInt("audio_mute", 0);
            audio.mute = true;
        }
        else {
            PlayerPrefs.SetInt("audio_mute", 1);
            audio.mute = false;
        }
            
    }
}
