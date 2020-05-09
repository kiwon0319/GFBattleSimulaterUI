using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFBattleSimulator.Util
{
    class QuickSortUtil
    {
        public static void sort(JArray arr, int left, int right) {
            int l_hond = left, r_hold = right;
            JObject pivot = (JObject)arr[left];

            int p = int.Parse(pivot["location"].ToString());

            while (left < right) {
                while ((p <= int.Parse(arr[right]["location"].ToString())) && (left < right))
                    right--;
                if (left != right)
                    arr[left] = arr[right];

                while ((p >= int.Parse(arr[left]["location"].ToString())) && (left < right))
                    left++;

                if (left != right) {
                    arr[right] = arr[left];
                    right--;
                }
            }

            arr[left] = pivot;
            p = left;
            left = l_hond;
            right = r_hold;
            if (left < p)
                sort(arr, left, p -1);
            if (right > p)
                sort(arr, p + 1, right);
        }
    }
}
