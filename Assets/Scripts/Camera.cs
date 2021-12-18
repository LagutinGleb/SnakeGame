using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //public Transform cameraPositon;
    public GameObject player;
    public Vector3 delta;

    private void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position + delta;
    }
}
