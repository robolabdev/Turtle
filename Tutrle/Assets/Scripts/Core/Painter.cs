using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Painter : MonoBehaviour
{
    public bool canBrush = false;
 
    public void Brush()
    {
        if(canBrush)
            Instantiate(brushObject, transform.position,transform.rotation);
           
        
    }
      
    void Start()
    {
        
    }
    public GameObject brushObject;
     public float interval = 0.5f;
     public float timer = 0 ;

     void Update()
     {
         timer += Time.deltaTime;
         if(timer>interval)
         {
             Brush();
             timer =0;
         }

         if(GetComponent<NavMeshAgent>().velocity.magnitude>0)
         {
             canBrush = true;
         }
         else
         {
             canBrush = false;
         }
     }
}
