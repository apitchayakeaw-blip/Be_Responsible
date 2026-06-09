using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 5f;
    Rigidbody2D rb;
    LineRenderer lr;

    Vector2 DragStartPos;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lr = GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DragStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {

        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 DragEndPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 velocity = (DragEndPos - DragStartPos) * power;

            rb.linearVelocity = velocity;
        }

        
    }
}
