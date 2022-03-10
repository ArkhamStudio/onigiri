﻿using UnityEngine;

namespace Arkham.Onigiri.Variables
{
    [CreateAssetMenu(menuName = "Variables/Audio Clip")]
    public class AudioClipVariable : BaseVariable<AudioClip>
    {
        public override string ValueToString() => Value.ToString();
    }
}
