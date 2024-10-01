using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Week1n2_UIBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private Week1n2_UIManager _uIManager;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _uIManager.SetTartgetObject(gameObject);
        _uIManager.IncreaseSize();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _uIManager.DecreaseSize();
        _uIManager.SetTartgetObject(null);
    }

}
