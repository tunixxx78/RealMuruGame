using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField]
    [Range(0.01f, 1f)]
    private float cameraFollowSpeed;
    private static float cameraY = 10000f, minX, maxX;
    [SerializeField] private Vector2 offSet;
    private Vector3 velocity = Vector3.zero;
    private Vector3 oldPosition;

    private void Start()
    {
        //PlayerPrefs.GetInt("CharacterIndex");
        float width = Camera.main.orthographicSize * Screen.width / Screen.height;
        minX = LayerManager.instance.worldEdgeLeft.position.x + width;
        maxX = LayerManager.instance.worldEdgeRight.position.x - width;
        transform.position = GetWantedPosition();
        cameraY = transform.position.y;
    }

    private Vector3 GetWantedPosition (bool followY = true)
    {
        float x = Mathf.Clamp(player.position.x + offSet.x, minX, maxX);
        float y = followY ? player.position.y + offSet.y : transform.position.y;
        if (!followY && cameraY != -10000f)
        {
            y = cameraY;
        }

        return new Vector3(x, y, -10f);
    }

    private void Update()
    {
        Vector3 wantedPosition = GetWantedPosition(false);
        
        //oldPosition = transform.position;
        transform.position = Vector3.SmoothDamp(transform.position, wantedPosition, ref velocity, cameraFollowSpeed);
    }
}
