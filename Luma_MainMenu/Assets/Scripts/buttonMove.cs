using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveButtonOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform rectTransform;
    private Button button;

    private Vector2 originalPosition;
    private Vector2 targetPosition;
    private Vector2 offset = new Vector2(30f, 0f);
    private float animationDuration = 0.3f;
    private float timer = 0f;
    private bool isHovered = false;
    private bool isAnimating = false;

    // --- додати курсор
    private CursorMode cursorMode = CursorMode.Auto;
    public Texture2D cursorTexture;
    // ---

    void Start()
    {
        // посилання на RectTransform та кнопк
        rectTransform = GetComponent<RectTransform>();
        button = GetComponent<Button>();

        // початкова позиція кнопки
        originalPosition = rectTransform.anchoredPosition;
        targetPosition = originalPosition + offset;
    }

    void Update()
    {
        // переміщення з анімацією
        if (isAnimating)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / animationDuration);
            rectTransform.anchoredPosition = Vector2.Lerp(originalPosition, targetPosition, t);

            // кінець анімації
            if (timer >= animationDuration)
            {
                isAnimating = false;
                timer = 0f;
            }
        }
        else if (!isHovered)
            // повернення кнопки на початкову позицію з анімацією
            rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, originalPosition, Time.deltaTime / animationDuration);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // початок анімації при наведенні
        if (!isAnimating)
        {
            isHovered = true;
            isAnimating = true;
            Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // скидання наведення курсору
        isHovered = false;
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
