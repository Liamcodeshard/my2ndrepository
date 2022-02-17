using UnityEngine;

public class PlayerPaddle : Piddle
{
    private Vector2 _direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            _direction = Vector2.down;
        } else {
            _direction = Vector2.zero;
        }

        Debug.Log("working fine mate");
     }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        _rigidbody.AddForce(_direction * this.speed);
    }


}


