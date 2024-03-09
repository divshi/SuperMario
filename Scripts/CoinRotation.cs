using UnityEngine;
using UnityEngine.UI;

//----------- COIN ROTATION SCRIPT -----------------

public class CoinRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 2, 0, Space.World);
    }
}


