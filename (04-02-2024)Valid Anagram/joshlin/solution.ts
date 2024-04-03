function isAnagram(s: string, t: string): boolean {
  const frequency = new Map<string, number>();
  for (const char of s) {
      frequency.set(char, (frequency.get(char) ?? 0) + 1);
  };
  for (const char of t) {
      if (!frequency.has(char)) return false;
      frequency.set(char, frequency.get(char) - 1);
  };
  for (const count of frequency.values()) {
      if (count != 0) return false;
  };
  return true;
};