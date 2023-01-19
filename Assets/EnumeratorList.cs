using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorList : MonoBehaviour
{
    [SerializeField] private List<fruit> _fruitoList;
    private int _countApple;
    private int _countCherry;
    private int _countPear;
    enum fruit
    {
        Cherry,
        Apple,
        Pear
    };

    private void Start()
    {
        for (int i = 0; i < _fruitoList.Count; i++)
        {
            if (_fruitoList[i] == fruit.Apple)
            {
                Debug.Log(_fruitoList.Count);
            }
            else if (_fruitoList[i] == fruit.Cherry)
            {
                Debug.Log(_fruitoList.Count);
            }
            else if (_fruitoList[i] == fruit.Pear)
            {
                Debug.Log(_fruitoList.Count);
            }
        }
    }
}
