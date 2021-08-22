using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] GameObject soundPannel;
    GameManager game;
    Button soundButton;
    // Start is called before the first frame update
    void Start()
    {
        soundButton = GetComponent<Button>();
        soundButton.onClick.AddListener(OpenPannel);
        game = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void OpenPannel()
    {
        soundPannel.SetActive(true);
        gameObject.SetActive(false);
    }
}
