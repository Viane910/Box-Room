using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class NewBehaviourScript : MonoBehaviour
{
    // Reference ke VideoPlayer
    public VideoPlayer videoPlayer;

    // Nama scene yang akan diload
    public string sceneName = "MainMenu";

    void Start()
    {
        // Pastikan videoPlayer terhubung
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // Subscribes ke event yang dipanggil saat video selesai
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    // Callback ketika video selesai diputar
    private void OnVideoFinished(VideoPlayer vp)
    {
        // Load scene ke MainMenu
        SceneManager.LoadScene(sceneName);
    }
}
