using NUnit.Framework.Constraints;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    bool isPlaying = false;
    string currentSong = "";
    public int currentVolume = 1;
    public int newVolumeLevel = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("playing : Know my Legend by Gareth Coker");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            SetVolume(GetVolume() + 1);
            // volume up
        }

        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            SetVolume(GetVolume() - 1);
            //volume down
            
        }

        void PlaySong(string songName)
        {
            Debug.Log("Started " + songName);
            currentSong = songName;
            isPlaying = true;
        }
        void StopSong()
        {
            Debug.Log("Stopped " + currentSong);
            currentSong = "";
            isPlaying = false;
        }
        void SetVolume(int volume)
        {
            if (volume > 0 && volume <= 100)
            {
                Debug.Log("Volume is now set to :" + volume);
                currentVolume = volume;
            }
            else
            {
                Debug.Log("This volume level is not possible");
            }
        }
        int GetVolume() {
            return currentVolume;
        }
        string GetCurrentSong() {
            return currentSong;
        }
        bool IsPlaying() {
            return isPlaying;
        }
    }
}
