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
        
        public static void SpringMove(ref float x, ref float v, float xt, float zeta, float omega, float h)
        {
            /*
             *
             * https://allenchou.net/2015/04/game-math-precise-control-over-numeric-springing/
             *
             *  x       - value
             *  v       - velocity
             *  xt      - target value
             *  zeta    - damping ratio
             *  omega   - oscillation frequency
             *  h       - timestep
             */
            var f = 1.0f + 2.0f * h * zeta * omega;
            var oo = omega * omega;
            var hhoo = h * h * oo;
            var d = 1.0f / (f + hhoo);
            var numX = f * x + h * v + hhoo * xt;
            var numV = v + h * oo * (xt - x);
            x = numX * d;
            v = numV * d;
        }

        public static void SpringMove(ref Vector2 x, ref Vector2 v, Vector2 xt, float zeta, float omega, float h)
        {
            var f = 1.0f + 2.0f * h * zeta * omega;
            var oo = omega * omega;
            var hhoo = h * h * oo;
            var d = 1.0f / (f + hhoo);
            var numX = f * x + h * v + hhoo * xt;
            var numV = v + h * oo * (xt - x);
            x = numX * d;
            v = numV * d;
        }

        public static void SpringMove(ref Vector3 x, ref Vector3 v, Vector3 xt, float zeta, float omega, float h)
        {
            var f = 1.0f + 2.0f * h * zeta * omega;
            var oo = omega * omega;
            var hhoo = h * h * oo;
            var d = 1.0f / (f + hhoo);
            var numX = f * x + h * v + hhoo * xt;
            var numV = v + h * oo * (xt - x);
            x = numX * d;
            v = numV * d;
        }
    }
}

