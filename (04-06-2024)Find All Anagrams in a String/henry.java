class Solution {
    public List<Integer> findAnagrams(String s, String p) {
        int n = s.length();
        int p_n = p.length();
        int[] map = new int[26];
        int[] smap = new int[26];
        List<Integer> result = new ArrayList<Integer>();

        if (n < p_n) {
            return result;
        }

        for (int i = 0; i < p.length(); i++) {
            map[p.charAt(i) - 'a']++;
            smap[s.charAt(i) - 'a']++;
        }

        if (Arrays.equals(map, smap)) {
            result.add(0);
        }

        for (int i = 0; i < n; i++) {
            if (p_n+i >= n) {
                break;
            }
            smap[s.charAt(i) - 'a']--;
            smap[s.charAt(p_n+i) - 'a']++;

            if (Arrays.equals(map, smap)) {
                result.add(i+1);
            }
        }

        return result;
    }
}
