using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Settings : MonoBehaviour
{
    [SerializeField] Slider sfx,music;
    [SerializeField] AudioMixer audioMixer;
    void Start()
    {
        music.value = (music.maxValue+music.minValue)/2;
        sfx.value = (sfx.maxValue + sfx.minValue)/2;
        DontDestroyOnLoad(this.gameObject);
    }
    public void sfxEdit(){
        audioMixer.SetFloat("sfx",sfx.value);
    }
    public void musicEdit(){
         audioMixer.SetFloat("music",music.value);
    }
    
}
