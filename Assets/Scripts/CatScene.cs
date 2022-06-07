using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CatScene : MonoBehaviour
{
    private VideoPlayer catScene;
    // Start is called before the first frame update
    void Start()
    {
        catScene = gameObject.GetComponent<VideoPlayer>();
        catScene.Prepare();
        catScene.Play();
        StartCoroutine(JakosŁadnie());
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(JakosŁadnie());
        print(catScene.isPlaying);
        if (Input.anyKey)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    
    IEnumerator JakosŁadnie()
    {
        yield return new WaitForSeconds(2f);
        if (!catScene.isPlaying)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
