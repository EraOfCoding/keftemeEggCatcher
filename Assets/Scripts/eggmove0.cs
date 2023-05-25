using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class eggmove0 : MonoBehaviour
{
    // public Vector3[] eggPosition = { new Vector3(2.15f, 0.35f, 0f), new Vector3(1.95f, 0.26f, 0f), new Vector3(1.79f, 0.18f, 0f), new Vector3(1.66f, 0.09f, 0f) };
    // public Quaternion[] rotationsArray = { Quaternion.identity, Quaternion.Euler(0f, 0f, 90f), Quaternion.Euler(0f, 0f, 150f), Quaternion.Euler(0f, 0f, 240f), Quaternion.Euler(0f, 0f, -30f)  };
    private float timer = 0;
    private float iterTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < 5) {
            timer += Time.deltaTime;
        }
        if(timer > iterTime - 0.1f && timer < iterTime + 0.1f) { // 1
            transform.position = new Vector3(2.13f, 0.35f, 0f);
            transform.rotation = Quaternion.Euler(0f, 0f, 70f);
        }
        if(timer > 2 * iterTime - 0.1f && timer < 2 * iterTime + 0.1f) { // 2
            transform.position = new Vector3(1.95f, 0.26f, 0f);
            transform.rotation = Quaternion.Euler(0f, 0f, 150f);

        } 
        if(timer > 3 * iterTime - 0.1f && timer < 3 * iterTime + 0.1f) { // 3
            transform.position = new Vector3(1.79f, 0.18f, 0f);
            transform.rotation = Quaternion.Euler(0f, 0f, 240f);

        }
        if(timer > 4 * iterTime - 0.1f && timer < 4 * iterTime + 0.1f) { // 4
            transform.position = new Vector3(1.66f, 0.07f, 0f);
            transform.rotation = Quaternion.Euler(0f, 0f, -30f);

        }
        if(timer > 5 * iterTime) { // 5
            Destroy(gameObject);
            if(player.state == 0) {
                player.score += 1;
            }
            else {
                player.fails += 1;   
            }
        }
    }
}
