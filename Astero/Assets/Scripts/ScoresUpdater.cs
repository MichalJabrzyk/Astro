using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoresUpdater : MonoBehaviour
{
    public GameObject gameManager;
    public TextMeshProUGUI textMesh;
    public int scores;


    void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
       // if (gameManager != null)
       //{
       //      gameManager = GameObject.FindGameObjectWithTag("GameManager"); 
        
       // }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        scores = 0;
    }

    // Update is called once per frame
    void Update()
    {

        textMesh.text = scores.ToString();

    }

    public void AddPoint()
    {
        scores++;
    }

    public void RestetPoints()
    {
        scores = 0;
    }
}
