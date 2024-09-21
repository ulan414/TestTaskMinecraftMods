using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconController : MonoBehaviour
{
    public GameObject iconRu;
    public GameObject iconPl;
    public GameObject iconIn;
    public GameObject Circle;
    public GameObject iconAll;
    public GameObject soundOn;
    public GameObject soundOff;
    public TranslatorMainMenu TranslatorMainMenu;
    private string Language = "Ru";

    void Start()
    {
        Language = PlayerPrefs.GetString("Language", "Ru");
        if (Language == "Ru"){
            SetRu();
        }
         if (Language == "En"){
            SetIn();
        }
         if (Language == "Es"){
            SetPl();
        }
    }
    public void SetAll(){
        Circle.SetActive(false);
        iconRu.SetActive(false);
        iconAll.SetActive(true);
        iconPl.SetActive(false);
        iconIn.SetActive(false);
    }
    public void SetRu(){
        Circle.SetActive(true);
        iconRu.SetActive(true);
        iconAll.SetActive(false);
        iconPl.SetActive(false);
        iconIn.SetActive(false);
        PlayerPrefs.SetString("Language", "Ru");
        TranslatorMainMenu.Change("Ru");
    }
        public void SetIn(){
        iconAll.SetActive(false);
        iconPl.SetActive(false);
        iconIn.SetActive(true);
        Circle.SetActive(true);
        iconRu.SetActive(false);
        PlayerPrefs.SetString("Language", "En");//it was india icon
        TranslatorMainMenu.Change("En");
    }
        public void SetPl(){
        iconAll.SetActive(false);
        iconPl.SetActive(true);
        iconIn.SetActive(false);
        Circle.SetActive(true);
        iconRu.SetActive(false);
        PlayerPrefs.SetString("Language", "Es");//it was polish icon
        TranslatorMainMenu.Change("Es");
    }
    public void SetSoundOn(){
        soundOn.SetActive(true);
        soundOff.SetActive(false);
    }
    public void SetSoundOff(){
        soundOn.SetActive(false);
        soundOff.SetActive(true);
    }
}
