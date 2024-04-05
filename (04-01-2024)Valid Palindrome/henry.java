class Solution {
    public boolean isPalindrome(String s) {
        StringBuffer s_after = new StringBuffer();
        for (int i = 0; i < s.length(); i++) {
            int ascii = s.charAt(i);
            if (ascii >= 'A' && ascii <= 'Z') {
                ascii += 32;
            } else if (ascii >= 'a' && ascii <= 'z') {
                //do nothing
            } else if (ascii >= '0' && ascii <= '9') {
                //do nothing
            } else {
                continue;
            }
            s_after.append((char)ascii);
        }

        int i = 0;
        int j = s_after.length() - 1;
        while (i < j) {
            if (s_after.charAt(i) != s_after.charAt(j)) {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
