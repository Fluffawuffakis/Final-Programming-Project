using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody playerRb;
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();

        MoveVertical();
       
    }

    void MoveHorizontal()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(player.transform.right * horizontalInput * speed);
    }

    void MoveVertical()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(forwardInput * speed * player.transform.forward);
    }
}
