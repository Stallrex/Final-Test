using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class ButtonClick : MonoBehaviour
{

    Button button_sprite;
    SpriteRenderer rendering;
    public Sprite Button_Start_Up;
    public Sprite Button_Start_Down;
    public Sprite Button_Next_Up;
    public Sprite Button_Next_Down;
    public Sprite Button_Previous_Up;
    public Sprite Button_Previous_Down;
    public Sprite Button_Dummy_Up;
    public Sprite Button_Dummy_Down;
    public Sprite Button_AI_Up;
    public Sprite Button_AI_Down;

    [SerializeField] private Stage_Select Stage_Select_Script;


    // Start is called before the first frame update
    void Start()
    {
        button_sprite = GetComponent<Button>();
        rendering = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

   

    public void Start_Button(){
        button_sprite.image.sprite = Button_Start_Down;
        Invoke("Start_Button_Reset", 1);
        SceneManager.LoadScene(1);
    }

    public void Start_Button_Reset(){

    button_sprite.image.sprite = Button_Start_Up;    
    }

    public void Dummy_Button(){
        button_sprite.image.sprite = Button_Dummy_Down;
        Enemy_ID.Enemy = 1;
        Invoke("Dummy_Button_Reset", 1);
    }

    public void Dummy_Button_Reset(){

    button_sprite.image.sprite = Button_Dummy_Up;    
    }

    public void AI_Button(){
        button_sprite.image.sprite = Button_AI_Down;
        Enemy_ID.Enemy = 2;
        Invoke("AI_Button_Reset", 1);
    }

    public void AI_Button_Reset(){

    button_sprite.image.sprite = Button_AI_Up;    
    }







    public void Next_Button(){
    if(Stage_Select_Script.Background_ID < 5){
        Stage_Select_Script.Background_ID += 1;
        
    }
    else{
        Stage_Select_Script.Background_ID = 1;
    }
    
    button_sprite.image.sprite = Button_Next_Down;
    Invoke("Next_Button_Reset", 1);
    }

    public void Next_Button_Reset(){

    button_sprite.image.sprite = Button_Next_Up;    
    }
    public void Previous_Button(){
    if(Stage_Select_Script.Background_ID != 1){
        Stage_Select_Script.Background_ID -= 1;
        
    }
    else{
        Stage_Select_Script.Background_ID = 5;
    }
    button_sprite.image.sprite = Button_Previous_Down;
    Invoke("Previous_Button_Reset", 1);
    }

    public void Previous_Button_Reset(){

    button_sprite.image.sprite = Button_Previous_Up;    
    }

}
