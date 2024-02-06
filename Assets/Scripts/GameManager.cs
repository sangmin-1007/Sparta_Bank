using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("бс GameObject")]
    [SerializeField] private GameObject buttonObject;
    [SerializeField] private GameObject depositObject;
    [SerializeField] private GameObject withDrawObject;

    [Header("Text")]
    [SerializeField] private Text myMoneyTxt;
    [SerializeField] private Text bankMoneyTxt;

    private int myMoney;
    private int bankMoney;

    private void Start()
    {
        myMoney = 100000;
        bankMoney = 50000;
        myMoneyTxt.text = myMoney.ToString("N0");
        bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
    }

    public void OnClickDepositBtn()
    {
        buttonObject.SetActive(false);
        depositObject.SetActive(true);
    }

    public void OnClickWithDrawBtn()
    {
        buttonObject.SetActive(false);
        withDrawObject.SetActive(true);
        
    }

    public void OnClickBackBtn()
    {
        withDrawObject.SetActive(false);
        depositObject.SetActive(false);
        buttonObject.SetActive(true);
    }
}
