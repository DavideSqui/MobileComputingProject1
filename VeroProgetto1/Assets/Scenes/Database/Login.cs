using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);

        WWW www = new WWW("http://192.168.1.198/sqlconnect/login.php", form);
        yield return www;

        if (www.text[0] == '0')
        {
            DBManager.username = nameField.text;
            Debug.Log(www.text);
            DBManager.score = int.Parse(www.text.Split('\t')[1]);
            //richiedo il livello dell'utente
            WWW level= new WWW("http://192.168.1.198/sqlconnect/obtainlevel.php", form);
            yield return level;
            DBManager.level = int.Parse(level.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User logging failed. Error#" + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }
}
