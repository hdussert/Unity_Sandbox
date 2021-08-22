using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    private Slider volumeSlider;
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
        volumeSlider.onValueChanged.AddListener(ChangeMusicVolume);
    }

    // Update is called once per frame
    void ChangeMusicVolume(float val)
    {
        music.volume = val;
    }
}
