using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
        public GameObject[] startToEnable;
        public GameObject[] startToDisable;
        
        public GameObject[] playToEnable;
        public GameObject[] playToDisable;

        public GameObject[] restartToEnable;
        public GameObject[] restartToDisable;

        public GameObject[] closeToEnable;
        public GameObject[] closeToDisable;
        
        public bool startModeActive;
        public bool playModeActive;
        public bool restartModeActive;
        public bool closeModeActive;

        private int numberStartToEnable;
        private int numberStartToDisable;
        
        private int numberPlayToEnable;
        private int numberPlayToDisable;
        
        private int numberRestartToEnable;
        private int numberRestartToDisable;
        
        private int numberCloseToEnable;
        private int numberCloseToDisable;
        
        // On awake
        void Awake()
        {
            numberStartToEnable = startToEnable.Length; 
            //Debug.Log("numberStartToEnable = " + numberStartToEnable);
            numberStartToDisable = startToDisable.Length;
            //Debug.Log("numberStartToDisable = " + numberStartToDisable);
          
            numberPlayToEnable = playToEnable.Length; 
            //Debug.Log("numberPlayToEnable = " + numberPlayToEnable);
            numberPlayToDisable = playToDisable.Length;
            //Debug.Log("numberPlayToDisable = " + numberPlayToDisable);
            
            numberRestartToEnable = restartToEnable.Length; 
            //Debug.Log("numberLoseToEnable = " + numberRestartToEnable);
            numberRestartToDisable = restartToDisable.Length;
            //Debug.Log("numberRestartToDisable = " + numberRestartToDisable);
            
            numberCloseToEnable = closeToEnable.Length; 
            //Debug.Log("numberCloseToEnable = " + numberCloseToEnable);
            numberCloseToDisable = closeToDisable.Length;
            //Debug.Log("numberCloseToDisable = " + numberCloseToDisable);
            
            
            startModeActive = false;
            playModeActive = false;
            restartModeActive = false;
            closeModeActive = false;
        }
    
        // Start is called before the first frame update
        void Start()
        {
            StartGame();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void StartGame()
        {

            if (numberStartToEnable > 0)
            {
                
                for (int a = 0; a < numberStartToEnable; a++)
                {
                    startToEnable[a].SetActive(true);
                    
                }
            }
            

            if (numberStartToDisable > 0)
            {
                for (int b = 0; b < numberStartToEnable; b++) 
                {
                    startToDisable[b].SetActive(false);
                                
                }
            }

            startModeActive = true;
            playModeActive = false;
            restartModeActive = false;
            closeModeActive = false;

        }
 
        public void PlayGame()
        {

            if (playToEnable != null)
            {
                
                for (int c = 0; c < numberPlayToEnable; c++)
                {
                    playToEnable[c].SetActive(true);

                }
            }
            

            if (playToDisable != null)
            {
                for (int d = 0; d < numberPlayToEnable; d++) 
                {
                    playToDisable[d].SetActive(false);
                                
                }
            }

            ResetScores();
            startModeActive = false;
            playModeActive = true;
            restartModeActive = false;
            closeModeActive = false;

        }
        
        public void RestartGame()
        {

            if (restartToEnable != null)
            {
                
                for (int e = 0; e < numberRestartToEnable; e++)
                {
                    restartToEnable[e].SetActive(true);

                }
            }
            

            if (restartToDisable != null)
            {
                for (int f = 0; f < numberRestartToDisable; f++) 
                {
                    restartToDisable[f].SetActive(false);
                                
                }
            }
            
            startModeActive = false;
            playModeActive = false;
            restartModeActive = true;
            closeModeActive = false;
            
        }
        
        public void CloseGame()
        {

            if (closeToEnable != null)
            {
                
                for (int g = 0; g < numberCloseToEnable; g++)
                {
                    closeToEnable[g].SetActive(true);

                }
            }
            

            if (closeToDisable != null)
            {
                for (int h = 0; h < numberCloseToEnable; h++) 
                {
                    closeToDisable[h].SetActive(false);
                                
                }
            }

            startModeActive = false;
            playModeActive = false;
            restartModeActive = false;
            closeModeActive = true;

        }

        void ResetScores()
        {
            FindObjectOfType<ScoresUpdater>().RestetPoints();
        }

    }
