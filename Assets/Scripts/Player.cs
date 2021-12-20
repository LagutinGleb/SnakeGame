using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int HP = 10;
    public GameObject childe;
    PlayerHPVisualisation playerHPvisualise;
 
    

    void Start()
    {
      playerHPvisualise = childe.GetComponent<PlayerHPVisualisation>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out BadSector badSector))
        {
            HP--;
            playerHPvisualise.UpdateVisualisation();

            //badSector.BadSectorHP--;
            //badSector.UpdateBadSectorHP();

            if (HP == 0)
            {
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (badSector.BadSectorHP == 0)
            {
                Destroy(collision.gameObject);
            }
        }

        if (collision.collider.TryGetComponent(out Food food))
        {
            //HP += food.HP;
            //playerHPvisualise.UpdateVisualisation();
            //Destroy(food.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
