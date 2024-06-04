using UnityEngine;
using UnityEngine.EventSystems;

public class LocationPanelHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject locationInfoPanel;
    private Animation locationInfoPanelAnimation;

    public GameObject locationInfoPanelBack;
    private Animation locationInfoPanelAnimationBack;


    public void OnPointerEnter(PointerEventData eventData)
    {
    locationInfoPanelBack.SetActive(false);
      locationInfoPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      locationInfoPanel.SetActive(false);
      locationInfoPanelBack.SetActive(true);
    }
}
