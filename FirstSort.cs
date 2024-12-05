using System;

namespace Prova
{
    public class FirstSort
    {
        public static void Complete(int[] v, int left, int m, int right)
        {
            int n = right - left + 1;
            int[] aux = new int[n];
            int k = 0;
            int i = left;
            int j = m + 1;
            while (i <= m && j <= right)
            {
                if (v[i] < v[j]) { aux[k] = v[i]; ++i; }
                else { aux[k] = v[j]; ++j; }
                ++k;
            }
            while (i <= m) { aux[k] = v[i]; ++i; ++k; }
            while (j <= right) { aux[k] = v[j]; ++j; ++k; }
            for (k = 0; k < n; ++k) v[left + k] = aux[k];
        }

        public static void Order(int[] v, int left, int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;
                Order(v, left, m);
                Order(v, m + 1, right);
                Complete(v, left, m, right);
            }
        }
    }
}
