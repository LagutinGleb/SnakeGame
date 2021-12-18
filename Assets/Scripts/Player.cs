using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int HP = 10;
    Controls controls = new Controls();
    
    
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out BadSector badSector))
        {
            HP--;
            badSector.BadSectorHP--;
            badSector.UpdateHP();

            if (HP == 0)
            {
                Debug.Log("game over"); 
            }

            if (badSector.BadSectorHP == 0)
            {
                Destroy(collision.gameObject);
            }
        }

        if (collision.collider.TryGetComponent(out Eat eat))
        {
            HP += eat.HP;
            Destroy(eat.gameObject);
        }
    }

    void FixedUpdate()
    {
            
    }

    void Update()
    {
        
    }


}
