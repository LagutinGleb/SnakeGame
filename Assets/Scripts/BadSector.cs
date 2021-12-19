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
        SetColour();
    }

    private void SetColour()
    {

        Gradient g = new Gradient();
        GradientColorKey[] gck = new GradientColorKey[2];
        GradientAlphaKey[] gak = new GradientAlphaKey[2];
        gck[0].color = Color.red;
        gck[0].time = 1.0F;

        gck[1].color = Color.green;
        gck[1].time = -1.0F;

        gak[0].alpha = 0.0F;
        gak[0].time = 1.0F;

        gak[1].alpha = 0.0F;
        gak[1].time = -1.0F;

        g.SetKeys(gck, gak);

        // максимум 20
        // минимум 1
        // допустим 10

        gameObject.GetComponent<Renderer>().material.color = g.Evaluate(child.HP/20f);
        

    }

}
