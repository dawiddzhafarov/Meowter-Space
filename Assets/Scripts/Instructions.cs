using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject MenuCanvas;
    public bool isSwitchedOn;
    public GameObject InstructionsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        InstructionsCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideInstructions()
    {
        MenuCanvas.SetActive(true);
        InstructionsCanvas.SetActive(false);
        //Time.timeScale = 1f;
        isSwitchedOn = false;
    }

    public void ShowInstructions()
    {
        MenuCanvas.SetActive(false);
        InstructionsCanvas.SetActive(true);
        //Time.timeScale = 0f;
        isSwitchedOn = true;
    }
}
