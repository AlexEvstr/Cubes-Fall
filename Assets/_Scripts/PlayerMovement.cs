using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _xBorder = 1.75f;
    private float _speed = 2.0f;
    private bool _direction;

    private void ChangeDirection()
    {
        _direction = !_direction;
    }

    private void MovePlayer()
    {
        if (_direction)
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        else
            transform.Translate(Vector2.right * -_speed * Time.deltaTime);
    }

    private void Update()
    {
        MovePlayer();

        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                                            || transform.position.x > _xBorder
                                            || transform.position.x < -_xBorder)
        {
            ChangeDirection();
        }
    }
}
