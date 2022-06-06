using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public GameObject MenuCanvas;
    public bool isSwitchedOn;
    public GameObject SettingsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        SettingsCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideSettings()
    {
        MenuCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
        isSwitchedOn = false;
    }

    public void ShowSettings()
    {
        MenuCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
        isSwitchedOn = true;
    }
}
