using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class BirdFlyingManager : MonoBehaviour
{
   [SerializeField] Rigidbody2D body;
   [SerializeField] int flapforse=35;
   float forceConstant=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bird has been created");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity=new Vector2(body.velocity.x,0);
            body.AddForce(Vector2.up*flapforse*forceConstant,ForceMode2D.Impulse);
            
        }
        float tilAngel=Mathf.Lerp(-30,45,(body.velocity.y+10)/20);
        body.transform.rotation= Quaternion.Euler(0,0,tilAngel);
    }
}
