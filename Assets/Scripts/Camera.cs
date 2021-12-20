using UnityEngine;

public class Camera : MonoBehaviour
{
    //public Transform cameraPositon;
    public GameObject player;
    public Vector3 delta;

    void Update()
    {
        transform.position = player.transform.position + delta;
    }
}
