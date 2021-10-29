using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotation : MonoBehaviour
{

    public GameObject parent;
    public float randomMoveX;
    public float randomMoveY;
    public float randomMove = 0.25f;
    public float randomeRotation = 0.1f;
    public Vector3 rotation;
    public Vector2 move;
    public float moveSpeed = 1f;
   
    // Start is called before the first frame update
    void Start()
    {
        //Randome rotation and move
        randomeRotation = Random.Range(-randomeRotation, randomeRotation);
        randomMoveX = Random.Range(-randomMove, randomMove);
        randomMoveY = Random.Range(-randomMove, randomMove);
        move = new Vector2(randomMoveX, randomMoveY);
        rotation = new Vector3(0, 0, randomeRotation);
    }

    // Update is called once per frame
    void Update()
    {
        //Parent object Move
        parent.transform.Translate(move * moveSpeed * Time.deltaTime);
        //Parent object local rotation
        transform.Rotate(0.0f, 0.0f, randomeRotation);


    }
}
