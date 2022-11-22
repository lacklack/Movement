using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tipMessage;
    private float waitingTime = 0.5f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(StartTimer());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        HoverTipManager.OnMouseLoseFocus();
    }

    private void ShowMessage()
    {
        HoverTipManager.OnMouseHover(tipMessage);
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(waitingTime);

        ShowMessage();
    }
}
