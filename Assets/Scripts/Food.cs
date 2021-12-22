using UnityEngine;

public class Food : MonoBehaviour
{
    public int HP;

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
    }
}
