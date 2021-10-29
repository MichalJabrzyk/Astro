using System.Collections;
using System.Collections.Generic;
using UnityEngine;

      public class AsteroidsCollisions : MonoBehaviour
      {
           public GameObject gameManager;
           public GameObject player;
           public GameObject parent;
           public GameObject destruction;
           
           public float spawnPosX = 100f;
           public float spawnPosY = 100f;
           public GameObject asteroidPrefab;

          void OnTriggerEnter2D(Collider2D collision)
          {
               if (collision.gameObject.tag.Equals("Bullet") || collision.gameObject.tag.Equals("Player"))
               {
                    Instantiate(destruction, transform.position, Quaternion.identity);
                    SpawnAgain();
                    Destroy(parent);
                    AddPoint();
               }
          }
          
          void Awake()
          {
               if (player == null)
               {
                    player = GameObject.FindGameObjectWithTag("Player");
               }

               if (gameManager == null)
               {
                    gameManager = GameObject.FindGameObjectWithTag("GameManager");
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

          void SpawnAgain()
          {

                  Vector2 spawnPos = new Vector2(Random.Range(-spawnPosX, spawnPosX), Random.Range(-spawnPosY, spawnPosY));
                  Instantiate(asteroidPrefab, spawnPos, asteroidPrefab.transform.rotation);
                  asteroidPrefab.tag = "Asteroid";

          }

          void AddPoint()
          {
               
               FindObjectOfType<ScoresUpdater>().AddPoint();
               
          }

      }



