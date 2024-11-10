using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour
{
    private Rigidbody2D _componentRigibody2D;
    private float horizontal;
    private float vertical;
    public int playerSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        _componentRigibody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        _componentRigibody2D.velocity = new Vector2(horizontal*playerSpeed, vertical*playerSpeed);
    }
}
