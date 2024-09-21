using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DownloadManager : MonoBehaviour
{
    public RectTransform Fill; 
    public TextMeshProUGUI progressText; 
    public float maxWidth = 5.34f; 
    public float totalTime = 5f; 

    private float elapsedTime = 0f; 
    private bool isDownloading = true;
    public GameObject Canvas;
    void Update()
    {
        if (isDownloading)
        {
            elapsedTime += Time.deltaTime;
            float progress = Mathf.Clamp01(elapsedTime / totalTime);
            float newWidth = Mathf.Lerp(0, maxWidth, progress);

            Fill.sizeDelta = new Vector2(newWidth, Fill.sizeDelta.y);

            int progressPercent = Mathf.RoundToInt(progress * 100);
            progressText.text = progressPercent.ToString() + "%";
            if (progress >= 1f)
            {
                isDownloading = false; 
                Canvas.SetActive(true);
            }
        }
    }
     public void ResetDownload()
    {
        elapsedTime = 0f;            
        isDownloading = true;       
        Fill.sizeDelta = new Vector2(0, Fill.sizeDelta.y); 
        progressText.text = "0%";    
    }
}
