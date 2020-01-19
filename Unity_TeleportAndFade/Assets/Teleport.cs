using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public Collider Cube;
    public Image FadImg;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.Find("Cube").GetComponent<Collider>();
        FadImg = GameObject.Find("轉場效果").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "玩家")
        {
            StartCoroutine((Faded()));
            
        }
    }
    private IEnumerator Faded()
    {
        for (int i = 0; i < 20; i++)
        {
            FadImg.color += new Color(0, 0, 0, 0.05f);
            yield return new WaitForSeconds(0.05f);
        }
        SceneManager.LoadScene("第二關");
    }
}
