using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeGeneratorFile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]   GameObject pipes;
    
    float TimeBetweenPipes=2.3f;
    float timer=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer>TimeBetweenPipes)
        {
            float randomheight=Random.Range(-1.1f,2.76f);
            Vector3 spanwpos=new Vector3(transform.position.x+2.2f, randomheight,transform.position.z);
            GameObject newpipe=Instantiate(pipes,spanwpos,Quaternion.identity);
            timer=0;
        }
             
        
        
        
        
    }
}
