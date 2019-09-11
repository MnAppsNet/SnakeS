using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeS
{
    class Blocks
    {
        private const int DEFAULT_WIDTH = 100;
        private const int DEFAULT_HEIGHT = 100;

        private List<Block> items;

        public Blocks()
        {
            items = new List<Block>();
        }
        public void Add(System.Drawing.Color color, int width = DEFAULT_WIDTH, int height = DEFAULT_HEIGHT, int x = 0, int y = 0, bool power = false)
        {
            Block tmp = new Block(items.Count, width, height, color, x, y);
            items.Add(tmp);
        }
        public Block Get(int id)
        {
            if (items.Exists(item => item.ID == id))
                return items.Find(item => item.ID == id);
            else
                return null;
        }
        public Block Get(int x, int y)
        {
            if (items.Exists(item => (item.Location.X == x && item.Location.Y == y)))
                return items.Find(item => (item.Location.X == x && item.Location.Y == y));
            else
                return null;
        }
        public int Count
        {
            get { return items.Count; }
        }
        public void SetBlockColor(int id, System.Drawing.Color color)
        {
            if (items.Exists(item => item.ID == id))
                items.Find(item => item.ID == id).Color = color;
        }
        public void SetAllColor(System.Drawing.Color color)
        {
            foreach (Block item in items)
                item.Color = color;
        }
        public List<Block> Items
        {
            get { return items; }
        }
        public void Clear()
        {
            foreach(Block b in items)
            {
                b.Object.Parent = null;
                b.Object.Dispose();
            }
        }
    }
}
