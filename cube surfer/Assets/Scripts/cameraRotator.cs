using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraRotator : MonoBehaviour
{

    [SerializeField] private Transform target;
    private bool isTurnRight, isTurnLeft;
    [SerializeField] private cubeCollecter cC;



    private void Start()
    {
        isTurnRight = false;
        isTurnLeft = false;
        target = GameObject.FindWithTag("cubeCollecter").transform;
        
    }


    void LateUpdate()
    {
        Vector3 tarPos = target.position;
        gameObject.transform.DOMove(tarPos, .1f, false);       


    }

    void Update()
    {
       

        if (isTurnRight == true)
        {
            gameObject.transform.DORotate(new Vector3(0, 90, 0), 1, RotateMode.Fast);
            isTurnRight = false;
        }

        if (isTurnLeft == true)
        {
            gameObject.transform.DORotate(new Vector3(0, -90, 0), 1, RotateMode.Fast);
            isTurnLeft = false;
        }
    }

    public void SetRotateRight()
    {
        isTurnRight = true;
    }
    public void SetRotateLeft()
    {
        isTurnLeft = true;
    }

   
}
