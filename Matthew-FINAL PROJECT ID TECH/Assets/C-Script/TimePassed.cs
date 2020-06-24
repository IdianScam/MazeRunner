using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePassed : MonoBehaviour
{
    private float spawnTimer = 10.0f;
    public Text time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        //Debug.Log(Mathf.Floor(spawnTimer));
        //if (spawnTimer > 1)
        //{Debug.Log("One Second Passed");
        //spawnTimer = 0; }
        time.text = "Time: " + Mathf.Floor(spawnTimer).ToString();

        

    }
}
