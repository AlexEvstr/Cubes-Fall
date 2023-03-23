using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _xBorder = 1.75f;
    private float _speed = 4.0f;
    private bool _direction;

    private void Start()
    {
        StartCoroutine(Mover());
    }

    private IEnumerator Mover()
    {
        while(true)
        {
            MovePlayer();
            yield return new WaitForSeconds(0);
        }

    }

    private void MovePlayer()
    {
        if (_direction && transform.position.x > -_xBorder)
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        else if (transform.position.x < _xBorder)
            transform.Translate(Vector2.right * _speed * Time.deltaTime);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        _direction = !_direction;
    }
}
