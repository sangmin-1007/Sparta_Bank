using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [Header("InputField")]
    [SerializeField] private InputField id;
    [SerializeField] private InputField ps;

    public void OnClickLoginBtn()
    {
        if (id.text != "" && ps.text != "")
        {
            SceneManager.LoadScene("GameScene");

        }
        else
            Debug.Log("아이디 비번 확인!");
    }

}
