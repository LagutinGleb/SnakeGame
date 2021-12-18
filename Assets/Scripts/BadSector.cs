using UnityEngine;

public class BadSector : MonoBehaviour
{
    public int BadSectorHP;
    private SectorHPvisualisation child;

    private void Start()
    {
        child = GetComponentInChildren<SectorHPvisualisation>();
        child.HP = BadSectorHP;
    }

    public void UpdateBadSectorHP()
    {
        child.HP = BadSectorHP;
        child.UpdateVisualisation();
    }
}
