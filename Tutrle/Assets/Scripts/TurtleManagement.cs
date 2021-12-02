using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleManagement : MonoBehaviour
{ 
    #region DoNotTouch
    Movement Turtle; 
    public void FindTurtle()
    {
        Turtle = GameObject.FindObjectOfType<Movement>(); 
    }

    #endregion
     void Awake()
     {
        FindTurtle();
        //put your code  for Turtle  bellow :   
        int i = 0;
        while(i<=4)
        { 
            Turtle.Move(10);
            Turtle.Turn(90);
            i++;
        }
    }
}
