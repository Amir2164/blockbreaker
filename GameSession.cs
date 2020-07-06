using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
     

public class GameSession : MonoBehaviour
{ //parameter hay shekl bandi
    [Range(0.8f,10)] public float Gamespeed=0.8f;
    public int pointperblockdestroyed = 10;
    public TextMeshProUGUI scoretext;
    [SerializeField]
    bool autoplay;
    //amar
    public int currentscores = 0;
    // before start
    public void Awake()
    {
        int gamestatuescount = FindObjectsOfType<GameSession>().Length;//matboot be nabood nashodan baad az tamoom shodan scene
        if (gamestatuescount > 1)
        {
            gameObject.SetActive(false); // مربوط به یک باگ
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        scoretext.text = currentscores.ToString(); // marboot be neshan dadan score dar Ui
    }
    void Update()
    {
        Time.timeScale = Gamespeed; // marboot be soraat
    }
    //marboot be jam kardan emtiaz ha
    public void Addingupponts()
    {
        currentscores = currentscores + pointperblockdestroyed;
        scoretext.text = currentscores.ToString(); //اسکور تکست در یو جی ای در زمان نابود شدن هر انمی
    }
    // مربوط به صفر شدن اسکور ها بعد از شروع دوباره 
    public void resetgame()
    {
        Destroy(gameObject);
    }
    public bool Autoplay()
    {

        return autoplay;
    }
}
