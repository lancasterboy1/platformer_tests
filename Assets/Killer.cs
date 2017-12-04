using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour {
    public GameObject player;
    public GameManager gm;
	void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag != "Boundry")
        {
            Destroy(other.gameObject);
            if (this.gameObject == player)
            {
                Debug.Log("collision");
                if (other.gameObject.tag == "Bad")
                {
                    gm.GameOver();
                }
                else
                {
                    gm.score += 1;
                }
            }
        }
    }
}
