using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges._Challenges {
    public class _001_TwoSum {
        /* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order. */

        public static int[] Solution(int[] inputArray, int target) {
            for (int i = 0; i < inputArray.Length; i++) {
                int complement = target - inputArray[i];
                for (int j = 0; j < inputArray.Length; j++) {
                    if (i == j) continue;
                    if (inputArray[j] == complement) return new int[] { i, j };
                }
            }
            return new int[0];
        }
    }
}
