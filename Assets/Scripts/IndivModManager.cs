using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IndivModManager : MonoBehaviour
{
    public string NameRu = "";
    public string NameEn = "";
    public string NameEs = "";
    public string NamePt = "";

    public string DescrRu = "";
    public string DescrEn = "";
    public string DescrEs = "";
    public string DescrPt = "";

    public string FolderName = "";
    private string Language = "ru";
    public TextMeshProUGUI Name; 

    void Start(){
        Language = PlayerPrefs.GetString("Language", "Ru");
        if (Language == "Ru"){
            Name.text = NameRu;
        }
        if (Language == "En"){
            Name.text = NameEn;
        }
        if (Language == "Es"){
            Name.text = NameEs;
        }
    }
    public void SetNames(){

        if (Language == "Ru"){
        PlayerPrefs.SetString("Name", NameRu);
        PlayerPrefs.SetString("Descr", DescrRu);
        PlayerPrefs.SetString("FolderOfImages", FolderName);
        }
        if (Language == "En"){
        PlayerPrefs.SetString("Name", NameEn);
        PlayerPrefs.SetString("Descr", DescrEn);
        PlayerPrefs.SetString("FolderOfImages", FolderName);
        }
        if (Language == "Es"){
        PlayerPrefs.SetString("Name", NameEs);
        PlayerPrefs.SetString("Descr", DescrEs);
        PlayerPrefs.SetString("FolderOfImages", FolderName);
        }
    }
}
