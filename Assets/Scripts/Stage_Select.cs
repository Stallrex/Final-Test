using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Cecil.Cil;

public class Stage_Select : MonoBehaviour
{
    SpriteRenderer rendering;
    Button button_sprite;
    public Sprite Button_Showcase_1;
    public Sprite Button_Showcase_2;
    public Sprite Button_Showcase_3;
    public Sprite Button_Showcase_4;
    public Sprite Button_Showcase_5;
    public int Background_ID;

    public static int Background;

    // Start is called before the first frame update
    void Start()
    {
        rendering = GetComponent<SpriteRenderer>();
        button_sprite = GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Background = Background_ID;
        Show_Case_Button();
    }
     public void Show_Case_Button(){
        if(Background_ID == 1){
            button_sprite.image.sprite = Button_Showcase_1;
        }
        if(Background_ID == 2){
            button_sprite.image.sprite = Button_Showcase_2;
        }
        if(Background_ID == 3){
            button_sprite.image.sprite = Button_Showcase_3;
        }
        if(Background_ID == 4){
            button_sprite.image.sprite = Button_Showcase_4;
        }
        if(Background_ID == 5){
            button_sprite.image.sprite = Button_Showcase_5;
        }
    }
}
