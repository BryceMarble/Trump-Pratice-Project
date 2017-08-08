using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    int i = 0;
    // not sure what this is
    public AudioSource[] quotes;
    // source of all audio clips
    public AudioClip[] quoteList;


    // at start of app
    void Start()
    {
        Debug.Log("App Started");
        quoteList = Resources.LoadAll<AudioClip>("Audio/");
        Debug.Log(quoteList[0]);
    }
    // when button is clicked
    void OnMouseDown()
    {
        AudioSource audio = GetComponent<AudioSource>();

        int clipvalue = (int)(Random.value * quoteList.Length);
        print(clipvalue);
        audio.clip = quoteList[clipvalue];

        Debug.Log(quoteList);

        audio.Play();

        GetComponent<SpriteRenderer>().sprite = Resources.Load("buttons/pressed", typeof(Sprite)) as Sprite;

        //yield return new WaitForSeconds(.2F);
        //GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/unpressed", typeof(Sprite)) as Sprite;
    }

    void OnMouseUp()
    {

        GetComponent<SpriteRenderer>().sprite = Resources.Load("buttons/unpressed", typeof(Sprite)) as Sprite;
    }
}





    
    









    // private void Update() {
    // }

    // void OnMouseDown () { 

    //  Button button = this.GetComponent<Button>();
    //button.onClick.RemoveAllListeners();
    //button.onClick.AddListener(WhenClicked);

    //{

    //    }
    // when clicked this action takes place
    //  void WhenClicked()
    //{
    //  Debug.Log("Button Clicked");



    // }



