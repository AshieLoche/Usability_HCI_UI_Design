using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Week1n2_UIBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Week1n2_UIManager uIManager;

    public void OnPointerEnter(PointerEventData eventData)
    {
        uIManager.SetTartgetObject(gameObject);
        uIManager.IncreaseSize();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        uIManager.DecreaseSize();
        uIManager.SetTartgetObject(null);
    }

}
