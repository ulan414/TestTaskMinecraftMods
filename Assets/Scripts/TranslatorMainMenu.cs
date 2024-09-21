using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TranslatorMainMenu : MonoBehaviour
{
    private string Language = "Ru";
    public TextMeshProUGUI Mods; 
    public TextMeshProUGUI Instructions; 
    public TextMeshProUGUI Politics; 

 

    void Start()
    {
        Language = PlayerPrefs.GetString("Language", "Ru");
        Change(Language);
    }
    public void Change(string Language){
        if (Language == "Ru"){
            Mods.text = "Моды";
            Instructions.text = "Инструкции";
            Politics.text = "политика конфиденциальности";
        }
        if (Language == "En"){
            Mods.text = "Mods";
            Instructions.text = "Instructions";
            Politics.text = "privacy policy";
        }
        if (Language == "Es"){
            Mods.text = "Modes";
            Instructions.text = "Instrucciones";
            Politics.text = "política de privacidad";
        }
    }
}
