using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HalfDonut : MonoBehaviour
{
    public Transform movingStick;
    public float offsetX = 10f;
    public float moveTime = 3f;

    void Start()
    {

        movingStick.DOMoveX(movingStick.position.x + offsetX, moveTime).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
    }

}

