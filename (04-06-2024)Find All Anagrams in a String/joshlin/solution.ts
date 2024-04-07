function findAnagrams(s: string, p: string): number[] {
  if (s.length < p.length) return [];
  const sCount = new Map<string, number>();
  const pCount = new Map<string, number>();
  for (let i = 0; i < p.length; i++) {
      sCount.set(s[i], (sCount.get(s[i]) ?? 0) + 1);
      pCount.set(p[i], (pCount.get(p[i]) ?? 0) + 1);
  };
  const mapsAreEqual = (m1: Map<string, number>, m2: Map<string, number>): boolean =>
      m1.size === m2.size && Array.from(m1.keys()).every((key) => m1.get(key) === m2.get(key));
  const res: number[] = mapsAreEqual(sCount, pCount) ? [0] : [];
  let left = 0;
  for (let right = p.length; right < s.length; right++) {
      sCount.set(s[right], (sCount.get(s[right]) ?? 0) + 1);
      sCount.set(s[left], (sCount.get(s[left]) ?? 0) - 1);
      if (sCount.get(s[left]) === 0) sCount.delete(s[left]);
      left++;
      if (mapsAreEqual(sCount, pCount)) res.push(left);
  };
  return res;
};