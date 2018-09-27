using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer_Stats
{
	/// <summary>
	/// Represents a single directory and its subdirectories, along with associated statistics
	/// </summary>
	public class Directory
	{
		/// <summary>
		/// The name of the current directory
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// The DirectoryInfo object containing statistics like the last accessed date and creation date
		/// </summary>
		public DirectoryInfo DirectoryInfo { get; private set; }

		/// <summary>
		/// The total size of the current directory's files (non-recursive)
		/// </summary>
		public long Size { get; set; }

		/// <summary>
		/// The total number of files withing this current directory (non-recursive)
		/// </summary>
		public int NumberFiles { get; set; }

		/// <summary>
		/// The collection of subdirectories contained within the current directory
		/// </summary>
		public List<Directory> Subdirectories { get; set; }

		/// <summary>
		/// The collection of different file types and their associated statistics (number of files and total file size)
		/// </summary>
		public Dictionary<string, FileType> FileTypes { get; set; }

		/// <summary>
		/// Creat a new directory tree (recursive) fromt he specified DirectoryInfo object
		/// </summary>
		/// <param name="directoryInfo"></param>
		public Directory(DirectoryInfo directoryInfo)
		{
			if (directoryInfo != null)
			{
				Name = directoryInfo.Name;
				DirectoryInfo = directoryInfo;
				Subdirectories = new List<Directory>();
				FileTypes = new Dictionary<string, FileType>();

				// Attempt to enumerate the list of files and compile data like the number of files and file sizes
				try
				{
					var files = DirectoryInfo.EnumerateFiles().ToList();
					NumberFiles = files.Count;
					Size = files.Sum(x => x.Length);

					// Loop through each file and add the extension if it doesnt exist to the list, otherwise increase the sums
					foreach (FileInfo file in files)
					{
						if (FileTypes.ContainsKey(file.Extension))
						{
							FileTypes[file.Extension].AddSingleFile(file.Extension, file.Length);
						}
						else
						{
							FileTypes.Add(file.Extension, new FileType(file.Extension, file.Length));
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
				}

				// Loop through each subdirectory and create a new set of subdirectories from the DirectoryInfo
				try
				{
					foreach (var dir in DirectoryInfo.EnumerateDirectories())
					{
						Subdirectories.Add(new Directory(dir));
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
				}
			}
		}

		/// <summary>
		/// Sum up the total number of files in the current directory, as well as in the contained subdirectories
		/// </summary>
		/// <returns></returns>
		public int TotalNumberOfFiles()
		{
			int totalNumber = 0;

			try
			{
				totalNumber += NumberFiles;

				foreach (var dir in Subdirectories)
				{
					totalNumber += dir.TotalNumberOfFiles();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}

			return totalNumber;
		}

		/// <summary>
		/// Sum up the total size of the files in the current directory, as well as in the contained subdirectories
		/// </summary>
		/// <returns></returns>
		public long TotalFileSize()
		{
			long totalSize = 0;

			try
			{
				totalSize += Size;

				foreach (var dir in Subdirectories)
				{
					totalSize += dir.TotalFileSize();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}

			return totalSize;
		}

		/// <summary>
		/// Sum up the total number of subdirectories in the current directory, as well as in the contained subdirectories
		/// </summary>
		/// <returns></returns>
		public int TotalNumberOfSubdirectories()
		{
			int totalNumber = 0;

			try
			{
				totalNumber += Subdirectories.Count;

				foreach (var dir in Subdirectories)
				{
					totalNumber += dir.TotalNumberOfSubdirectories();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}

			return totalNumber;
		}

		/// <summary>
		/// Compiles a complete collection of all file types represented in the current directory, as well as in the contained subdirectories
		/// </summary>
		/// <returns></returns>
		public Dictionary<string, FileType> TotalFileExtensions()
		{
			Dictionary<string, FileType> completeResults = new Dictionary<string, FileType>(FileTypes);

			try
			{
				// Loop through ech subdirectory, compiling the collections of filetypes
				foreach (var dir in Subdirectories)
				{
					var tempDictionary = dir.TotalFileExtensions();
					foreach (var ext in tempDictionary)
					{
						// Loop through each subdirectory's FileType dictionary, adding missing extension entries, and summing existing entries
						if (completeResults.ContainsKey(ext.Key))
						{
							completeResults[ext.Key].AddFiles(ext.Key, ext.Value.TotalNumber, ext.Value.TotalSize);
						}
						else
						{
							completeResults.Add(ext.Key, new FileType(ext.Key, ext.Value.TotalNumber, ext.Value.TotalSize));
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}

			return completeResults;
		}
	}

	/// <summary>
	/// A collection of stats for a particular file type (extension)
	/// </summary>
	public class FileType
	{
		/// <summary>
		/// The extension of the files being summed up
		/// </summary>
		public string Extension { get; private set; }

		/// <summary>
		/// The total number of files with the specified extension
		/// </summary>
		public int TotalNumber { get; set; }

		/// <summary>
		/// The total size of all files with the specified extension
		/// </summary>
		public long TotalSize { get; set; }

		/// <summary>
		/// Adds a single set of file stats to initialize the object
		/// </summary>
		/// <param name="extension">The extension of the file</param>
		/// <param name="size">The total size of the file being added to the current total size</param>
		public FileType(string extension, long totalSize)
		{
			Extension = extension;
			TotalNumber = 1;
			TotalSize = totalSize;
		}

		/// <summary>
		/// Creates a set of summed file stats from the passed file stats
		/// </summary>
		/// <param name="extension">The extension of the files</param>
		/// <param name="numFiles">The number of total files being added</param>
		/// <param name="size">The total size of the files being added</param>
		public FileType(string extension, int numFiles, long totalSize)
		{
			Extension = extension;
			TotalNumber = numFiles;
			TotalSize = totalSize;
		}

		/// <summary>
		/// Adds a single set of file stats to the current file stats
		/// </summary>
		/// <param name="extension">The extension of the file (to ensure that it matches with the current file extension)</param>
		/// <param name="size">The total size of the file being added to the current total size</param>
		public void AddSingleFile(string extension, long size)
		{
			if (Extension.Equals(extension))
			{
				TotalNumber++;
				TotalSize += size;
			}
		}

		/// <summary>
		/// Adds a set of summed file stats to the current file stats
		/// </summary>
		/// <param name="extension">The extension of the files (to ensure that it matches with the current file extension)</param>
		/// <param name="numFiles">The number of total files being added to the current total</param>
		/// <param name="size">The total size of the files being added to the current total size</param>
		public void AddFiles(string extension, int numFiles, long size)
		{
			if (Extension.Equals(extension))
			{
				TotalNumber+= numFiles;
				TotalSize += size;
			}
		}
	}
}
