using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsController : MonoBehaviour
{
    [SerializeField] private GameObject playerBall;

    [HideInInspector] 
    public GameObject actualBall;

    private void Start()
    {
       actualBall = Instantiate(playerBall, transform.position, Quaternion.identity, transform);
    }

    private void NextBall()
    {
        actualBall = Instantiate(playerBall, transform.position, Quaternion.identity, transform);
    }
}
