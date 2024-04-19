using System.Collections;
    public RawImage preview;
    // Start is called before the first frame update
    void Start()
        NativeControl.Instance();  
    {
        StartCoroutine(PreparePreview());
    }
    {
        yield return new WaitForEndOfFrame();
        Texture2D screenImage = new Texture2D(Screen.width, Screen.height);
        //Get Image from screen
        screenImage.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenImage.Apply();
        preview.texture = screenImage;
    {
        Debug.Log("####SaveImageLocation#### " + path);
    }

    /// <summary>
    {
        switch (_status)
                NativeControl.Instance().ShowToast("GPS Start", ToastLenght.LENGTH_LONG);

            case "stop":
            NativeControl.Instance().CheckLocationService();
        }
    }
    {
        switch(location_status)
        {
            case "true":

            case "false":
                GPSStatusTxt.text = "Mobile location service/GPS is not start";
                break;
        }
    }
    {
        NativeControl.Instance().ShowToast("Hello, Great Work!!!", ToastLenght.LENGTH_LONG);
    }
}    