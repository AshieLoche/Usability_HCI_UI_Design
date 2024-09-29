using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class WorldUIBehaviour : MonoBehaviour
{

    [SerializeField] private enum BillboardType
    {
        LookAtCamera,
        CameraForward,
    }

    [SerializeField] private BillboardType _billboardType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (_billboardType)
        {
            case BillboardType.LookAtCamera:
                transform.LookAt(Camera.main.transform.position);
                break;
            case BillboardType.CameraForward:
                transform.forward = Camera.main.transform.forward;
                break;
            default:
                break;
        }

    }

}
