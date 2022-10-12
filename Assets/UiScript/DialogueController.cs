using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public TextEffector tx;
    string[] testwords = new string[4]{
        "What the fuck","Are u kidding me","I'm thirsty","Get a bottle of Coke for me, plz"
    };

    void Start(){
        tx.startASentence(testwords[0]);
    }

    int cursor = 0;
    void Update(){
        if(!tx.getComplete() && Input.GetKeyDown(KeyCode.J)){
            tx.fastForward();
        }
        else if(tx.getComplete() && Input.GetKeyDown(KeyCode.J)){
            cursor += 1;
            if (cursor < 4){
                tx.startASentence(testwords[cursor]);
            }
        }

    }
}
