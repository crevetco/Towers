using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    public TMP_Text MoneyText;
    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "₽" + PlayerStats.Money.ToString();
    }
}
