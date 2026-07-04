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
            int magic = br.ReadInt32();//2500072158
            int revision = br.ReadInt32();
            int stringCount = br.ReadInt32();
            int originalTableStart = br.ReadInt32();
            int	TranslationStringTableStart = br.ReadInt32();
            int	HashTableSize = br.ReadInt32();
            int	HashTableStart = br.ReadInt32();
            int	Unknown = br.ReadInt32();


            br.BaseStream.Position = tableStart;
            System.Collections.Generic.List<String> strings = new();
            for (int i = 0; i < count; i++)
                strings.Add(new());

            BinaryWriter bw = new(File.Create(Path.GetDirectoryName(args[0]) + "\\" + Path.GetFileNameWithoutExtension(args[0]) + ".txt"));
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
