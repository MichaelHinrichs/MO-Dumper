using System;
using System.IO;

namespace MO_Dumper
{
    class Program
    {
        static BinaryReader br;
        public static void Main(string[] args)
        {
            br = new(File.OpenRead(args[0]));
            br.ReadBytes(8);
            int count = br.ReadInt32() * 16 / 8;
            int tableStart = br.ReadInt32();
            int unknown = br.ReadInt32();

            br.BaseStream.Position = tableStart;
            List<String> strings = new();
            for (int i = 0; i < count; i++)
                strings.Add(new());

            BinaryWriter bw = File.Create(Path.GetDirectoryName(args[0]) + "\\" + Path.GetFileNameWithoutExtension(args[0]) + ".txt")
            foreach (String text in strings)
            {
                br.BaseStream.Position = text.start;
                bw.WriteLine(br.ReadBytes(text.size));
            }
            bw.Close();
        }

        class String
        {
            public int size = br.ReadInt32();
            public int start = br.ReadInt32();
        }
    }
}
