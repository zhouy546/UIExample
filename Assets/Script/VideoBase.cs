using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoBase : MonoBehaviour {
    public RawImage rawImage;

    private VideoPlayer videoPlayer;

    private RenderTexture movie;

    protected string path =" http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";
    // Use this for initialization
    void Start () {
        initialization();
        playVideo();
    }
	
	// Update is called once per frame
	void Update () {
        rawImage.texture = videoPlayer.texture;

    }

    void initialization() {
       rawImage = GetComponent<RawImage>();

        videoPlayer = this.GetComponent<VideoPlayer>();

        videoPlayer.renderMode = VideoRenderMode.APIOnly;

        videoPlayer.source=VideoSource.Url;

        videoPlayer.playOnAwake=false;

        path = Application.streamingAssetsPath +"/"+ "SampleVideo.mp4";       
        
        videoPlayer.url = path;

    }

    public void playVideo() {
        videoPlayer.Play();
    }

    public void StopVideo() {
        videoPlayer.Stop();
    }
}
