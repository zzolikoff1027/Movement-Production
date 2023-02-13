using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Behaviour : Kinematic
{
    Arrive myMoveType;
    Align myRotateType;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Arrive();
        myMoveType.character = this;
        myMoveType.target = GameObject.Find("Player");

        myRotateType = new Align();
        myRotateType.character = this;
        myRotateType.target = GameObject.Find("Player");
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
