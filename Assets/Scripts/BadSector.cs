using System;
using UnityEngine;

public class BadSector : MonoBehaviour
{
    public int BadSectorHP;
    private SectorHPvisualisation child;
    public  Material material;


    private void Start()
    {
        child = GetComponentInChildren<SectorHPvisualisation>();
        child.HP = BadSectorHP;
        SetColour();
    }


    public void UpdateBadSectorHP()
    {
        child.HP = BadSectorHP;
        child.UpdateVisualisation();
    }

    private void SetColour()
    { 
         material.color = new Color(100,100,100);
    }

}
