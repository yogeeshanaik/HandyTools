using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class PathExtension
{
    public static string NormalizePath(this string path)
    {
        return Path.GetFullPath(new Uri(path).LocalPath)
                   .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                   .ToUpperInvariant();
    }

    public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
    {
        IEnumerable<FileInfo> files = dir.EnumerateFiles();
        return (extensions == null) ? files : files.Where(f => extensions.Contains(f.Extension));
    }
}