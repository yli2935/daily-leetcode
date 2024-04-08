function groupAnagrams(strs: string[]): string[][] {
  const cache = new Map<string, string[]>();
  for (const word of strs) {
      const key = word.split('').sort().join('');
      if (!cache.has(key)) cache.set(key, [word]);
      else cache.get(key)?.push(word);
  };
  return Array.from(cache.values());
};