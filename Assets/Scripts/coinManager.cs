using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinManager : MonoBehaviour
{
    public int coinCount;
    public TextMeshProUGUI coinText;

    void Start()
    {
        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //coinText.text = "Score: " + coinCount.ToString();
         coinText.text = string.Format("Score: {0}", (coinCount));
    }

}
