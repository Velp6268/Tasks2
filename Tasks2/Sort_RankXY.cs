using System;
namespace Tasks2
{
    public class Sort_RankXY
    {
        public void QuickX(int left, int right, ref Variable[] a)//сортировка X
        {
            int l, r;
            Variable vrb = new Variable();
            l = left; r = right; vrb = a[l];
            do
            {
                while ((a[r].x >= vrb.x) & (l < r)) r = r - 1;
                a[l] = a[r]; a[r] = vrb;
                while ((a[l].x <= vrb.x) & (l < r)) l = l + 1;
                a[r] = a[l]; a[l] = vrb;
            } while (l != r); a[l] = vrb;
            if (left < l - 1) QuickX(left, l - 1, ref a);
            if (l + 1 < right) QuickX(l + 1, right, ref a);
        }

        public void QuickY(int left, int right, ref Variable[] a)//сортировка Y
        {
            int l, r;
            Variable vrb = new Variable();
            l = left; r = right; vrb = a[l];
            do
            {
                while ((a[r].y >= vrb.y) & (l < r)) r = r - 1;
                a[l] = a[r]; a[r] = vrb;
                while ((a[l].y <= vrb.y) & (l < r)) l = l + 1;
                a[r] = a[l]; a[l] = vrb;
            } while (l != r); a[l] = vrb;
            if (left < l - 1) QuickY(left, l - 1, ref a);
            if (l + 1 < right) QuickY(l + 1, right, ref a);
        }

        public void RankX(int n, ref double t_a, ref Variable[] a) //метод для присвоения ранка каждому элементу X
        {
            int k, j = -1;
            double s;
            do
            {
                j = j + 1;

                if ((j != n) && (a[j].x == a[j + 1].x))
                {
                    k = j + 1;
                    while ((k <= n) && (a[j].x == a[k].x)) k++;
                    k = k - 1;
                    s = (double)((k * (k + 1) / 2) - ((j - 1) * j / 2)) / (k - j + 1);
                    for (int h = j; h <= k; h++) a[h].rx = s + 1;
                    s = k - j + 1;
                    t_a = t_a + s * (s * s - 1) / 12;
                    j = k;
                }
                else
                {
                    a[j].rx = j + 1;
                }
            } while (j != n);
        }

        public void RankY(int n, ref double t_b, ref Variable[] a)//метод для присвоения ранка каждому элементу X
        {
            int k, j = -1;
            double s;
            do
            {
                j = j + 1;

                if ((j != n) && (a[j].y == a[j + 1].y))
                {
                    k = j + 1;
                    while ((k <= n) && (a[j].y == a[k].y)) k++;
                    k = k - 1;
                    s = (double)((k * (k + 1) / 2) - ((j - 1) * j / 2)) / (k - j + 1);
                    for (int h = j; h <= k; h++) a[h].ry = s + 1;
                    s = k - j + 1;
                    t_b = t_b + s * (s * s - 1) / 12;
                    j = k;
                }
                else
                {
                    a[j].ry = j + 1;
                }
            } while (j != n);
        }
    }
}

