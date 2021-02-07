using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    int i =0 ;
    int indexCurrent =0 ;
    public GameObject point;
    public List<Sequence> listOfSequence=  new List<Sequence>();
    public List<Vector3> vector3List= new List<Vector3>();
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Awake()
    { 
        
    }


    void Start()
    {
        //vector3List.Add(transform.position);
        agent = GetComponent<NavMeshAgent>();
        foreach(Vector3 v in vector3List)
        {
            Instantiate(point,v,transform.rotation);
        }
        vector3List.Add(vector3List[0]);
        transform.position = vector3List[0];

    }

    void Update()
    {
        if(vector3List.Count > 0)
       { 
           if(Vector3.Distance(vector3List[0],transform.position)>0.2f)
            {
                agent.SetDestination(vector3List[0]);
            }
            else
            {
                vector3List.RemoveAt(0);
            }
        }

    }


    public void Move( float  distance)
    {
        i++;
        Vector3 currentPoint = transform.position; 
        Vector3  targetPoint = transform.forward * distance; 
        Sequence temp = new Sequence(currentPoint,targetPoint,i);
        listOfSequence.Add(temp);
        vector3List.Add(targetPoint);
         
    }

    public void Turn(float angle)
    {
        transform.Rotate(0,angle,0);
    }

    public void TurnLeft()
    {
        Turn(-90);
    }

    public void  TurnRight()
    {
        Turn(90);
    }
}


public class Sequence{
    Vector3 currentPoint;
    Vector3 targetPoint;
    int num;

    public Sequence(Vector3 _c ,Vector3 _t, int _n = 1)
    {
        currentPoint = _c;
        targetPoint = _t;
        num = _n;
    }
}