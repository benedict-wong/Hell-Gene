using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour {
	public Slider volumeSlider;
    // Start is called before the first frame update
    void Start() {
	    volumeSlider.maxValue = 0.35f;
        PlayerPrefs.SetFloat("GameVolume", volumeSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
