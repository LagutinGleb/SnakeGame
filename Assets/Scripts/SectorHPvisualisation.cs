using UnityEngine;
using TMPro;

public class SectorHPvisualisation : MonoBehaviour
{
    public TextMeshPro text;
    public int HP;
    GameObject parent;
    

    private void Start ()
    {
        text.text = GetComponentInParent<BadSector>().BadSectorHP.ToString();
    }

    public void UpdateVisualisation()
    {
        text.text = HP.ToString();
    }
}
