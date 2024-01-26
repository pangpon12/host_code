using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class plan_value : MonoBehaviour
{   public TMP_Text m_TextComponent;

    public string word;

    public bool  is_it_right;


    private void Awake()
    {
        // Get a reference to the text component.
        // Since we are using the base class type <TMP_Text> this component could be either a <TextMeshPro> or <TextMeshProUGUI> component.
        m_TextComponent = GetComponentInChildren<TMP_Text>();
 
        // Change the text on the text component.
    }

      void Update()
{
        m_TextComponent.text = word;


}

}
