using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeration : MonoBehaviour
{
    private void Start()
    {
        _upVector = Vector3.up;
        _rightVector = Vector3.right;
    }
    enum Direction
    {
        Left,
        Right,
        Up,
        Down
    };
    [SerializeField] private Direction _currentDirection;
    [SerializeField] private Rigidbody _rigidBody;
    private Vector3 _upVector;
    private Vector3 _rightVector;
    private float _speed = 5f;
    public void SelectDirection()
    {
        switch (_currentDirection)
        {
            case Direction.Left:
                _rigidBody.velocity = -_rightVector * _speed;
                break;
            case Direction.Right:
                _rigidBody.velocity = _rightVector * _speed;
                break;
            case Direction.Up:
                _rigidBody.velocity = _upVector * _speed;
                break;
            case Direction.Down:
                _rigidBody.velocity = -_upVector * _speed;
                break;
            default:
                break;
        }
    }
}
