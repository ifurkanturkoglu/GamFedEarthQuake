using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuController : MonoBehaviour
{
    public static MainMenuController Instance;
    [SerializeField] GameObject infoPanel, settingsPanel;

    bool infoPanelIsOpen,settingsPanelIsOpen;
    
    void Start()
    {
        Instance = this;
    }
    public void GamaStart(){
        SceneManager.LoadScene(1);
    }
    public void Exit(){
        Application.Quit();
    }
    public void InfoPanel(){
        infoPanelIsOpen = !infoPanelIsOpen;
        infoPanel.SetActive(infoPanelIsOpen);
    }
    public void SettingsPanel(){
        settingsPanelIsOpen = !settingsPanelIsOpen;
        settingsPanel.SetActive(settingsPanelIsOpen);
    }
}