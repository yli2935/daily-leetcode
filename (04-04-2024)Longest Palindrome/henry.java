class Solution {
    public int longestPalindrome(String s) {
        HashMap<Character, Integer>map = new HashMap<>();
        for (int i = 0; i < s.length(); i++) {
            map.merge(s.charAt(i), 1, (a, b) -> a + b);
        }
        
        int length = 0;
        Boolean odd = false;
        for (Map.Entry<Character, Integer> entry: map.entrySet()) {
            if (entry.getValue() % 2 != 0) {
                odd = true;
            }
            length += entry.getValue()/2 *2;
        }
        if (odd) {
            length++;
        }
        return length;
    }
}
