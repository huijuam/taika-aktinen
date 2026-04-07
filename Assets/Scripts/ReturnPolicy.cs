using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ReturnPolicy : MonoBehaviour, IPointerClickHandler
{
    public string targetScene = "MainMenu";

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(targetScene);
    }
}
