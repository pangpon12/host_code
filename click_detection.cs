using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class click_detection : MonoBehaviour
{
       public string scenePaths;

   public bool is_game_end;


    private word word_script;


    public GameObject plant_1;
    public GameObject plant_2;

public plan_value plan_value_1;
public plan_value plan_value_2;




   public string[] word_wrong_;
   public string[] word_right_;


public string plan_word_1;

public string plan_word_2;


public int current_list = 0;
public int current_word = 0;



public List<int> numbers__ = new List<int>();



    // Start is called before the first frame update
      void Start()
    {



        word_script =GetComponent<word>();

        plan_value_1 = plant_1.GetComponent<plan_value>();
        plan_value_2 = plant_2.GetComponent<plan_value>();

    word_wrong_ =   word_script.word_wrong;
     word_right_ =   word_script.word_right;
 numbers__ = word_script.numbers;

      
      update_list_word();
    }


    // Update is called once per frame
   void Update()
{


if(is_game_end == true || word_script.healt <= 0 || word_script.time <= 0){

   int totalscore = current_list - 1;

   score_data.totalscore = totalscore;
   Debug.Log("game end your score is :" + totalscore);
            SceneManager.LoadScene(scenePaths);

}



   
   if (Input.GetMouseButtonDown(0))
   {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

      if (hit.collider != null) {

         if(
            hit.collider.GetComponent<plan_value>().is_it_right

         )
         {
            Debug.Log("hello");

                  update_list_word();

         }else{
            word_script.healt -= 1;
         };





         
      }
   }

    }




  public  void update_list_word(){
  int random =  Random.Range(0,2);

 
      current_list += 1;

if(current_list < 10){


current_word = numbers__[current_list];

  //  numbers__ = word_script.numbers;
   plan_word_1 = word_wrong_[current_word];
    plan_word_2= word_right_[current_word];



 if(random == 0){

plan_value_1.word = plan_word_1;
plan_value_1.is_it_right = false;


plan_value_2.word = plan_word_2;
plan_value_2.is_it_right = true;

  }
  else{

plan_value_2.word = plan_word_1;
plan_value_2.is_it_right = false;

plan_value_1.word = plan_word_2;
plan_value_1.is_it_right = true;

  }

}
else{
   is_game_end = true;

}





      
    }
}
