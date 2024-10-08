using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4_ChestAnimation : MonoBehaviour
{

    [SerializeField] private Transform _chestLid;

    private void Start()
    {
        _chestLid = transform.GetChild(0).GetChild(2);

        Sequence chestSequence = DOTween.Sequence();

        chestSequence.Append(transform.DOMoveZ(-7f, 1f));
        chestSequence.Join(transform.DORotate(Vector3.up * 360, 0.5f, RotateMode.FastBeyond360));

        chestSequence.Append(transform.DOMoveY(0.5f, 1f));
        chestSequence.Join(transform.DORotate(Vector3.up * 180f, 1f));

        chestSequence.Append(transform.DOShakePosition(1f, 2.5f, 3, 5f));
        chestSequence.Join(transform.DOScale(1.25f, 1f));

        chestSequence.Append(_chestLid.DOLocalRotate(transform.right * -120f, 1.5f));
        chestSequence.Join(transform.DOScale(1f, 1f));

    }

}
