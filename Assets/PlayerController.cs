using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float ZSpeed = zInput * speed;

        Vector3 newV = new Vector3(xSpeed, 0f, ZSpeed);

        playerRigidbody.velocity = newV;
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
