using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IntroButtons : MonoBehaviour
{
    public GameObject IntroGameMenu;
    // Start is called before the first frame update
    void Start()
    {
        IntroGameMenu.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseMenu()
    {
        IntroGameMenu.SetActive(false);
    }
    public void OpenMenu()
    {
        IntroGameMenu.SetActive(true);
    }
}
