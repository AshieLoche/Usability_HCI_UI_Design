using DG.Tweening;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;

public class Week3_UIManager : MonoBehaviour
{

    [Header("Gameobject Components")]
    [SerializeField] private Transform _chandelure;
    [SerializeField] private Transform _magnezone;

    [Header("Animation")]
    [SerializeField] private Ease _animationEasing;

    [Header("Chandelure Animation")]
    [Header("Wind Up Animation")]
    [SerializeField] private Vector3 _windUpRotation;
    [SerializeField] private float _windUpRotationTime;

    [Header("Wind Up Attack Animation")]
    [SerializeField] private Vector3 _windUpAttackRotation;
    [SerializeField] private float _windUpAttackRotationTime;

    [Header("Attack Rotation Animation")]
    [SerializeField] private Vector3 _attackRotation;
    [SerializeField] private float _attackRotationTime;

    [Header("Attack Move Animation")]
    [SerializeField] private Vector3 _attackMovePosition;
    [SerializeField] private float _attackMoveTime;

    [Header("Return Animation")]
    [SerializeField] private Vector3 _returnPosition;
    [SerializeField] private Vector3 _returnRotation;
    [SerializeField] private float _returnTime;

    [Header("Magnezone Animation")]
    [Header("Color Animation")]
    [SerializeField] Image _magnezoneImage;

    [Header("Damage Color Animation")]
    [SerializeField] Color _damageColor;
    [SerializeField] float _damageColorTime;

    [Header("Return Color Animation")]
    [SerializeField] Color _returnColor;
    [SerializeField] float _returnColorTime;

    [Header("Shake Animation")]
    [SerializeField] private float _shakeTime;
    [SerializeField] private float _shakeStrength;
    [SerializeField] private int _shakeVibrato;
    [SerializeField] private float _shakeRandomness;

    [Header("Scale Down Animation")]
    [SerializeField] private Vector3 _scaleDownSize;
    [SerializeField] private float _scaleDownTime;

    [Header("Fade Animation")]
    [SerializeField] private float _fadeAmount;
    [SerializeField] private float _fadeTime;

    [Header("Reset")]
    [Header("Magnezone Reset")]
    [SerializeField] private Vector3 _originalScale;
    [SerializeField] private float _originalFadeAmount;

    private void Start()
    {
        _returnPosition = transform.right * _chandelure.localPosition.x;
        _returnRotation = transform.right * _chandelure.localRotation.z;

        _magnezoneImage = _magnezone.GetComponent<Image>();

        _originalScale = _magnezone.localScale;
        _originalFadeAmount = 1f;
    }

    [Button]
    public void Attack()
    {
        Sequence attackSequence = DOTween.Sequence();

        attackSequence.Append(WindUpRotation());
        attackSequence.Append(WindUpAttackRotation());

        attackSequence.Append(AttackRotation());
        attackSequence.Join(AttackMove());

        attackSequence.Append(ReturnMove());
        attackSequence.Join(ReturnRotation());
        attackSequence.JoinCallback(Shake());
        attackSequence.JoinCallback(DamageColor());
        attackSequence.AppendCallback(ReturnColor());
        attackSequence.AppendCallback(ScaleDown());
        attackSequence.JoinCallback(Fade());

    }

    [Button]
    public void Reset()
    {
        _magnezone.localScale = _originalScale;
        Color _magnezoneColor = _magnezoneImage.color;
        _magnezoneColor.a = _originalFadeAmount;
        _magnezoneImage.color = _magnezoneColor;
    }

    private Tween WindUpRotation()
    {
        return _chandelure.DOLocalRotate(_windUpRotation, _windUpRotationTime);
    }

    private Tween WindUpAttackRotation()
    {
        return _chandelure.DOLocalRotate(_windUpAttackRotation, _windUpAttackRotationTime);
    }

    private Tween AttackRotation()
    {
        return _chandelure.DOLocalRotate(_attackRotation, _attackRotationTime);
    }

    private Tween AttackMove()
    {
        return _chandelure.DOLocalMove(_attackMovePosition, _attackMoveTime);
    }

    private Tween ReturnMove()
    {
        return _chandelure.DOLocalMove(_returnPosition, _returnTime);
    }

    private Tween ReturnRotation()
    {
        return _chandelure.DOLocalRotate(_returnRotation, _returnTime);
    }

    private TweenCallback Shake()
    {
        return () => _magnezone.DOShakePosition(_shakeTime, _shakeStrength, _shakeVibrato, _shakeRandomness);
    }

    private TweenCallback DamageColor()
    {
        return () => _magnezoneImage.DOColor(_damageColor, _damageColorTime);
    }

    private TweenCallback ReturnColor()
    {
        return () => _magnezoneImage.DOColor(_returnColor, _returnColorTime);
    }

    private TweenCallback ScaleDown()
    {
        return () => _magnezone.DOScale(_scaleDownSize, _scaleDownTime);
    }

    private TweenCallback Fade()
    {
        return () => _magnezoneImage.DOFade(_fadeAmount, _fadeTime);
    }

}
