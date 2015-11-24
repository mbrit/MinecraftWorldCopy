using fNbt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftWorldCopy
{
    internal class MinecraftReader
    {
        internal string Path { get; set; }

        internal Dictionary<string, DirectoryInfo> Worlds { get; set; }

        internal MinecraftReader(string path)
        {
            this.Path = path;

            this.Worlds = new Dictionary<string, DirectoryInfo>(StringComparer.InvariantCultureIgnoreCase);
            this.Walk(new DirectoryInfo(path));
        }

        private void Walk(DirectoryInfo folder)
        {
            foreach (FileInfo file in folder.GetFiles("level.dat"))
            {
                try
                {
                    var nbt = new NbtFile();
                    nbt.LoadFromFile(file.FullName);

                    var data = nbt.RootTag["Data"];
                    this.Worlds[data["LevelName"].StringValue] = folder;
                }
                catch
                {
                    // ignore any load problems...
                }
            }

            foreach (DirectoryInfo child in folder.GetDirectories())
                this.Walk(child);
        }

        private void DumpTag(NbtTag tag, int level, StreamWriter writer)
        {
            for (var index = 0; index < level; index++)
                writer.Write("   ");
            writer.Write(tag.Name);
            writer.Write(" [");
            writer.Write(tag.GetType().Name);
            writer.Write("]: ");

            if (tag is NbtCompound)
            {
                writer.WriteLine("...");
                foreach (var name in ((NbtCompound)tag).Names)
                {
                    var value = tag[name];
                    this.DumpTag(value, level + 1, writer);
                }
            }
            else if (tag is NbtList)
            {
                writer.WriteLine("...");
                foreach (var item in (NbtList)tag)
                    this.DumpTag(item, level + 1, writer);
            }
            else
                writer.WriteLine(tag);
        }
    }
}
