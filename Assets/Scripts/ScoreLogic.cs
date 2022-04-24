using UnityEngine;
using UnityEngine.UI;


public class ScoreLogic : MonoBehaviour
{
    public int Score = 0;
    void Update()
    {
        GetComponent<Text>().text= "Score : " + Score;
    }
}
