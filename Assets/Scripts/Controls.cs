using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private float ForvardSpeed = 5f;
    private float strafeSpeed = 5f;
    public Rigidbody PlayerRB;
    float moovment;
    private float boulForce = 50f;
    private bool canGoForward = true;
    
   
    void Start()
    {
        if (canGoForward)
        {
            MooveForward();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (canGoForward)
        //{
        //MooveForward();
        //}

        moovment = Input.GetAxis("Horizontal");

        if (moovment > 0)
        {
            PlayerRB.transform.position += new Vector3(1, 0, 0) * strafeSpeed * Time.deltaTime;
        }
        else if (moovment < 0)
        {
            PlayerRB.transform.position += new Vector3(-1, 0, 0) * strafeSpeed * Time.deltaTime;
        }
    }

    private void MooveForward()
    {
         PlayerRB.AddForce(new Vector3(0, 0, ForvardSpeed), ForceMode.VelocityChange);
        //PlayerRB.transform.position += new Vector3(0, 0, 1) * ForvardSpeed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out BadSector badSector))
        {
            Boul();
        }

        return;
    }

    public async void Boul()
    {
        canGoForward = false;
        PlayerRB.AddForce(new Vector3(0, 0, -boulForce), ForceMode.Force);
        await Task.Delay (200);
        MooveForward();
        canGoForward = true;
    }
}
