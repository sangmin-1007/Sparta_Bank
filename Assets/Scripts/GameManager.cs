using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("■ GameObject")]
    [SerializeField] private GameObject buttonObject;
    [SerializeField] private GameObject depositObject;
    [SerializeField] private GameObject withDrawObject;

    [Header("Text")]
    [SerializeField] private Text myMoneyTxt;
    [SerializeField] private Text bankMoneyTxt;
    [SerializeField]private InputField[] inputText;

    private int myMoney;
    private int bankMoney;

    private bool isDeposit;

    private void Start()
    {
        myMoney = 100000;
        bankMoney = 50000;
        myMoneyTxt.text = myMoney.ToString("N0");
        bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
    }

    public void OnClickDepositBtn()
    {
        isDeposit = true;
        buttonObject.SetActive(false);
        depositObject.SetActive(true);
    }

    public void OnClickWithDrawBtn()
    {
        isDeposit = false;
        buttonObject.SetActive(false);
        withDrawObject.SetActive(true);
        
    }

    public void OnClickBackBtn()
    {
        withDrawObject.SetActive(false);
        depositObject.SetActive(false);
        buttonObject.SetActive(true);
    }

    #region 금액별 버튼클릭 메서드
    public void OnClick10000Btn()
    {
        if(isDeposit)
        {
            if(myMoney >= 10000)
            {
                myMoney -= 10000;
                bankMoney += 10000;
                myMoneyTxt.text = myMoney.ToString("N0");
                bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
            }
        }
        else
        {
            if(bankMoney >= 10000)
            {
                bankMoney -= 10000;
                myMoney += 10000;
                myMoneyTxt.text = myMoney.ToString("N0");
                bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
            }
        }
    }

    public void OnClick30000Btn()
    {
        if (isDeposit)
        {
            if (myMoney >= 30000)
            {
                myMoney -= 10000;
                bankMoney += 10000;
                myMoneyTxt.text = myMoney.ToString("N0");
                bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
            }
        }
        else
        {
            if (bankMoney >= 30000)
            {
                bankMoney -= 30000;
                myMoney += 30000;
                myMoneyTxt.text = myMoney.ToString("N0");
                bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
            }
        }
    }

    public void OnClick50000Btn()
    {
        if (isDeposit)
        {
            if (myMoney >= 50000)
            {
                myMoney -= 50000;
                bankMoney += 50000;
                myMoneyTxt.text = myMoney.ToString("N0");
                bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
            }
        }
        else
        {
            if (bankMoney >= 50000)
            {
                bankMoney -= 50000;
                myMoney += 50000;
                myMoneyTxt.text = myMoney.ToString("N0");
                bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
            }
        }
    }

    public void OnClickInputDeposit()
    {
        bool isPossible = int.TryParse(inputText[0].text, out int getMoney);
        if (!isPossible)
        {
            Debug.Log("숫자만 입력하세요");
            return;
        }
        else if (myMoney >= getMoney)
        {
            myMoney -= getMoney;
            bankMoney += getMoney;
            myMoneyTxt.text = myMoney.ToString("N0");
            bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
        }
    }
    public void OnClickInputWithDraw()
    {
        bool isPossible = int.TryParse(inputText[1].text, out int getMoney);
        if (!isPossible)
        {
            Debug.Log("숫자만 입력하세요");
            return;
        }
        else if (bankMoney >= getMoney)
        {
            myMoney += getMoney;
            bankMoney -= getMoney;
            myMoneyTxt.text = myMoney.ToString("N0");
            bankMoneyTxt.text = $"Balance    {bankMoney.ToString("N0")}";
        }
    }
    #endregion


}
