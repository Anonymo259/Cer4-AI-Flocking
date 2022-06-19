using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public float speed = 2.0f;
    public static Vector2 playerPosition;    //Allows the code to be referenced



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = Vector2.zero;

        if (Input.GetAxis("Vertical") != 0)      //detects input of either up or down
        {
            velocity.y = Input.GetAxis("Vertical");
        }

        if (Input.GetAxis("Horizontal") != 0)      //detects input of either left or right
        {
            velocity.x = Input.GetAxis("Horizontal");
        }
        player.transform.position += (Vector3)velocity * speed * Time.deltaTime;     //telling the player to move

        playerPosition = player.transform.position;     //static updating the non-static player's position
    }


}
