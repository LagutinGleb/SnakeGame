using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public UI ui;
    public Player player;
    public bool firstStart = true;
    public GameObject panelStart;
  

    private void Start()
    {
        if (firstStart)
        {
            panelStart.gameObject.SetActive(true);
        }
        firstStart = false;
    }

    public void OnPlayerDie()
    {
        player.gameObject.SetActive(false);
        ui.ShowUIPanelLose();
    }

    public void OnPlayerWin()
    {
        player.gameObject.SetActive(false);
        ui.ShowUIPanelWin();
    }



    //private void RestartLevel()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}


}
