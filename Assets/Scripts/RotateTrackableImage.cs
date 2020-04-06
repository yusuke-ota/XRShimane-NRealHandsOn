using UnityEngine;

public class RotateTrackableImage : MonoBehaviour
{
    [SerializeField] [Tooltip("回転させたい画像のトランスフォーム")]
    private Transform trackableImageTransform;

    [SerializeField] [Tooltip("1フレーム当たりの回転速度")]
    private int rotationSpeed;

    private Quaternion _quaternion;

    private void Start()
    {
        _quaternion = Quaternion.Euler(1 * rotationSpeed, 0, 0);
    }

    private void Update()
    {
        trackableImageTransform.localRotation *= _quaternion;
    }
}
