using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display_score : MonoBehaviour
{

        public Text  display_score_txt;

    // Start is called before the first frame update
    void Start()
    {
            display_score_txt.text  = score_data.totalscore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
