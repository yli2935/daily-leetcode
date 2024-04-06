class Solution {
    public String longestPalindrome(String s) {
        int n = s.length();
        boolean[][] dp = new boolean[n+1][n+1];
        int maxlen = 1;
        int start = 0;

        if (n < 2) {
            return s;
        }

        //所有长度为1的子串都是true
        for (int i = 0; i <= n; i++) {
            dp[i][i] = true;
        }

        for (int len = 2; len <= n; len++) {
            for (int i = 0; i < n ; i++) {
                int j = len + i - 1;

                if (j >= n) {
                    break;
                }
                if (s.charAt(i) != s.charAt(j)) {
                    dp[i][j] = false;
                    continue;
                }

                if (len == 2 || len == 3) {
                    dp[i][j] = true;
                } else {
                    dp[i][j] = dp[i+1][j-1];
                }

                if (dp[i][j] == true & len > maxlen) {
                    start = i;
                    maxlen = len;
                }
            }
        }

        return s.substring(start, start+maxlen);
    }
}
