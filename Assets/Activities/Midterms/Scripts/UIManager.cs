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
    [SerializeField] private Image _chandelureBackgroundImage;
    #endregion

    #region Animation Components
    [Header("Animation Components")]
    [SerializeField] private bool _animate = false;
    private Sequence _sequence;
    #endregion

    #region Scale
    [Header("Scale")]
    [SerializeField] private float _originalScale;
    [SerializeField] private float _targetScale;
    [SerializeField] private float _originalScaleFade;
    [SerializeField] private float _targetScaleFade;
    [SerializeField] private float _scaleTime;
    #endregion

    #region Zoom
    [Header("Zoom")]
    [SerializeField] private float _originalZoomScale;
    [SerializeField] private float _targetZoomScale;
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
    [SerializeField] private float _originalDropScale;
    [SerializeField] private float _targetDropScale;
    [SerializeField] private float _dropTime;
    [SerializeField] private float _dropPunchScale;
    [SerializeField] private float _dropPunchScaleDuration;
    [SerializeField] private int _dropPunchScaleVibrato;
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

    #region Fly Down
    [Header("Fly Down")]
    [SerializeField] private float _originalFlyDownPosition;
    [SerializeField] private float _targetFlyDownPosition;
    [SerializeField] private float _flyDownTime;
    [SerializeField] private float _flyDownPunchPosition;
    [SerializeField] private float _flyDownPunchPositionDuration;
    [SerializeField] private int _flyDownPunchPositionVibrato;
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

    #region Swing Up
    [Header("Swing Up")]
    [SerializeField] private float _swingUpPunchRotation;
    [SerializeField] private float _swingUpPunchRotationDuration;
    [SerializeField] private int _swingUpPunchRotationVibrato;
    [SerializeField] private float _originalSwingUpRotation;
    [SerializeField] private float _targetSwingUpRotation;
    [SerializeField] private float _swingUpTime;
    #endregion

    #region Swing Down
    [Header("Swing Down")]
    [SerializeField] private float _swingDownPunchRotation;
    [SerializeField] private float _swingDownPunchRotationDuration;
    [SerializeField] private int _swingDownPunchRotationVibrato;
    [SerializeField] private float _originalSwingDownRotation;
    [SerializeField] private float _targetSwingDownRotation;
    [SerializeField] private float _swingDownTime;
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

    #region Swing Right
    [Header("Swing Right")]
    [SerializeField] private float _swingRightPunchRotation;
    [SerializeField] private float _swingRightPunchRotationDuration;
    [SerializeField] private int _swingRightPunchRotationVibrato;
    [SerializeField] private float _originalSwingRightRotation;
    [SerializeField] private float _targetSwingRightRotation;
    [SerializeField] private float _swingRightTime;
    #endregion

    #region Browse
    [Header("Browse")]
    [SerializeField] private float _browsePunchPosition;
    [SerializeField] private float _browsePunchPositionDuration;
    [SerializeField] private int _browsePunchPositionVibrato;
    [SerializeField] private float _originalBrowseFade;
    [SerializeField] private float _targetBrowseFade;
    [SerializeField] private float _browseTime;
    [SerializeField] private float _browsePunchScale;
    [SerializeField] private float _browsePunchScaleDuration;
    [SerializeField] private int _browsePunchScaleVibrato;
    #endregion

    #region Browse Right
    [Header("Browse Right")]
    [SerializeField] private float _browseRightPunchPosition;
    [SerializeField] private float _browseRightPunchPositionDuration;
    [SerializeField] private int _browseRightPunchPositionVibrato;
    [SerializeField] private float _originalBrowseRightFade;
    [SerializeField] private float _targetBrowseRightFade;
    [SerializeField] private float _browseRightTime;
    [SerializeField] private float _browseRightPunchScale;
    [SerializeField] private float _browseRightPunchScaleDuration;
    [SerializeField] private int _browseRightPunchScaleVibrato;
    #endregion

    #region Slide Up
    [Header("Slide Up")]
    [SerializeField] private float _originalSlideUpScale;
    [SerializeField] private float _targetSlideUpScale;
    [SerializeField] private float _originalSlideUpFade;
    [SerializeField] private float _targetSlideUpFade;
    [SerializeField] private float _slideUpTime;
    #endregion

    #region Slide Down
    [Header("Slide Down")]
    [SerializeField] private float _originalSlideDownScale;
    [SerializeField] private float _targetSlideDownScale;
    [SerializeField] private float _originalSlideDownFade;
    [SerializeField] private float _targetSlideDownFade;
    [SerializeField] private float _slideDownTime;
    #endregion

    #region Slide Left
    [Header("Slide Left")]
    [SerializeField] private float _originalSlideLeftScale;
    [SerializeField] private float _targetSlideLeftScale;
    [SerializeField] private float _originalSlideLeftFade;
    [SerializeField] private float _targetSlideLeftFade;
    [SerializeField] private float _slideLeftTime;
    #endregion

    #region Slide Right
    [Header("Slide Right")]
    [SerializeField] private float _originalSlideRightScale;
    [SerializeField] private float _targetSlideRightScale;
    [SerializeField] private float _originalSlideRightFade;
    [SerializeField] private float _targetSlideRightFade;
    [SerializeField] private float _slideRightTime;
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
            _chandelure.localScale = Vector3.one * _targetScale;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetScaleFade;
            _chandelureImage.color = imageColor;

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
            _chandelure.localScale = Vector3.one * _targetZoomScale;
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

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetFade;
            _chandelureImage.color = imageColor;

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
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _targetFadeUpPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetFadeUp;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelureImage.DOFade(_originalFadeUp, _fadeUpTime));
            _sequence.Join(_chandelure.DOLocalMoveY(_originalFadeUpPosition, _fadeUpTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _originalFadeUpPosition;

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
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _targetFadeDownPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetFadeDown;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelureImage.DOFade(_originalFadeDown, _fadeDownTime));
            _sequence.Join(_chandelure.DOLocalMoveY(_originalFadeDownPosition, _fadeDownTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * 330f + Vector3.up * _originalFadeDownPosition;

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
            _chandelure.localPosition = Vector3.right * _targetFadeLeftPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetFadeLeft;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelureImage.DOFade(_originalFadeLeft, _fadeLeftTime));
            _sequence.Join(_chandelure.DOLocalMoveX(_originalFadeLeftPosition, _fadeLeftTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * _originalFadeLeftPosition;

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
            _chandelure.localPosition = Vector3.right * _targetFadeRightPosition;
            _chandelure.localScale = Vector3.one;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetFadeRight;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelureImage.DOFade(_originalFadeRight, _fadeRightTime));
            _sequence.Join(_chandelure.DOLocalMoveX(_originalFadeRightPosition, _fadeRightTime));
        }
        else
        {
            _chandelure.localPosition = Vector3.right * _originalFadeRightPosition;

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
            _chandelure.localRotation = Quaternion.Euler(0f, _targetHorizontalFlipRotation, 0f);

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
            _chandelure.localRotation = Quaternion.Euler(_targetVerticalFlipRotation, 0f, 0f);

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
            _chandelure.localScale = Vector3.one * _targetDropScale;
            _chandelure.localRotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOScale(_originalDropScale, _dropTime));
            _sequence.Append(_chandelure.DOPunchScale(Vector3.one * _dropPunchScale, _dropPunchScaleDuration, _dropPunchScaleVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOScale(_targetDropScale, _dropTime));
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
    public void SwingUp()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0f);
        _chandelure.localPosition = Vector3.right * 330f + Vector3.down * 250f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.rotation = Quaternion.Euler(_targetSwingUpRotation, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalRotate(Vector3.right * _originalSwingUpRotation, _swingUpTime));
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.right * _swingUpPunchRotation, _swingUpPunchRotationDuration, _swingUpPunchRotationVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.left * _swingUpPunchRotation, _swingUpPunchRotationDuration, _swingUpPunchRotationVibrato));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.right * _targetSwingUpRotation, _swingUpTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void SwingDown()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 1f);
        _chandelure.localPosition = Vector3.right * 330f + Vector3.up * 250f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.rotation = Quaternion.Euler(_targetSwingDownRotation, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalRotate(Vector3.right * _originalSwingDownRotation, _swingDownTime));
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.right * _swingDownPunchRotation, _swingDownPunchRotationDuration, _swingDownPunchRotationVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.left * _swingDownPunchRotation, _swingDownPunchRotationDuration, _swingDownPunchRotationVibrato));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.right * _targetSwingDownRotation, _swingDownTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void SwingLeft()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(1f, 0.5f);
        _chandelure.localPosition = Vector3.right * 580f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.rotation = Quaternion.Euler(0f, _targetSwingLeftRotation, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _originalSwingLeftRotation, _swingLeftTime));
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.up * _swingLeftPunchRotation, _swingLeftPunchRotationDuration, _swingLeftPunchRotationVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.down * _swingLeftPunchRotation, _swingLeftPunchRotationDuration, _swingLeftPunchRotationVibrato));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _targetSwingLeftRotation, _swingLeftTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void SwingRight()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0f, 0.5f);
        _chandelure.localPosition = Vector3.right * 80f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.rotation = Quaternion.Euler(0f, _targetSwingRightRotation, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = 1f;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _originalSwingRightRotation, _swingRightTime));
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.up * _swingRightPunchRotation, _swingRightPunchRotationDuration, _swingRightPunchRotationVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOPunchRotation(Vector3.down * _swingRightPunchRotation, _swingRightPunchRotationDuration, _swingRightPunchRotationVibrato));
            _sequence.Append(_chandelure.DOLocalRotate(Vector3.up * _targetSwingRightRotation, _swingRightTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void Browse()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetBrowseFade;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelureImage.DOFade(_originalBrowseFade, _browseTime));
            _sequence.Append(_chandelure.DOPunchScale(Vector3.one * _browsePunchScale, _browsePunchScaleDuration, _browsePunchScaleVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.right * _browsePunchPosition, _browsePunchPositionDuration, _browsePunchPositionVibrato));
            _sequence.Append(_chandelureImage.DOFade(_targetBrowseFade, _browseTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void BrowseRight()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;

        if (_animate)
        {
            _chandelure.localScale = Vector3.one;
            _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetBrowseRightFade;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelureImage.DOFade(_originalBrowseRightFade, _browseRightTime));
            _sequence.Append(_chandelure.DOPunchScale(Vector3.one * _browseRightPunchScale, _browseRightPunchScaleDuration, _browseRightPunchScaleVibrato));
        }
        else
        {
            _sequence.Append(_chandelure.DOPunchPosition(Vector3.right * _browseRightPunchPosition, _browseRightPunchPositionDuration, _browseRightPunchPositionVibrato));
            _sequence.Append(_chandelureImage.DOFade(_targetBrowseRightFade, _browseRightTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void SlideUp()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0f);
        _chandelure.localPosition = Vector3.right * 330f + Vector3.down * 250f;

        if (_animate)
        {
            _chandelure.localScale = new Vector3(1f, _targetSlideUpScale, 1f);
            _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetSlideUpFade;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOScaleY(_originalSlideUpScale, _slideUpTime));
            _sequence.Join(_chandelureImage.DOFade(_originalSlideUpFade, _slideUpTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOScaleY(_targetSlideUpScale, _slideUpTime));
            _sequence.Join(_chandelureImage.DOFade(_targetSlideUpFade, _slideUpTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void SlideDown()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 1f);
        _chandelure.localPosition = Vector3.right * 330f + Vector3.up * 250f;

        if (_animate)
        {
            _chandelure.localScale = new Vector3(1f, _targetSlideDownScale, 1f);
            _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetSlideDownFade;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOScaleY(_originalSlideDownScale, _slideDownTime));
            _sequence.Join(_chandelureImage.DOFade(_originalSlideDownFade, _slideDownTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOScaleY(_targetSlideDownScale, _slideDownTime));
            _sequence.Join(_chandelureImage.DOFade(_targetSlideDownFade, _slideDownTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void SlideLeft()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(1f, 0.5f);
        _chandelure.localPosition = Vector3.right * 580f;

        if (_animate)
        {
            _chandelure.localScale = new Vector3(_targetSlideLeftScale, 1f, 1f);
            _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetSlideLeftFade;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOScaleX(_originalSlideLeftScale, _slideLeftTime));
            _sequence.Join(_chandelureImage.DOFade(_originalSlideLeftFade, _slideLeftTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOScaleX(_targetSlideLeftScale, _slideLeftTime));
            _sequence.Join(_chandelureImage.DOFade(_targetSlideLeftFade, _slideLeftTime));
        }

        _animate = !_animate;
    }

    [Button]
    public void SlideRight()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0f, 0.5f);
        _chandelure.localPosition = Vector3.right * 80f;

        if (_animate)
        {
            _chandelure.localScale = new Vector3(_targetSlideRightScale, 1f, 1f);
            _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

            Color imageColor = _chandelureImage.color;
            imageColor.a = _targetSlideRightFade;
            _chandelureImage.color = imageColor;

            _sequence.Append(_chandelure.DOScaleX(_originalSlideRightScale, _slideRightTime));
            _sequence.Join(_chandelureImage.DOFade(_originalSlideRightFade, _slideRightTime));
        }
        else
        {
            _sequence.Append(_chandelure.DOScaleX(_targetSlideRightScale, _slideRightTime));
            _sequence.Join(_chandelureImage.DOFade(_targetSlideRightFade, _slideRightTime));
        }

        _animate = !_animate;
    }
    #endregion

    #region Jiggle
    [Header("Jiggle")]
    [SerializeField] private float _jigglePunchScale;
    [SerializeField] private float _jigglePunchScaleDuration;
    [SerializeField] private int _jigglePunchScaleVibrato;
    #endregion

    #region Flash
    [Header("Flash")]
    [SerializeField] private float _originalFlashFade;
    [SerializeField] private float _targetFlashFade;
    [SerializeField] private float _flashTime;
    #endregion

    #region Shake
    [Header("Shake")]
    [SerializeField] private float _shakePunchPosition;
    [SerializeField] private float _shakePunchPositionDuration;
    [SerializeField] private int _shakePunchPositionVibrato;
    #endregion

    #region Pulse
    [Header("Pulse")]
    [SerializeField] private float _originalPulseScale;
    [SerializeField] private float _targetPulseScale;
    [SerializeField] private float _originalPulseFade;
    [SerializeField] private float _targetPulseFade;
    [SerializeField] private float _pulseTime;
    #endregion

    #region Tada
    [Header("Tada")]
    [SerializeField] private float _originalTadaScale;
    [SerializeField] private float _smallerTargetTadaScale;
    [SerializeField] private float _largerTargetTadaScale;
    [SerializeField] private float _tadaTime;
    [SerializeField] private float _tadaPunchRotation;
    [SerializeField] private float _tadaPunchRotationDuration;
    [SerializeField] private int _tadaPunchRotationVibrato;
    #endregion

    #region Bounce
    [Header("Bounce")]
    [SerializeField] private float _originalBouncePosition;
    [SerializeField] private float _targetBouncePosition;
    [SerializeField] private float _bounceTime;
    [SerializeField] private float _bouncPunchPosition;
    [SerializeField] private float _bouncPunchPositionDuration;
    [SerializeField] private int _bouncPunchPositionVibrato;
    #endregion

    [Button]
    public void Jiggle()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;
        _chandelure.localScale = Vector3.one;
        _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

        Color imageColor = _chandelureImage.color;
        imageColor.a = 1f;
        _chandelureImage.color = imageColor;

        _animate = true;

        _sequence.Append(_chandelure.DOPunchScale(Vector3.up * _jigglePunchScale, _jigglePunchScaleDuration, _jigglePunchScaleVibrato));
        
        _animate = false;
    }

    [Button]
    public void Flash()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;
        _chandelure.localScale = Vector3.one;
        _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

        Color imageColor = _chandelureImage.color;
        imageColor.a = _originalFlashFade;
        _chandelureImage.color = imageColor;

        _animate = true;

        _sequence.Append(_chandelureImage.DOFade(_targetFlashFade, _flashTime));
        _sequence.Append(_chandelureImage.DOFade(_originalFlashFade, _flashTime));
        _sequence.Append(_chandelureImage.DOFade(_targetFlashFade, _flashTime));
        _sequence.Append(_chandelureImage.DOFade(_originalFlashFade, _flashTime));

        _animate = false;
    }

    [Button]
    public void Shake()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;
        _chandelure.localScale = Vector3.one;
        _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

        Color imageColor = _chandelureImage.color;
        imageColor.a = 1f;
        _chandelureImage.color = imageColor;

        _animate = true;

        _sequence.Append(_chandelure.DOPunchPosition(Vector3.right * _shakePunchPosition, _shakePunchPositionDuration, _shakePunchPositionVibrato));

        _animate = false;
    }

    [Button]
    public void Pulse()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;
        _chandelure.localScale = Vector3.one;
        _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

        Color imageColor = _chandelureImage.color;
        imageColor.a = _originalPulseFade;
        _chandelureImage.color = imageColor;

        _animate = true;

        _sequence.Append(_chandelure.DOScale(Vector3.one * _targetPulseScale, _flashTime));
        _sequence.Join(_chandelureImage.DOFade(_targetPulseFade, _flashTime));
        _sequence.Append(_chandelure.DOScale(Vector3.one * _originalPulseScale, _flashTime));
        _sequence.Join(_chandelureImage.DOFade(_originalPulseFade, _flashTime));

        _animate = false;
    }

    [Button]
    public void Tada()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;
        _chandelure.localScale = Vector3.one;
        _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

        Color imageColor = _chandelureImage.color;
        imageColor.a = 1f;
        _chandelureImage.color = imageColor;

        _animate = true;

        _sequence.Append(_chandelure.DOScale(Vector3.one * _smallerTargetTadaScale, _tadaTime));
        _sequence.Append(_chandelure.DOScale(Vector3.one * _largerTargetTadaScale, _tadaTime));
        _sequence.Append(_chandelure.DOPunchRotation(Vector3.forward * _tadaPunchRotation, _tadaPunchRotationDuration, _tadaPunchRotationVibrato));
        _sequence.Append(_chandelure.DOScale(Vector3.one * _originalTadaScale, _tadaTime));

        _animate = false;
    }

    [Button]
    public void Bounce()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0f);
        _chandelure.localPosition = Vector3.right * 330f + Vector3.down * 250f;
        _chandelure.localScale = Vector3.one;
        _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

        Color imageColor = _chandelureImage.color;
        imageColor.a = 1f;
        _chandelureImage.color = imageColor;

        _animate = true;

        _sequence.Append(_chandelure.DOLocalMoveY(_targetBouncePosition, _bounceTime));
        _sequence.Append(_chandelure.DOLocalMoveY(_originalBouncePosition, _bounceTime));
        _sequence.Append(_chandelure.DOPunchPosition(Vector3.up * _bouncPunchPosition, _bouncPunchPositionDuration, _bouncPunchPositionVibrato));
        _animate = false;
    }

    #region Glow
    [Header("Glow")]
    [SerializeField] private Color _originalGlowColor;
    [SerializeField] private Color _target1GlowColor;
    [SerializeField] private Color _target2GlowColor;
    [SerializeField] private float _glowTime;
    #endregion


    [Button]
    public void Glow()
    {
        _sequence = DOTween.Sequence();
        _chandelure.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        _chandelure.localPosition = Vector3.right * 330f;
        _chandelure.localScale = Vector3.one;
        _chandelure.rotation = Quaternion.Euler(0f, 0f, 0f);

        Color imageColor = _chandelureImage.color;
        imageColor.a = 1f;
        _chandelureImage.color = imageColor;

        _animate = true;

        _chandelureBackgroundImage.color = _target1GlowColor;
        _sequence.Append(_chandelureBackgroundImage.DOColor(_target1GlowColor, 0f));
        _sequence.Append(_chandelureBackgroundImage.DOColor(_target2GlowColor, _glowTime));
        _sequence.Append(_chandelureBackgroundImage.DOColor(_originalGlowColor, 0f));

        _animate = false;
    }

}
