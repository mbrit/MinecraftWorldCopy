using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftWorldCopy
{
    internal class MinecraftCopier
    {
        internal void Copy(string source, string destinationRoot)
        {
            var destination = this.BuildDestinationPath(Path.GetFileName(source), destinationRoot);
            this.WalkAndCopy(new DirectoryInfo(source), new DirectoryInfo(destination));
        }

        private void WalkAndCopy(DirectoryInfo source, DirectoryInfo destination)
        {
            if(!(destination.Exists))
                Directory.CreateDirectory(destination.FullName);

            foreach (var file in source.GetFiles())
            {
                var target = Path.Combine(destination.FullName, file.Name);
                file.CopyTo(target);
            }

            foreach (var child in source.GetDirectories())
                this.WalkAndCopy(child, new DirectoryInfo(Path.Combine(destination.FullName, child.Name)));
        }

        private string BuildDestinationPath(string name, string destinationRoot)
        {
            var index = 1;
            while (true)
            {
                var useName = name;
                if (index > 1)
                    useName = string.Format("{0} ({1})", name, index);

                var destination = Path.Combine(destinationRoot, useName);
                if (!(Directory.Exists(destination)))
                {
                    Directory.CreateDirectory(destination);
                    return destination;
                }

                index++;
            }
        }
    }
}
