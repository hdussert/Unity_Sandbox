using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPannelCloseButton : MonoBehaviour
{
    [SerializeField] GameObject soundPannel;
    [SerializeField] GameObject soundButton;
    GameManager game;
    Button closeButton;
    // Start is called before the first frame update
    void Start()
    {
        closeButton = GetComponent<Button>();
        closeButton.onClick.AddListener(ClosePannel);
        game = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void ClosePannel()
    {
        soundPannel.SetActive(false);
        soundButton.SetActive(true);
    }
}