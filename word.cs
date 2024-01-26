using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class word : MonoBehaviour
{
    
   public string[] word_wrong;
   public string[] word_right;


public List<string> word__ = new List<string>();
public List<string> word__2 = new List<string>();


    public float timeRemaining;
public TMP_Text timeCounter;

public List<int> numbers = new List<int>();


   public int time;
   public int healt;

    public  List<GameObject> children;

   void Start()
    {
 children = gameObject.GetChildren();

NewNumber(14);
NewNumber(14);
NewNumber(14);
NewNumber(14);
NewNumber(14);
NewNumber(14);
NewNumber(14);
NewNumber(14);
NewNumber(14);
NewNumber(14);
    }
void  Update()
{

       if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
           time = (int)timeRemaining;

    timeCounter.text  = time.ToString();



         for (int i = 0; i <  children.Count; i++)
        {
            if (i < healt)
            {
                  children[i].SetActive(true);
            }
            else
            {
            children[i].SetActive(false);
            }


        }
}


public int NewNumber(int r) {

    int a = 0;

    while(a==0){    
        a = Random.Range (0, r);
        if(!numbers.Contains(a)) {
            numbers.Add(a);
        }else{
            a=0;
        }
    }
    return a;
}

   
}
