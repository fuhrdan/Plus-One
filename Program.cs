//*****************************************************************************
//** 66. Plus One  leetcode                                                  **
//** Set it up to increase the size if you go from 9 to 10 on incrementing   **
//*****************************************************************************


/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* plusOne(int* digits, int digitsSize, int* returnSize) {
    int carry = 1;
    for (int i = digitsSize - 1; i >= 0; i--) {
        int sum = digits[i] + carry;
        digits[i] = sum % 10;
        carry = sum / 10;
    }

    if (carry) {
        *returnSize = digitsSize + 1;
        int* retOne = (int*)malloc(*returnSize * sizeof(int));
        retOne[0] = carry;
        for (int i = 0; i < digitsSize; i++) {
            retOne[i + 1] = digits[i];
        }
        return retOne;
    } else {
        *returnSize = digitsSize;
        int* retOne = (int*)malloc(*returnSize * sizeof(int));
        for (int i = 0; i < digitsSize; i++) {
            retOne[i] = digits[i];
        }
        return retOne;
    }
}
