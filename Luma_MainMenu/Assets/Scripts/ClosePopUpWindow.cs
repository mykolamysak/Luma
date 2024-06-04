using UnityEngine;

public class ClosePopUpWindow : MonoBehaviour
{
    public GameObject window;

    public void OnClick()
    {
        Invoke("HideMainContainer", 0.2f);
    }

    private void HideMainContainer()
    {
        window.GetComponent<Animator>().SetTrigger("hide");

        Invoke("DisableLearnAboutUsWindow", 0.2f);
    }

    private void DisableLearnAboutUsWindow()
    { 
        window.SetActive(false);
    }
}
