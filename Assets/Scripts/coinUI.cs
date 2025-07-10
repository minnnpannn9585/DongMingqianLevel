using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinUI : MonoBehaviour
{

    public int startCoin;
    public Text coinNumber;

    public static int CurrentCoinNumber;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCoinNumber = startCoin;
    }

    // Update is called once per frame
    void Update()
    {
        coinNumber.text = CurrentCoinNumber.ToString();
    }
}
