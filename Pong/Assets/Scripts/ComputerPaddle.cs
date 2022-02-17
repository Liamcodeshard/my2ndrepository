using UnityEngine;

public class ComputerPaddle : Piddle
{
    public Rigidbody2D follow;

    private void FixedUpdate()
    {
        if (this.follow.velocity.x > 0.0f)
        {
            if (this.follow.position.y > this.transform.position.y) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this.follow.position.y < this.transform.position.y) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }


}
