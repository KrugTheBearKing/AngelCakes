using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent (typeof(CircleCollider2D))]
public class PlayerController : MonoBehaviour
{
    public float Speed = 10.0f;
    private Rigidbody2D _rigidBody;

    // Start is called before the first frame update
    public void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        //Get the new position of our character
        var x = transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        var y = transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        _rigidBody.MovePosition(new Vector2(x, y));
    }
}
