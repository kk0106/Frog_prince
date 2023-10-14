using UnityEngine;
using UnityEngine.UI;

public class RawImageTextureAnimator : MonoBehaviour
{
    public RawImage rawImage;
    public Texture[] animationFrames;
    public float frameDuration = 0.1f;  // Duration for each frame

    private int currentFrameIndex;
    private float timeSinceLastFrame;

    void Start()
    {
        currentFrameIndex = 0;
        timeSinceLastFrame = 0f;
    }

    void Update()
    {
        // Update time since last frame
        timeSinceLastFrame += Time.deltaTime;

        // Change frame if needed
        if (timeSinceLastFrame >= frameDuration)
        {
            timeSinceLastFrame -= frameDuration;
            UpdateFrame();
        }
    }

    void UpdateFrame()
    {
        if (animationFrames.Length == 0)
            return;

        // Update the texture to the next frame
        currentFrameIndex = (currentFrameIndex + 1) % animationFrames.Length;
        rawImage.texture = animationFrames[currentFrameIndex];
    }
}