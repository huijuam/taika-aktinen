using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelScroll : MonoBehaviour
{

    public Image SelectedLevel;
    public Image RightLevel;
    public Image LeftLevel;

    public Sprite[] levelImages;
    public int currentLevelIndex = 0;
    public int currentIndex;

    void Update()
    {
        SelectedLevel.sprite = levelImages[currentIndex % levelImages.Length];
        RightLevel.sprite = levelImages[(currentIndex + 1) % levelImages.Length];
        RightLevel.sprite = levelImages[(currentIndex - 1) % levelImages.Length];


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
        }

         if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Kaikista vaihtoehdoista otit sitte " + levelImages[currentIndex].name);
        }
    }
}
