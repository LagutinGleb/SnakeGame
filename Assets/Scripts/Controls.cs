using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float ForvardSpeed = 5f;
    private float strafeSpeed = 5f;
    public Rigidbody PlayerRB;
    float moovment;
    public float boulForce = 5f;
    
   
    void Start()
    {
        StartMooveForward();
    }

    void FixedUpdate()
    {
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
         PlayerRB.AddForce(new Vector3(0, 0, ForvardSpeed * 2), ForceMode.Impulse);
    }
    
    private void StartMooveForward()
    {
        PlayerRB.AddForce(new Vector3(0, 0, ForvardSpeed), ForceMode.Impulse);
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
        PlayerRB.AddForce(new Vector3(0, 0, -boulForce), ForceMode.Impulse);
        await Task.Delay (150);
        MooveForward();
    }
}
