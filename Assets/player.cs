using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 15f;
    public float mapwidth = 5f;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapwidth, mapwidth);
        rb.MovePosition(newPosition);

    }
    void OnCollisionEnter2D()
    {
        FindObjectOfType<GameEnd>().EndGame();
    }
}
