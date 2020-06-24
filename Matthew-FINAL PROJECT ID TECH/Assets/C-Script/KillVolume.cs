using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{
    
    public GameObject losePanel;
    
    // Start is called before the first frame update
    void Start()
    {
        losePanel.gameObject.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            displayLosePanel();
            Debug.Log("Hello");
        }

    }
    public void displayLosePanel()
    {
        losePanel.gameObject.SetActive(true);
    } 
}


