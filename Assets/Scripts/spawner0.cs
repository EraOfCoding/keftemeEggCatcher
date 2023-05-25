using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner0 : MonoBehaviour
{
    public GameObject egg;
    public static float spawnRate = 10f;
    public static float timer = 0;
    public static float timerAll = 0;
    public UnityEngine.UI.Text difficulty;
    // Start is called before the first frame update
    void Start()
    {
        difficulty.text = "Difficulty: 1 / 5";
        
    }

    // Update is called once per frame
    void Update()
    {
        timerAll += Time.deltaTime;
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else if(player.ded) {
            //salam developer
        }
        else {
            timer = 0;
            Debug.Log(spawnRate);
            Instantiate(egg, transform.position, transform.rotation);
        }

        if(timerAll > 30) {
            difficulty.text = "Difficulty: 2 / 5";
            spawnRate = 3f;
        }
        else if (timerAll > 60) {
            difficulty.text = "Difficulty: 3 / 5";
            spawnRate = 2f;
        }
        else if(timerAll > 120) {
            spawnRate = 1f;
            difficulty.text = "Difficulty: 4 / 5";
        }
    }
}
