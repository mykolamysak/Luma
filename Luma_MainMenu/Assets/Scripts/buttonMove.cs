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

    // --- ������ ������
    private CursorMode cursorMode = CursorMode.Auto;
    public Texture2D cursorTexture;
    // ---

    void Start()
    {
        // ��������� �� RectTransform �� �����
        rectTransform = GetComponent<RectTransform>();
        button = GetComponent<Button>();

        // ��������� ������� ������
        originalPosition = rectTransform.anchoredPosition;
        targetPosition = originalPosition + offset;
    }

    void Update()
    {
        // ���������� � ��������
        if (isAnimating)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / animationDuration);
            rectTransform.anchoredPosition = Vector2.Lerp(originalPosition, targetPosition, t);

            // ����� �������
            if (timer >= animationDuration)
            {
                isAnimating = false;
                timer = 0f;
            }
        }
        else if (!isHovered)
            // ���������� ������ �� ��������� ������� � ��������
            rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, originalPosition, Time.deltaTime / animationDuration);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // ������� ������� ��� ��������
        if (!isAnimating)
        {
            isHovered = true;
            isAnimating = true;
            Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // �������� ��������� �������
        isHovered = false;
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
