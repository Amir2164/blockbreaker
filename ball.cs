
using UnityEngine;

public class ball : MonoBehaviour
{ // parametr hay shekl bandi
  public Paddle Paddle1;Vector2 PaddletoBall;
  public float xPush;
  public float ypush;
  public
  AudioClip[] ballsounds;
  public float Randomfactors = 0.2f; // for randomness of boll direction 
    //stats
    bool hasstarted = false;
    //cached component reference 
    AudioSource myAudioSource;
    Rigidbody2D myRigidbody2d;   
    void Start()
    {
        PaddletoBall = transform.position - Paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        myRigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {if (!hasstarted){
            LockballtoPaddle();
            lunchOnMouseClick();
        }
    }

    private void lunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasstarted = true;
           myRigidbody2d.velocity= new Vector2(xPush, ypush);
        }
    }

    private void LockballtoPaddle()
    {
        Vector2 Paddlepos = new Vector2(Paddle1.transform.position.x, Paddle1.transform.position.y);
        transform.position = Paddlepos + PaddletoBall;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {// barai random kardan harekat toop
        Vector2 Velocitytweak = new Vector2(Random.Range(0f, Randomfactors), Random.Range(0f, Randomfactors));
        if (hasstarted)
        {
            AudioClip clip = ballsounds[UnityEngine.Random.Range(0, ballsounds.Length)];
            myAudioSource.PlayOneShot(clip);
            myRigidbody2d.velocity += Velocitytweak;
        }
    }
}

