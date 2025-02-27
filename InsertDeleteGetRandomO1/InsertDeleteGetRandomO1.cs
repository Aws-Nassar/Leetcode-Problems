public class RandomizedSet {

    private List<int> list;
    private Dictionary<int, int> dicMap;
    private Random random;

    public RandomizedSet() {
        list = new List<int> ();
        dicMap = new Dictionary<int, int> ();
        random = new Random ();
    }
    
    public bool Insert(int val) {
        if (dicMap.ContainsKey(val))
        {
            return false;
        }

        list.Add(val);
        dicMap[val] = val;
        return true;
    }
    
    public bool Remove(int val) {
        if (!dicMap.ContainsKey(val))
        {
            return false;
        }

        dicMap.Remove(val);
        int index = list.IndexOf(val);
        list[index] = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);

        return true;
    }
    
    public int GetRandom() {
        int listIndex = random.Next(list.Count);
        return list[listIndex];
    }
}
