using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour {

    public GameObject badBlock;
    public GameObject goodBlock;
    public GameObject player;
    public Text gameOverText;
    public Text restart;
    public int score = 0;
    public int minx = 0;
    public int maxx = 0;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBlock", 0.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
	}

    public void SpawnBlock()
    {
        float multiplyer;
        multiplyer = (float)score * 0.5f;
        int i = 0;
        Vector3 position = new Vector3(0, 50, 0);
        while (i < (multiplyer + 5f))
        {
            int x = Random.Range(minx, maxx);
            int y = Random.Range(0, 2);
            Debug.Log(y);
            position = new Vector3(x, (50 + Random.Range(-5, 5)), 0);
            if (y == 0)
            {
               GameObject newBlock = Instantiate(goodBlock, position, Quaternion.identity);
                newBlock.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.3f, 0.6f);
            }
            else
            {
                GameObject newBlock = Instantiate(badBlock, position, Quaternion.identity);
                newBlock.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.3f, 0.6f);
            }
            i += 1;
        }
    }
    public void GameOver()
    {
        CancelInvoke();
        Destroy(player);
        gameOverText.text = "GameOver";
        restart.text = "Press r to restart";
    }
}
