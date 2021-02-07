using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    public Rigidbody Rb;
    public float JumpForce;
    private bool _canJump = false;
    private float _distToGround;
    public Collider Coll;

    public int Health;
    public int CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        _distToGround = Coll.bounds.extents.y;
        Health = 3;
        CurrentHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, Rb.velocity.y, Rb.velocity.z);
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Rb.velocity = new Vector3(Rb.velocity.x, JumpForce, Rb.velocity.z);
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, _distToGround + 0.1f);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Enemy" && CurrentHealth >= 1)
        {
            CurrentHealth -= 1;
        }

        if (coll.gameObject.tag == "Enemy" && CurrentHealth == 0)
        {
            Restart();
        }

        if (coll.gameObject.tag == "Finish")
        {
            Debug.Log("POBEDA");
        }
    }

    void Restart()
    {
        gameObject.transform.position = new Vector3(-16.45f, 0.48f, -0.2294f);
        CurrentHealth = 3;
    }
}
