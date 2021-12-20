using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Canvas canvasLose;

    public  void OnPlayerDie()
    {
        canvasLose.gameObject.SetActive(true);
        restartLevel();
    }

    private void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
