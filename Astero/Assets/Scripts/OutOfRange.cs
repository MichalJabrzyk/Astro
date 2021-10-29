using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfRange : MonoBehaviour
{
    public GameObject player;
    public float outOfRange = 20f;
    public float dist;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void CalculateDist()
    {
        dist = Vector2.Distance(player.transform.position, gameObject.transform.position);
    }

    void Destruct()
    {
        if (dist > outOfRange) { Destroy(gameObject); }
        else if (dist < -outOfRange) { Destroy(gameObject); }
        else if (dist > outOfRange) { Destroy(gameObject); }
        else if (dist < -outOfRange) { Destroy(gameObject); }

    }
    
    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
           CalculateDist();
           Destruct();
        }
        
    }

}
