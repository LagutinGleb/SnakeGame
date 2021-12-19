using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

            badSector.BadSectorHP--;
            badSector.UpdateBadSectorHP();

            if (HP == 0)
            {
                Debug.Log("game over"); 
            }

            if (badSector.BadSectorHP == 0)
            {
                Destroy(collision.gameObject);
            }
        }

        if (collision.collider.TryGetComponent(out Food eat))
        {
            HP += eat.HP;
            playerHPvisualise.UpdateVisualisation();
            Destroy(eat.gameObject);
        }
    }
}
