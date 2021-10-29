using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowPlayer : MonoBehaviour
{

    public Vector3 cameraZOffset = new Vector3(0f, 0f, -10f);
   
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        FollowPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null) { FollowPlayer(); }
        
    }

    void FollowPlayer()
    {
        
        gameObject.transform.position = player.transform.position + cameraZOffset;

    }
}
