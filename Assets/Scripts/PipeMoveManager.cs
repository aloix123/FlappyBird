using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveManager : MonoBehaviour

{
    [SerializeField] int speed=80;
    int directon=-1;
    Vector2 vector=new Vector2(0.001f,0);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("pipe has ben created");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(vector*speed*directon);
    }
}
