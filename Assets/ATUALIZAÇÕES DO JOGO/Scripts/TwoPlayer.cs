using UnityEngine;

public class TwoPlayer : MonoBehaviour
{
    public float movSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float speedX = 0f;
        float speedY = 0f;

        if (Input.GetKey(KeyCode.RightArrow)) speedX = movSpeed;
        if (Input.GetKey(KeyCode.LeftArrow)) speedX = -movSpeed;
        if (Input.GetKey(KeyCode.UpArrow)) speedY = movSpeed;
        if (Input.GetKey(KeyCode.DownArrow)) speedY = -movSpeed;

        rb.linearVelocity = new Vector2(speedX, speedY);
    }

}
