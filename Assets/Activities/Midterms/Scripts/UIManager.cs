using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
using DG.Tweening;

public class UIManager : MonoBehaviour
{

    #region Variables
    #region Chandelure Components
    [Header("Chandelure Components")]
    [SerializeField] private Transform _chandelure;
    [SerializeField] private Image _chandelureImage;
    #endregion

    #region Animation Components
    [Header("Animation Components")]
    [SerializeField] private bool _animate = false;
    private Sequence _sequence;
    #endregion

    #region Scale
    [Header("Scale")]
    [SerializeField] private Vector3 _originalScale;
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _originalScaleFade;
    [SerializeField] private float _targetScaleFade;
    [SerializeField] private float _scaleTime;
    #endregion

    #region Zoom
    [Header("Zoom")]
    [SerializeField] private Vector3 _originalZoomScale;
    [SerializeField] private Vector3 _targetZoomScale;
    [SerializeField] private float _zoomTime;
    #endregion

    #region Fade
    [Header("Fade")]
    [SerializeField] private float _originalFade;
    [SerializeField] private float _targetFade;
    [SerializeField] private float _fadeTime;
    #endregion

    #region Fade Up
    [Header("Fade Up")]
    [SerializeField] private float _originalFadeUpPosition;
    [SerializeField] private float _targetFadeUpPosition;
    [SerializeField] private float _originalFadeUp;
    [SerializeField] private float _targetFadeUp;
    [SerializeField] private float _fadeUpTime;
    #endregion

    #region Fade Down
    [Header("Fade Down")]
    [SerializeField] private float _originalFadeDownPosition;
    [SerializeField] private float _targetFadeDownPosition;
    [SerializeField] private float _originalFadeDown;
    [SerializeField] private float _targetFadeDown;
    [SerializeField] private float _fadeDownTime;
    #endregion

    #region Fade Left
    [Header("Fade Left")]
    [SerializeField] private float _originalFadeLeftPosition;
    [SerializeField] private float _targetFadeLeftPosition;
    [SerializeField] private float _originalFadeLeft;
    [SerializeField] private float _targetFadeLeft;
    [SerializeField] private float _fadeLeftTime;
    #endregion

    #region Fade Right
    [Header("Fade Right")]
    [SerializeField] private float _originalFadeRightPosition;
    [SerializeField] private float _targetFadeRightPosition;
    [SerializeField] private float _originalFadeRight;
    [SerializeField] private float _targetFadeRight;
    [SerializeField] private float _fadeRightTime;
    #endregion

    #region Horizontal Flip
    [Header("Horizontal Flip")]
    [SerializeField] private float _originalHorizontalFlipRotation;
    [SerializeField] private float _targetHorizontalFlipRotation;
    [SerializeField] private float _horizontalFlipTime;
    #endregion

    #region Vertical Flip
    [Header("Vertical Flip")]
    [SerializeField] private float _originalVerticalFlipRotation;
    [SerializeField] private float _targetVerticalFlipRotation;
    [SerializeField] private float _verticalFlipTime;
    #endregion

    #region Drop
    [Header("Drop")]
    [SerializeField] private Vector3 _originalDropScale;
    [SerializeField] private Vector3 _targetDropScale;
    [SerializeField] private float _dropTime;
    [SerializeField] private Vector3 _dropPunchScale;
    [SerializeField] private float _dropPunchScaleDuration;
    [SerializeField] private int _dropPunchScaleVibrato;
    #endregion

    #region Fly Left
    [Header("Fly Left")]
    [SerializeField] private float _originalFlyLeftPosition;
    [SerializeField] private float _targetFlyLeftPosition;
    [SerializeField] private float _flyLeftTime;
    [SerializeField] private float _flyLeftPunchPosition;
    [SerializeField] private float _flyLeftPunchPositionDuration;
    [SerializeField] private int _flyLeftPunchPositionVibrato;
    #endregion

    #region Fly Right
    [Header("Fly Right")]
    [SerializeField] private float _originalFlyRightPosition;
    [SerializeField] private float _targetFlyRightPosition;
    [SerializeField] private float _flyRightTime;
    [SerializeField] private float _flyRightPunchPosition;
    [SerializeField] private float _flyRightPunchPositionDuration;
    [SerializeField] private int _flyRightPunchPositionVibrato;
    #endregion

    #region Fly Down
    [Header("Fly Down")]
    [SerializeField] private float _originalFlyDownPosition;
    [SerializeField] private float _targetFlyDownPosition;
    [SerializeField] private float _flyDownTime;
    [SerializeField] private float _flyDownPunchPosition;
    [SerializeField] private float _flyDownPunchPositionDuration;
    [SerializeField] private int _flyDownPunchPositionVibrato;
    #endregion

    #region Fly Up
    [Header("Fly Up")]
    [SerializeField] private float _originalFlyUpPosition;
    [SerializeField] private float _targetFlyUpPosition;
    [SerializeField] private float _flyUpTime;
    [SerializeField] private float _flyUpPunchPosition;
    [SerializeField] private float _flyUpPunchPositionDuration;
    [SerializeField] private int _flyUpPunchPositionVibrato;
    #endregion
    #endregion

    #region Methods
    [Button]
    public void Scale()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;
        _chandelure.localPosition = Vector3.right * 330f;

        if (_animate)
        {
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            _sequence.Append(_chandelure.DOScale(_originalScale, _scaleTime));
            _sequence.Join(_chandelureImage.DOFade(_originalScaleFade, _scaleTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOScale(_targetScale, _scaleTime));
            _sequence.Join(_chandelureImage.DOFade(_targetScaleFade, _scaleTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void Zoom()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;
        _chandelure.localPosition = Vector3.right * 330f;

        if (_animate)
        {
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOScale(_originalZoomScale, _zoomTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOScale(_targetZoomScale, _zoomTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void Fade()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;
        _chandelure.localPosition = Vector3.right * 330f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            _sequence.Append(_chandelureImage.DOFade(_originalFade, _fadeTime));
        }
        else
        {
            _sequence.Append(_chandelureImage.DOFade(_targetFade, _fadeTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void FadeUp()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;

        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _targetFadeUp;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            _sequence.Append(_chandelureImage.DOFade(_originalFadeUp, _fadeUpTime));
            _sequence.Join(_chandelure.DOLocalMoveY(_originalFadeUpPosition, _fadeUpTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _originalFadeUp;

            _sequence.Append(_chandelureImage.DOFade(_targetFadeUp, _fadeUpTime));
            _sequence.Join(_chandelure.DOLocalMoveY(_targetFadeUpPosition, _fadeUpTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void FadeDown()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;

        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _targetFadeDown;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            _sequence.Append(_chandelureImage.DOFade(_originalFadeDown, _fadeDownTime));
            _sequence.Join(_chandelure.DOLocalMoveY(_originalFadeDownPosition, _fadeDownTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _originalFadeDown;

            _sequence.Append(_chandelureImage.DOFade(_targetFadeDown, _fadeDownTime));
            _sequence.Join(_chandelure.DOLocalMoveY(_targetFadeDownPosition, _fadeDownTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void FadeLeft()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;


        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * 380f;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            _sequence.Append(_chandelureImage.DOFade(_originalFadeLeft, _fadeLeftTime));
            _sequence.Join(_chandelure.DOLocalMoveX(_originalFadeLeftPosition, _fadeLeftTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f;

            _sequence.Append(_chandelureImage.DOFade(_targetFadeLeft, _fadeLeftTime));
            _sequence.Join(_chandelure.DOLocalMoveX(_targetFadeLeftPosition, _fadeLeftTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void FadeRight()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;

        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * 280f;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            _sequence.Append(_chandelureImage.DOFade(_originalFadeRight, _fadeRightTime));
            _sequence.Join(_chandelure.DOLocalMoveX(_originalFadeRightPosition, _fadeRightTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f;

            _sequence.Append(_chandelureImage.DOFade(_targetFadeRight, _fadeRightTime));
            _sequence.Join(_chandelure.DOLocalMoveX(_targetFadeRightPosition, _fadeRightTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void HorizontalFlip()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;
        _chandelure.localPosition = Vector3.right * 330f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 90f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _originalHorizontalFlipRotation, _horizontalFlipTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _targetHorizontalFlipRotation, _horizontalFlipTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void VerticalFlip()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;
        _chandelure.localPosition = Vector3.right * 330f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(90f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalRotate(Vector3.right * _originalVerticalFlipRotation, _verticalFlipTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.right * _targetVerticalFlipRotation, _verticalFlipTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void Drop()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 1f);
        _chandelure.localPosition = Vector3.right * 330f + Vector3.up * 250f;

        if (_animate)
        {
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOScale(_originalDropScale, _dropTime));
            _sequence.Append(_chandelure.DOPunchScale(_dropPunchScale, _dropPunchScaleDuration, _dropPunchScaleVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOScale(_targetDropScale, _dropTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void FlyLeft()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;

        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * _targetFlyLeftPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalMoveX(_originalFlyLeftPosition, _flyLeftTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.left * _flyLeftPunchPosition, _flyLeftPunchPositionDuration, _flyLeftPunchPositionVibrato));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * _originalFlyLeftPosition;

            _sequence.Append(_chandelure.DOLocalMoveX(_targetFlyLeftPosition, _flyLeftTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.right * _flyLeftPunchPosition, _flyLeftPunchPositionDuration, _flyLeftPunchPositionVibrato));
        }

        _animate = !_animate;
    }

    [Button]
    public void FlyRight()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;

        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * _targetFlyRightPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalMoveX(_originalFlyRightPosition, _flyRightTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.left * _flyRightPunchPosition, _flyRightPunchPositionDuration, _flyRightPunchPositionVibrato));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * _originalFlyRightPosition;

            _sequence.Append(_chandelure.DOLocalMoveX(_targetFlyRightPosition, _flyRightTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.right * _flyRightPunchPosition, _flyRightPunchPositionDuration, _flyRightPunchPositionVibrato));
        }

        _animate = !_animate;
    }

    [Button]
    public void FlyDown()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;

        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _targetFlyDownPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalMoveY(_originalFlyDownPosition, _flyDownTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.down * _flyDownPunchPosition, _flyDownPunchPositionDuration, _flyDownPunchPositionVibrato));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _originalFlyDownPosition;

            _sequence.Append(_chandelure.DOLocalMoveY(_targetFlyDownPosition, _flyDownTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.up * _flyDownPunchPosition, _flyDownPunchPositionDuration, _flyDownPunchPositionVibrato));
        }

        _animate = !_animate;
    }

    [Button]
    public void FlyUp()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = Vector2.one * 0.5f;

        if (_animate)
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _targetFlyUpPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalMoveY(_originalFlyUpPosition, _flyUpTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.down * _flyUpPunchPosition, _flyUpPunchPositionDuration, _flyUpPunchPositionVibrato));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _originalFlyUpPosition;

            _sequence.Append(_chandelure.DOLocalMoveY(_targetFlyUpPosition, _flyUpTime));
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.up * _flyUpPunchPosition, _flyUpPunchPositionDuration, _flyUpPunchPositionVibrato));
        }

        _animate = !_animate;
    }
    #endregion

    #region Swing Left
    [Header("Swing Left")]
    [SerializeField] private float _swingLeftPunchRotation;
    [SerializeField] private float _swingLeftPunchRotationDuration;
    [SerializeField] private int _swingLeftPunchRotationVibrato;
    [SerializeField] private float _originalSwingLeftRotation;
    [SerializeField] private float _targetSwingLeftRotation;
    [SerializeField] private float _swingLeftTime;
    #endregion

    [Button]
    public void SwingLeft()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(1f, 0.5f);
        _chandelure.localPosition = Vector3.right * 580f;

        if (_animate)
        {
            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * -_swingLeftPunchRotation, _swingLeftTime));
            //_sequence.Append(_chandelure.DOPunchRotation(Vector3.up * _swingLeftPunchRotation, _swingLeftPunchRotationDuration, _swingLeftPunchRotationVibrato));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up *  _swingLeftPunchRotation, _swingLeftPunchRotationDuration));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * - _swingLeftPunchRotation, _swingLeftPunchRotationDuration));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _originalSwingLeftRotation, _swingLeftPunchRotationDuration));
        }
        else
        {
            //_sequence.Append(_chandelure.DOPunchRotation(Vector3.down * _swingLeftPunchRotation, _swingLeftPunchRotationDuration, _swingLeftPunchRotationVibrato));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _swingLeftPunchRotation, _swingLeftPunchRotationDuration));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * - _swingLeftPunchRotation, _swingLeftPunchRotationDuration));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _targetSwingLeftRotation, _swingLeftTime));
        }

        _animate = !_animate;
    }

}
