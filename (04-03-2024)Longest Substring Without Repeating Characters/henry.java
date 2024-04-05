class Solution {
    public int lengthOfLongestSubstring(String s) {
        // HashMap<Character, Integer> map = new HashMap<>();
        HashSet<Character> set = new HashSet<>();
        int i = 0;
        int j = 0;
        int historyMax = 0;
        int curr = 0;
        while (j < s.length()) {
            char c = s.charAt(j);
            // 当没碰到重复的char
            if (set.contains(c) == false) {
                set.add(c);
                curr++;
                j++;
            } else {
                historyMax = Math.max(historyMax, curr);
                //找到子串里重复的char的index，然后i++，同时把set里不要的key remove了
                while (i < s.length()) {
                    curr--;
                    if (s.charAt(i) != c) {
                        set.remove(s.charAt(i));
                        i++;
                    } else {
                        i++;
                        set.remove(c);
                        break;
                    }
                }
                
            }
        }
        //看最后一组子串是不是Max (因为之前判断是不是max是在碰到重复char的时候进行判断的，当遍历完string之后他不会进行判定)
        historyMax = Math.max(historyMax, curr);

        return historyMax;
    }
}
