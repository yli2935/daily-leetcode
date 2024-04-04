class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        }
        HashMap<Character,Integer> map = new HashMap<>();

        for (int i = 0; i < s.length(); i++) {
            if (map.get(s.charAt(i)) != null) {
                map.put(s.charAt(i), map.get(s.charAt(i))+1);
            } else {
                map.put(s.charAt(i), 1);
            }
        }

        for (int j = 0; j < t.length(); j++) {
            if (map.get(t.charAt(j)) == null) {
                return false;
            } else {
                int curr = map.get(t.charAt(j))-1;
                if (curr == 0) {
                    map.remove(t.charAt(j));
                } else {
                    map.put(t.charAt(j), curr);
                }
            }
        }
        if (map.size() == 0) {
            return true;
        } 

        return false;
    }
}
