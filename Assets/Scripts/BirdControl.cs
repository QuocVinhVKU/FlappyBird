using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //khi nhayr -> chim fly
        //truyeenf 1 vector vận tốc hướng đi lên
        //xác định khi bấm vào màn hình bằng chuột or phím

        bool isTap = Input.GetKeyDown(KeyCode.Space);
        if (isTap)
        {
            Jump();
        }
    }
    protected void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    public void MovePos(Vector3 step)
    {
        float speed = 3;
        transform.position += speed * step * Time.deltaTime;
    }
}
