public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length !=t.Length) return false;
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach (char i in s)
        {
        map[i] = map.GetValueOrDefault(i, 0) + 1;
        }
        foreach (char i in t)
        {

            if (!map.ContainsKey(i)) return false;
            map[i]--;
            if (map[i] < 0) return false;
        }
        return true;
    }
}
