using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opening : MonoBehaviour
{
    public Image FadImg;
    // Start is called before the first frame update
    void Start()
    {
        FadImg = GetComponent<Image>();
        StartCoroutine(FadIn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator FadIn()
    {
        for (int i = 0; i < 20; i++)
        {
            FadImg.color -= new Color(0, 0, 0, 0.05f);
            yield return new WaitForSeconds(0.05f);
        }

    }
}
