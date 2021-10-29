using System.Collections;
using System.Collections.Generic;
using UnityEngine;


     public class Activation : MonoBehaviour
        {
          public bool disabled;
          public GameObject child;
   
         // Start is called before the first frame update
          void Start()
          {
        
          }

          //When Object starts collide
          void OnTriggerEnter2D(Collider2D colliderE)
          {

             if (colliderE.gameObject)
             {
                  
                  disabled = false;
                  //Debug.Log("Enter = "+disabled);
                  child.SetActive(true); 
            
             }
 
          }

         // When object stay in collision
          void OnTriggerStay2D(Collider2D colliderS)
          {

             if (colliderS.gameObject)
             {
            
                 disabled = false;
                 //Debug.Log("Stay = "+disabled);
                 //if(gameObject ?? false) {child.SetActive(true); }
            

             }

          }

          //On stop colliding
          void OnTriggerExit2D(Collider2D colliderEx)
          {
        
            if (colliderEx.gameObject)
            {
            
                   disabled = true;
                  //Debug.Log("Exit = "+disabled);
                   child.SetActive(false);

            }
           
          }

          // On awake
          void Awake()
          {

          }

          // Update is called once per frame
          void Update()
          {

          }

     } 


