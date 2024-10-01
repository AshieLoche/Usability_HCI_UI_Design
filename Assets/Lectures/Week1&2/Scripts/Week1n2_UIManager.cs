using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week1n2_UIManager : MonoBehaviour
{

    [SerializeField] private GameObject targetObject;
    [SerializeField] private float maxSize, defaultSize;
    [SerializeField] private float animationTime;

    public void IncreaseSize()
    {
        targetObject.transform.DOScale(maxSize, animationTime);
    }

    public void DecreaseSize()
    {
        targetObject.transform.DOScale(defaultSize, animationTime);
    }

    public void SetTartgetObject(GameObject targetObject)
    {
        this.targetObject = targetObject;
    }

}
