using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardAnimation : MonoBehaviour
{

    private Camera _camera;
    private bool _clicked;

    void Start()
    {
        _clicked = false;
        _camera = Camera.main;
    }

    private void OnMouseOver()
    {

        transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 0.5f);

        if (Input.GetMouseButtonDown(0) && !_clicked)
        {

            _clicked = true;
            transform.DORotate(new Vector3(0f, 0f, 0f), 1f).OnComplete(() => _camera.DOShakePosition(1f));

        }

    }

    private void OnMouseExit()
    {

        transform.DOScale(new Vector3(1f, 1f, 1f), 0.5f);

    }

}
