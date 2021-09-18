using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void onMove(InputValue momentValue)
    {
        Vector2 movementVector = momentValue.Get<Vector2>();

    }

    void FixedUpdate()
    {
            
    }
}
