using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (coll.tag == "P layer")
        {
            Destroy(player.gameObject);
        }
    }

}
