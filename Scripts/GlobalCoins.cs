//----------- GLOBAL COIN SCRIPT -----------------
using UnityEngine;
using UnityEngine.UI;
public class GlobalCoins : MonoBehaviour
{
    public GameObject CoinDisplay;
    public static int CoinCount;
    private int InternalCoin;

    void Update()
    {
        InternalCoin = CoinCount;
        CoinDisplay.GetComponent<Text>().text = "Coins: " + CoinCount;
        Debug.Log("Coins: " + CoinCount); // Add debug log statement
    }

}