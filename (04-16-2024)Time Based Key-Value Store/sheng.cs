namespace TimeBasedKeyValueStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    public class TimeMap
    {
        struct Node
        {
            public Node(string key, string value, int timestamp)
            {
                Key = key; Value = value;  TimeStamp = timestamp;
            }
            public string Key { get; set; }
            public string Value { get; set; }
            public int TimeStamp { get; set; }

        }
        List<Node> nodes;
       
        public TimeMap()
        {
            nodes = new List<Node>();
        }

        public void Set(string key, string value, int timestamp)
        {
            Node node = new Node(key,value,timestamp);
           nodes.Add(node);

        }

        public string Get(string key, int timestamp)
        {
            string value = "";
            foreach(var node in nodes)
            {
                if(node.Key == key && node.TimeStamp<=timestamp) 
                   value = node.Value;
                else
                {
                    break;
                }
            }
            return value;
        }
    }
}
