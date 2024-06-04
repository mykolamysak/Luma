using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
    public string urlToOpen; 

    public void OnClick()
    {
        Application.OpenURL(urlToOpen);
    }
}
