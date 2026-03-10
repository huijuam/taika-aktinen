using UnityEngine;

public class MaMeMa : MonoBehaviour
{
    public FadeControl fadeControl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeControl.gameObject.SetActive(true);
        fadeControl.FadeOut();
    }
}
