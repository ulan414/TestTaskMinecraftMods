using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement; 
using System.Collections;

public class ClickAndScrollHandler : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler
{
    public IndivModManager modManager; 
    public ScrollRect scrollRect;     
    public Animator transition;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (modManager != null)
        {
            modManager.SetNames();
            StartCoroutine(LoadLevel("IndividualMod"));
            Debug.Log("Image clicked: SetNames() called");
        }
    }
    IEnumerator LoadLevel(string sceneName){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (scrollRect != null)
        {
            scrollRect.OnBeginDrag(eventData);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (scrollRect != null)
        {
            scrollRect.OnDrag(eventData);
        }
    }
}
