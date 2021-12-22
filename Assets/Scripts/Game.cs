using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public UI ui;
    public Player player;
    public bool firstStart = true;
    public GameObject panelStart;
    private int sceneCountInBildSettings;



    private void Start()
    {
        if (firstStart)
        {
            panelStart.gameObject.SetActive(true);
        }
        firstStart = false;

        sceneCountInBildSettings = SceneManager.sceneCount;
        Debug.Log(sceneCountInBildSettings);
    }

    public void OnPlayerDie()
    {
        player.gameObject.SetActive(false);
        ui.ShowUIPanelLose();
    }

    public void OnPlayerWin()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 == sceneCountInBildSettings)
        {
            player.gameObject.SetActive(false);
            ui.ShowUIPanelGamePassed();
            return;
        }
        
        
        player.gameObject.SetActive(false);
        ui.ShowUIPanelWin();
    }





    //private void RestartLevel()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}


}
