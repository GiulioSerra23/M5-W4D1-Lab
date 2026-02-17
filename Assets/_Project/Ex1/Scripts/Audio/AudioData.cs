using UnityEngine;

public enum SoundID
{
    FOOTSTEPS_GRASS = 0,
    FOOTSTEPS_ROCK = 1,
    FOOTSTEPS_WOOD = 2,

    NONE = 100,
}

[System.Serializable]
public struct SoundData
{
    public SoundID ID;
    public AudioClip[] Clips;
}
