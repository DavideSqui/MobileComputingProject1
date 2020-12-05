using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileUse : MonoBehaviour
{
         public GameObject inputField;
         public GameObject textDisplay;
         public static string profileName;
        public  void SubmitName()
        {
            profileName = inputField.GetComponent<Text>().text;
            textDisplay.GetComponent<Text>().text ="Welcome " + profileName + " to the game!";
        }
}
