using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ActorSO : MonoBehaviour
{
    public GameObject dialogueUI; // Canvas untuk dialog
    public GameObject McZoomUI; //RINAL Zoom
    [SerializeField] private TMP_Text speakerText; // Text untuk nama pembicara
    [SerializeField] private TMP_Text dialogueText; // Text untuk dialog
    [SerializeField] private Image portraitImage; // Gambar potret pembicara

    // Dialogue Content
    [SerializeField] private string[] speaker; // Array nama pembicara
    [SerializeField][TextArea] private string[] dialogueWords; // Array dialog
    [SerializeField] private Sprite[] portrait; // Array gambar potret (boleh kosong jika tidak ada potret)

    private bool dialogueActivated = false; // Apakah dialog sedang aktif
    private int step = 0; // Langkah dialog saat ini

    void Start()
    {
        StartDialogue();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Klik kiri mouse
        {
            if (!dialogueActivated)
            {
                // Aktifkan dialog dan mulai dari langkah pertama
                StartDialogue();
            }
            else
            {
                // Maju ke langkah berikutnya
                step++;
                if (step < dialogueWords.Length)
                {
                    ShowDialogueStep();
                }
                else
                {
                    // Akhiri dialog ketika semua selesai
                    EndDialogue();
                }
            }
        }
    }

    void StartDialogue()
    {
        dialogueUI.SetActive(true); // Aktifkan UI dialog
        dialogueActivated = true;
        step = 0; // Mulai dari langkah pertama
        ShowDialogueStep();
    }

    private void ShowDialogueStep()
    {
        // Tampilkan dialog pada langkah tertentu
        speakerText.text = speaker[step];
        dialogueText.text = dialogueWords[step];

        // Jika ada potret, tampilkan; jika tidak, sembunyikan
        if (portrait != null && step < portrait.Length && portrait[step] != null)
        {
            portraitImage.sprite = portrait[step];
            portraitImage.gameObject.SetActive(true); // Aktifkan potret
        }
        else
        {
            portraitImage.gameObject.SetActive(false); // Sembunyikan potret
        }
    }

    private void EndDialogue()
    {
        // Nonaktifkan UI dialog dan reset variabel
        dialogueUI.SetActive(false);
        dialogueActivated = false;
        Destroy(dialogueUI);
        McZoomUI.SetActive(true);
    }

}
