using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartActivatePanel : MonoBehaviour
{
    public GameObject panelToActivate;
    public GameObject panelToActivate2;

    private void Start()
    {
        // Установити активність панелі при запуску сцени
        panelToActivate.SetActive(true);

        // Запустити корутину, яка вимкне панель через 1 секунду
        StartCoroutine(DisablePanel());
    }

    private IEnumerator DisablePanel()
    {
        // Затримка на 1 секунду
        yield return new WaitForSeconds(1f);

        // Вимкнути панель
        panelToActivate.SetActive(false);
        panelToActivate2.SetActive(true);
    }
}
