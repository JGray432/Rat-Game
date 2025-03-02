using UnityEngine;

public class RatScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public int jump_speed = 5;
    public decimal walk_speed = 0.5M;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Ratthew";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.MovePosition(myRigidbody.position + Vector2.right);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.MovePosition(myRigidbody.position + Vector2.left);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myRigidbody.linearVelocity = Vector2.up * jump_speed;
        }
    }
}
