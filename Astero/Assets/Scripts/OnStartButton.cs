using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartButton : MonoBehaviour
{
    public GameObject ButtonPlay;
    public GameObject player;
    public bool isPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        
        player.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayed = true)
        {
            TurnOnGame();
        }
    }

    void TurnOnGame()
    {
        player.SetActive(true);
        ButtonPlay.SetActive(false);

    }


}
