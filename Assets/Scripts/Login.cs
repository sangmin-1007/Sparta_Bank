using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [Header("бс InputField")]
    [SerializeField] private InputField id;
    [SerializeField] private InputField ps;

    [Header("бс GameObject")]
    [SerializeField] private GameObject errorMessage;
    public void OnClickLoginBtn()
    {
        if (id.text != "" && ps.text != "")
        {
            SceneManager.LoadScene("GameScene");

        }
        else
            errorMessage.SetActive(true);
    }

    public void OnClickErrorMessage()
    {
        errorMessage.SetActive(false);
    }

}
