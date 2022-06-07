using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
	
	private bool mutedMusic = false;
	//[SerializeField] private AudioSource music1;
	//[SerializeField] private AudioSource music2;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    public void Mute()
    {
	    if (!mutedMusic)
	    {
		    AudioListener.pause = true;
		    AudioListener.volume = 0;
		    mutedMusic = true;
	    }
	    else
	    {
		    AudioListener.pause = false;
		    AudioListener.volume = 1;
		    mutedMusic = false;
	    }
    }
   
}
