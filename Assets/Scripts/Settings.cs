using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Settings : MonoBehaviour
{
    public static Settings instance;
    [SerializeField] Slider sfx, music,master;
    [SerializeField] AudioMixer audioMixer;

    [SerializeField] GameObject settingsPanel;

    bool settingsPanelIsOpen;

    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
    private void Start()
    {
        music.value = (music.maxValue + music.minValue) / 2;
        sfx.value = (sfx.maxValue + sfx.minValue) / 2;
        master.value = (master.maxValue + master.minValue) / 2;
        gameObject.SetActive(false);
    }
    public void masterEdit(){
        audioMixer.SetFloat("master", master.value);
    }
    public void sfxEdit()
    {
        audioMixer.SetFloat("sfx", sfx.value);
    }
    public void musicEdit()
    {
        audioMixer.SetFloat("music", music.value);
    }
    public void SettingsPanel()
    {
        settingsPanelIsOpen = !settingsPanelIsOpen;
        settingsPanel.SetActive(settingsPanelIsOpen);
    }
}
