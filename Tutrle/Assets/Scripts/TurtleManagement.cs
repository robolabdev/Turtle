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
        Turtle.Turn(0);
        Turtle.Move(0);
    }

    #endregion
     void Awake()
     {
        FindTurtle();
        //put your code  for Turtle  bellow :   
        Turtle.Turn(0);
        Turtle.Move(10); 
    }
}
