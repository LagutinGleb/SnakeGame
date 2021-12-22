using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource finish = GetComponent<AudioSource>();
        finish.Play();
    }
}
