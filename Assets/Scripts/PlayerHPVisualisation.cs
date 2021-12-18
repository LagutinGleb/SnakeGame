using TMPro;
using UnityEngine;

public class PlayerHPVisualisation : MonoBehaviour
{
    public TextMeshPro text;
    public int HP;
    GameObject parent;


    private void Start()
    {
        text.text = GetComponentInParent<Player>().HP.ToString();
    }


    public void UpdateVisualisation()
    {
        text.text = GetComponentInParent<Player>().HP.ToString(); 
    }
}
