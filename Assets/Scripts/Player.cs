using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int HP = 10;
    public GameObject childe;
    PlayerHPVisualisation playerHPvisualise;
    public GameObject camera;
    Game game;
    public ParticleSystem particalSystemBlockCrash;
    

    void Start()
    {
        playerHPvisualise = childe.GetComponent<PlayerHPVisualisation>();
        game = camera.GetComponent<Game>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out BadSector badSector))
        {
            HP--;
            playerHPvisualise.UpdateVisualisation();
            UI.score++;

            badSector.BadSectorHP--;
            badSector.UpdateBadSectorHP();

            if (HP == 0)
            {
                game.OnPlayerDie();
            }

            if (badSector.BadSectorHP == 0)
            {
                particalSystemBlockCrash.transform.position = collision.gameObject.transform.position;
                Destroy(collision.gameObject);
                particalSystemBlockCrash.Play();
            }
        }

        if (collision.collider.TryGetComponent(out Food food))
        {
            HP += food.HP;
            playerHPvisualise.UpdateVisualisation();
            Destroy(food.gameObject);
        }

        if (collision.collider.TryGetComponent(out Finish fifnish))
        {
            game.OnPlayerWin();
        }
    }
}
