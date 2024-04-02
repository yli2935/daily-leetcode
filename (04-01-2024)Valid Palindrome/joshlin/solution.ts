function isPalindrome(s: string): boolean {
  let [l, r] = [0, s.length - 1];
  const isAlphaNum = (char: string): boolean => /^[a-zA-Z0-9]+$/.test(char);
  while (l < r) {
      while (l < r && !isAlphaNum(s[l])) l++;
      while (l < r && !isAlphaNum(s[r])) r--;
      if (s[l].toLowerCase() != s[r].toLowerCase()) return false;
      l++;
      r--;
  };
  return true;
};