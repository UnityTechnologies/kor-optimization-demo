using UnityEngine;

public static class HeavyFunctions
{
    public static float CalculatePi(int iterations = 1000)
    {
        // 라이프니츠 공식을 사용한 파이 계산 (CPU 부하 높음)
        var pi = 0f;
        for (var i = 0; i < iterations; i++)
        {
            pi += (i % 2 == 0 ? 1f : -1f) / (2 * i + 1);
        }
        pi *= 4;

        return pi;
    }
}
