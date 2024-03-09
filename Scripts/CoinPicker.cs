using UnityEngine;
using UnityEngine.UI;

//----------- COIN PICK UP SCRIPT -----------------

public class CoinPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        transform.position = new Vector3(0, -1000, 0);
        GlobalCoins.CoinCount += 1;
    }
}