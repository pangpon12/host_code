using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_link : MonoBehaviour
{
       public string scenePaths;
       public bool is_this_back_btn;

 private AudioSource _audioSource;
    private void Awake()
    {
      
if(is_this_back_btn == true){



}
else{ 


   DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();

          PlayMusic();

}
    }

    // Update is called once per frame
  public  void btn()
    {

         score_data.totalscore = 0;

            SceneManager.LoadScene(scenePaths);

    }

        public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
