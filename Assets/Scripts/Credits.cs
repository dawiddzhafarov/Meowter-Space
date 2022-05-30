using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject MenuCanvas;
    public bool isSwitchedOn;
    public GameObject CreditsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideCredits()
    {
        MenuCanvas.SetActive(true);
        CreditsCanvas.SetActive(false);
        isSwitchedOn = false;
    }

    public void ShowCredits()
    {
        MenuCanvas.SetActive(false);
        CreditsCanvas.SetActive(true);
        isSwitchedOn = true;
    }
}
