using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{[SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    [SerializeField]
    float width = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 Paddlepose = new Vector2(transform.position.x, transform.position.y);
        Paddlepose.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = Paddlepose;


    }
    
    public float GetXPos()
    {
        if (FindObjectOfType<GameSession>().Autoplay())
        {
            return FindObjectOfType<ball>().transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * width;
        }
    }
   
    }

   


