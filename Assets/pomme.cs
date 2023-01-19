using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pomme : Fruits
{
    public override float GetEaten()
    {
        TasteSweet();
        CrunchNoise();
        return base.GetEaten();
    }
    public void CrunchNoise()
    {
        Debug.Log("Crunch");
    }
}
