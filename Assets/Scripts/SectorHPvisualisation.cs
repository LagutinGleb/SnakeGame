using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SectorHPvisualisation : MonoBehaviour
{
    public TextMeshPro text;
    public int HP;


    private void Update()
    {
        text.text = HP.ToString();
    }

}
