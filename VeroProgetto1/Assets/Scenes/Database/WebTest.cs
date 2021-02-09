using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTest : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
       WWW request = new WWW("http://localhost/sqlconnect/webtest.php");
        yield return request;
        string[] webResult = request.text.Split('\t');
        Debug.Log(webResult[0]);
        int webNumber = int.Parse(webResult[1]);
        webNumber *= 2;
        Debug.Log(webNumber);
    }
}
