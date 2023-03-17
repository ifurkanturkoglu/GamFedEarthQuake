using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsAfter : MonoBehaviour
{
    [SerializeField] GameObject missionText;

    private void Start()
    {
        missionText = GameObject.Find("MissionCanvas");
        missionText.SetActive(false);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
