using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuController : MonoBehaviour
{
    public static MainMenuController Instance;
    [SerializeField] GameObject infoPanel;

    bool infoPanelIsOpen;
    
    void Start()
    {
        Instance = this;
        Cursor.lockState = CursorLockMode.None;
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
}