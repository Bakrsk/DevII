using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public float _vitamineCContentOfFruits;
    
    public virtual float GetEaten()
    {
        return _vitamineCContentOfFruits;
    }

    public void TasteSweet()
    {
        Debug.Log("Yummy");
    }
    public void TasteBitter()
    {
        Debug.Log("Yuck");
    }
}
