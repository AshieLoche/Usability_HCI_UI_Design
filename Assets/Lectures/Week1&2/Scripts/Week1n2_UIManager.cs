using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week1n2_UIManager : MonoBehaviour
{

    [SerializeField] private GameObject _targetObject;
    [SerializeField] private float _maxSize, _defaultSize;
    [SerializeField] private float _animationTime;

    public void IncreaseSize()
    {
        _targetObject.transform.DOScale(_maxSize, _animationTime);
    }

    public void DecreaseSize()
    {
        _targetObject.transform.DOScale(_defaultSize, _animationTime);
    }

    public void SetTartgetObject(GameObject targetObject)
    {
        _targetObject = targetObject;
    }

}
