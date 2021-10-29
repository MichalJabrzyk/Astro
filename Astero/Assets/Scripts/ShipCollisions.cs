using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ShipCollisions : MonoBehaviour
{

        public GameObject playerStatement;
        public GameObject gameManager;
        public GameObject destruction;  
        public float spawnPosX = 100f;
        public float spawnPosY = 100f;


        // When start collide 
        void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.gameObject.tag.Equals("Rock"))
            {

                Instantiate(destruction, transform.position, Quaternion.identity);
                playerStatement.SetActive(false);
                GRestart();
                
            }

        }
 
        //When awake
        void Awake()
        {
           // gameManager = GameObject.FindGameObjectWithTag("GameManager");
            if (gameManager == null)
            {
                gameManager = GameObject.FindGameObjectWithTag("GameManager");
                
            }

            if (playerStatement == null)
            {
                playerStatement = GameObject.FindGameObjectWithTag("PlayerStatement");
            }
            
        }
  
        // Start is called before the first frame update
        void Start()  
        {
             
           
        }
 
        // Update is called once per frame 
        void Update() 
        {

        }

        public void GRestart()
        {
            FindObjectOfType<GameManager>().RestartGame();
        }

}




