using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance => instance;

    [Header("�� GameObject")]
    [SerializeField]private GameObject buttonObject;
    [SerializeField] private GameObject depositObject;
    [SerializeField] private GameObject withDrawObject;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else


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
