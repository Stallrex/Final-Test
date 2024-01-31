using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Set : MonoBehaviour
{
    SpriteRenderer rendering;
    int Background_ID = 0;

    public Sprite Background_1;
    public Sprite Background_2;
    public Sprite Background_3;
    public Sprite Background_4;
    public Sprite Background_5;
    
    // Start is called before the first frame update
    void Start()
    {
        rendering = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Background_ID = Stage_Select.Background;
        ChangeBackground();
    }

    void ChangeBackground()
    {
        if(Background_ID == 1){
            rendering.sprite = Background_1;
        }
        if(Background_ID == 2){
            rendering.sprite = Background_2;
        }
        if(Background_ID == 3){
            rendering.sprite = Background_3;
        }
        if(Background_ID == 4){
           rendering.sprite = Background_4;
        }
        if(Background_ID == 5){
            rendering.sprite = Background_5;
        }
    }
}
