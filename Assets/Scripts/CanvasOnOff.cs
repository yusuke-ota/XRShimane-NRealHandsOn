using UnityEngine;

public class CanvasOnOff : MonoBehaviour
{
    private Transform _button;
    private Transform _image;
    private GameObject _rawImage;
    private void Start()
    {
        _button = gameObject.transform.Find("Button");
        _image = gameObject.transform.Find("Image");
        _rawImage = _image.Find("RawImage").gameObject;
    }

    public void PushButton()
    {
        if (_rawImage.activeSelf)
        {
            _rawImage.SetActive(false);
            _image.localScale = new Vector3(0.1f,0.1f,1f);
            _image.localPosition = _button.localPosition;
        }
        else
        {
            _rawImage.SetActive(true);
            _image.localScale = Vector3.one;
            _image.localPosition = Vector3.zero;
        }
    }
}
