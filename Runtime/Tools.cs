using UnityEngine;

namespace Joonatan
{
    public class Tools
    {
        public static Vector3 SmoothMove(Vector3 a, Vector3 b, float decay, float dt)
        {
            return b + (a - b) * Mathf.Exp(-decay * dt);
        }

        public static float RoundSin(float x)
        {
            return Mathf.Sin(x) / (0.4f + 0.4f * Mathf.Abs(Mathf.Sin(x)));
        }
    }
}

