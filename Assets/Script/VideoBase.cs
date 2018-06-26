using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using RenderHeads.Media.AVProVideo;

[RequireComponent(typeof(MediaPlayer))]
[RequireComponent(typeof(Image))]
[RequireComponent(typeof(NImage))]
public class VideoBase : MonoBehaviour {
    protected NImage nImage;

    protected MediaPlayer mediaPlayer;

    public float currentTime;

    public float durationTime;

    protected string path;   
    // Use this for initialization
    void Start () {

        initialization();

        setSlider(.5f);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void initialization() {
        path = "SampleVideo.mp4";

        nImage = this.GetComponent<NImage>();

        mediaPlayer = this.GetComponent<MediaPlayer>();

        mediaPlayer.m_VideoLocation = MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder;

        mediaPlayer.m_VideoPath = path;

        mediaPlayer.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, path ,true);

    }

    public void SetVideoPath(string str) {
        path = Application.streamingAssetsPath + "/" + str;
    }

    public void playVideo() {
        mediaPlayer.Play();
    }

    public void StopVideo() {
        mediaPlayer.Stop();
    }

    public void PauseVideo() {
        mediaPlayer.Pause();
    }

    public void SetMovieTime(float value) {
        float temp = nImage.Mapping(value, 0f, 1f, 0, getCurrentTime());
        mediaPlayer.Control.Seek(temp);
    }

    public void ShowVideo(float time) {
        nImage.ShowAll(time);
    }

    public void HideVideo(float time) {
        nImage.HideAll(time);
    }

    public void PopUp() {
        nImage.SetScale(Vector3.one, 1f);
    }

    public void ShinkDown() {
        nImage.SetScale(Vector3.zero, 1f);
    }

    float getCurrentTime() {
        return mediaPlayer.Control.GetCurrentTimeMs() / 1000f;
    }

    float getDurationTime() {
        return mediaPlayer.Info.GetDurationMs() / 1000f;
    }


    public void setSlider(float value) {
       // Debug.Log(getCurrentTime());

        mediaPlayer.Pause();

        float temp =    nImage.Mapping(value, 0f, 1f, 0f, getDurationTime()) * 1000;

        mediaPlayer.Control.Seek(temp);

        mediaPlayer.Play();
    }

}
