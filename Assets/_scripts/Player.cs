using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    void Awake() 
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        rigidbody.linearVelocity = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) {
            rigidbody.linearVelocity = 3*Vector2.up;
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidbody.linearVelocity = 3*Vector2.down;
        }
        if (Input.GetKey(KeyCode.A)) {
            rigidbody.linearVelocity = 3*Vector2.left;
        }
        if (Input.GetKey(KeyCode.D)) {
            rigidbody.linearVelocity = 3*Vector2.right;
        }
    }

    
}

