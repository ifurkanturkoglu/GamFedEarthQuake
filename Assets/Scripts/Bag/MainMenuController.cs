using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuController : MonoBehaviour
{
    [SerializeField] GameObject infoPanel;
    bool infoPanelIsOpen;
    
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
}