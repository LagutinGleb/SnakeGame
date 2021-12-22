using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTryAgain : MonoBehaviour
{
    public GameObject panelStart;
    public GameObject Player;
    //private Controls controls;

    private void Start()
    {
      //  controls = Player.GetComponent<Controls>();
    }

    public void ButtonTryAgainn()
    {
       // controls.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
