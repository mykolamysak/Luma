using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartActivatePanel : MonoBehaviour
{
    public GameObject panelToActivate;
    public GameObject panelToActivate2;

    private void Start()
    {
        // ���������� ��������� ����� ��� ������� �����
        panelToActivate.SetActive(true);

        // ��������� ��������, ��� ������ ������ ����� 1 �������
        StartCoroutine(DisablePanel());
    }

    private IEnumerator DisablePanel()
    {
        // �������� �� 1 �������
        yield return new WaitForSeconds(1f);

        // �������� ������
        panelToActivate.SetActive(false);
        panelToActivate2.SetActive(true);
    }
}
