using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMoveObject : MonoBehaviour
{
    [SerializeField] private BallsController ballsController;

    private GameObject actualBall;

    private void OnEnable()
    {
        ViewportDragInput.OnDragPointer += GetInput;
    }

    private void OnDisable()
    {
        ViewportDragInput.OnDragPointer -= GetInput;
    }

    private void GetInput(Vector2 delta, Vector2 finalPos)
    {
        SetRotation(finalPos.x);
        SetTension(finalPos.y);
    }

    private void SetRotation(float posX)
    {
        float correctPosX = (float)Math.Round(posX, 0);
        float correctRotate = 180 / correctPosX;
        var correctVector = new Quaternion(0, 0, correctRotate, 0);
        Debug.Log(correctVector);
        transform.localRotation = correctVector;
    }

    private void SetTension(float posY)
    {
        var correctPosY = Math.Round(posY, 0);
        //Debug.Log(correctPosY);
    }

}
