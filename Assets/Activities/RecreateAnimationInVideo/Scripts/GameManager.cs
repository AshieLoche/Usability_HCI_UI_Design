using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private List<Transform> _markers;
    [SerializeField] private List<GameObject> _blackCards;
    [SerializeField] private List<GameObject> _blueCards;
    [SerializeField] private List<GameObject> _redCards;
    [SerializeField] private Transform _card;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject card = Instantiate(_blackCards[Random.Range(0, _blackCards.Count)], _markers[i].position, Quaternion.Euler(new Vector3(0f, 0f, 180f)));
            card.transform.localScale = new Vector3(1f, 1f, 1f);
            card.transform.parent = _card;
            card.AddComponent<RecreateAnimationInVideo>();
            card.AddComponent<BoxCollider>();
            BoxCollider _boxCollider = card.GetComponent<BoxCollider>();
            _boxCollider.size = new Vector3(5.7f, 0.025f, 8.85f);
            _boxCollider.center = new Vector3(0f, 0f, 0f);
        }
    }

}
