﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public InputField emailField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        form.AddField("email", emailField.text);

        WWW www = new WWW("http://192.168.1.198/sqlconnect/register.php", form);
        yield return www;
      
        if (www.text=="0")
        {
            Debug.Log("User Created Successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User creation failed. Error#" + www.error);
        }
    }
    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8 && emailField.text.Length >= 8);
    }
}