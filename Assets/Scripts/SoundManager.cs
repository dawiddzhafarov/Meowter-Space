using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

	[SerializeField] private Button musicOn;
	[SerializeField] private Button musicOff;
	[SerializeField] private Button soundOn;
	[SerializeField] private Button soundOff;
	private bool mutedMusic = false;
	private bool mutedSound = false;

	// Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnButtonPress()
    {
	    if (mutedMusic == false)
	    {
		    mutedMusic = true;
		    AudioListener.pause = true;
	    }
	    else
	    {
		    mutedMusic = false;
		    AudioListener.pause = false;
	    }
	    
	    if (mutedSound == false)
	    {
		    mutedSound = true;
		    AudioListener.pause = true;
	    }
	    else
	    {
		    mutedSound= false;
		    AudioListener.pause = false;
	    }
    }
   
}
