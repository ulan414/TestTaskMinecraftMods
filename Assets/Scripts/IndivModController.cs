using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;


public class IndivModController : MonoBehaviour
{
    public TextMeshProUGUI ModName;
    public TextMeshProUGUI ModDescr;
    private string Name = "";
    public Image imagePrefab;
    public GameObject imageParent;
    private string folderName;
    //public string fileName = "Mod_1/descriptionRU";
    // Start is called before the first frame update
    void Start()
    {
        Name = PlayerPrefs.GetString("Name", "Unknown");
        ModName.text = Name;
        // TextAsset textFile = Resources.Load<TextAsset>(fileName);
        ModDescr.text = PlayerPrefs.GetString("Descr", "Unknown");
        folderName  = PlayerPrefs.GetString("FolderOfImages", "Mod_1");
        LoadImagesFromFolder(folderName);
    }

      void LoadImagesFromFolder(string folder)
    {
        Texture2D[] textures = Resources.LoadAll<Texture2D>(folder);

        if (textures.Length > 0)
        {
             RectTransform parentRect = imageParent.GetComponent<RectTransform>();
            float totalWidth = textures.Length * (622 + 10);

            parentRect.sizeDelta = new Vector2(totalWidth, parentRect.sizeDelta.y);
            for (int i = 0; i < textures.Length; i++)
            {
                Image newImage = Instantiate(imagePrefab, imageParent.transform);
                Sprite sprite = Sprite.Create(textures[i], new Rect(0, 0, textures[i].width, textures[i].height), new Vector2(0.5f, 0.5f));

                newImage.sprite = sprite;
                newImage.gameObject.name = (i + 1).ToString();
                RectTransform rectTransform = newImage.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2(i * 622 - 2503 - (totalWidth - 5113)/2, rectTransform.anchoredPosition.y);
            }
        }
        else
        {
            Debug.LogError("No images found in folder: " + folder);
        }
    }
}
