using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class exitHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image image; // Image component to change
    public Sprite yesExit; // Sprite for YesButton
    public Sprite noExit; // Sprite for NoButton
    public Sprite idleExit; // Sprite for idle state

    public enum ButtonType
    {
        YesButton,
        NoButton
    }

    public ButtonType buttonType;

    private void Start()
    {
        // Set the initial image to idleExit
        if (image != null)
        {
            image.sprite = idleExit;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Change image based on button type when the pointer enters
        if (image != null)
        {
            switch (buttonType)
            {
                case ButtonType.YesButton:
                    image.sprite = yesExit;
                    break;
                case ButtonType.NoButton:
                    image.sprite = noExit;
                    break;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Change image to idleExit when the pointer exits
        if (image != null)
        {
            image.sprite = idleExit;
        }
    }
}
