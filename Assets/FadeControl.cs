using UnityEngine;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour
{

    public float fadeDuration = 1f;

    private Image FadeObject;
    private Color originalColor;

    void Awake()
    {
        FadeObject = GetComponent<Image>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
