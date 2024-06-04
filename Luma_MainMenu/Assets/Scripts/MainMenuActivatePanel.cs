using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuActivatePanel : MonoBehaviour
{
    public GameObject panelToActivate;

    private void Start()
    {
        // Установити активність панелі при запуску сцени
        panelToActivate.SetActive(true);

        // Запустити корутину, яка вимкне панель через 1 секунду
        StartCoroutine(Disable());
    }

    private IEnumerator Disable()
    {
        // Затримка на 1 секунду
        yield return new WaitForSeconds(1f);

        // Вимкнути панель
        panelToActivate.SetActive(false);
    }
}
