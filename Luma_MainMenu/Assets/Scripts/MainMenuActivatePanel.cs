using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuActivatePanel : MonoBehaviour
{
    public GameObject panelToActivate;

    private void Start()
    {
        // ���������� ��������� ����� ��� ������� �����
        panelToActivate.SetActive(true);

        // ��������� ��������, ��� ������ ������ ����� 1 �������
        StartCoroutine(Disable());
    }

    private IEnumerator Disable()
    {
        // �������� �� 1 �������
        yield return new WaitForSeconds(1f);

        // �������� ������
        panelToActivate.SetActive(false);
    }
}
