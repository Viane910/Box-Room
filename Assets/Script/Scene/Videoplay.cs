using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Videoplay : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        // Mendapatkan komponen VideoPlayer
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer == null)
        {
            Debug.LogError("VideoPlayer tidak ditemukan pada GameObject ini!");
            return;
        }

        // Menambahkan listener untuk event selesai memutar video
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        // Berpindah ke scene "SampleScene" saat video selesai
        SceneManager.LoadScene("SampleScene");
    }

    void OnDestroy()
    {
        // Membersihkan listener ketika objek dihancurkan
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= OnVideoFinished;
        }
    }
}
