using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeightController : MonoBehaviour
{
    RectTransform parentRectTransform;
    public float minHeight = 240f;
    public float maxHeight = 300f;
    public float lerpSpeed = 5f;
    private float minX = 0;
    private float maxX = 0;
    RectTransform rectTransform;
    private float position = 0;
    public Color grayColor = new Color32(103, 103, 103, 255); // Gray color (676767)
    public Color whiteColor = Color.white;
    private Image imageToChange;  
    void Start()
    {
        parentRectTransform = transform.parent as RectTransform;
        rectTransform = GetComponent<RectTransform>();
        string objectName = gameObject.name;
        int objectNumber;
        if (int.TryParse(objectName, out objectNumber))
        {
            Debug.Log("numb:" + objectNumber);
        }
        position = objectNumber - 1;
        maxX = -360 - (position - 1) * 622;
        minX = maxX - 622;
        imageToChange = GetComponent<Image>();
        Vector2 sizeDelta = rectTransform.sizeDelta;
        if (position == 1){
            sizeDelta.y = 300;
            imageToChange.color = whiteColor;
        }else{
            sizeDelta.y = 240;
            imageToChange.color = grayColor;
        }
        rectTransform.sizeDelta = sizeDelta;

    }
    void Update()
    {
         if (parentRectTransform.localPosition.x <= maxX && parentRectTransform.localPosition.x >= minX ){
            float normalizedPosition = Mathf.InverseLerp(maxX, minX, parentRectTransform.localPosition.x);
            float targetHeight = Mathf.Lerp(minHeight, maxHeight, normalizedPosition);
            Color targetColor = Color.Lerp(grayColor, whiteColor, normalizedPosition);
            imageToChange.color = Color.Lerp(imageToChange.color, targetColor, Time.deltaTime * lerpSpeed);
            Vector2 sizeDelta = rectTransform.sizeDelta;

            sizeDelta.y = Mathf.Lerp(sizeDelta.y, targetHeight, Time.deltaTime * lerpSpeed);

            rectTransform.sizeDelta = sizeDelta;
        }
            if (parentRectTransform.localPosition.x <= maxX-622 && parentRectTransform.localPosition.x >= minX-622 ){
            float normalizedPosition = Mathf.InverseLerp(minX-622, maxX-622, parentRectTransform.localPosition.x);
            float targetHeight = Mathf.Lerp(minHeight, maxHeight, normalizedPosition);

            Vector2 sizeDelta = rectTransform.sizeDelta;

            sizeDelta.y = Mathf.Lerp(sizeDelta.y, targetHeight, Time.deltaTime * lerpSpeed);
            rectTransform.sizeDelta = sizeDelta;
        }
    }
}
