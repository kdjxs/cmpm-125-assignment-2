using UnityEngine;
using UnityEngine.UI;

public class coinManager : MonoBehaviour
{
    public int coinCount;
    public Text coinText;


    // Update is called once per frame
    void Update()
    {
        coinText.text = "Score: " + coinCount.ToString();
    }
}
