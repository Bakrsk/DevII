using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private List<Fruits> _fruitList;
    [SerializeField] private float _vitamineCContent;

    public void EatAFruit()
    {
        _vitamineCContent += _fruitList[0].GetEaten();
        Destroy(_fruitList[0].gameObject);
        _fruitList.Remove(_fruitList[0]); 
    }
}

