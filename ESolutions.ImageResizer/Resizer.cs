using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ESolutions.ImageResizer
{
	public class Resizer
	{
		//Properties
		#region SourceDirectory
		public DirectoryInfo SourceDirectory = null;
		#endregion

		#region TargetDirectory
		public DirectoryInfo TargetDirectory = null;
		#endregion

		#region LongestImageSide
		public Int32 LongestImageSide
		{
			get;
			set;
		}
		#endregion

		#region LongestThumbSide
		public Int32 LongestThumbSide
		{
			get;
			set;
		}
		#endregion

		#region NumberOfFiles
		public Int32 NumberOfFiles
		{
			get
			{
				Int32 result = 0;

				if (this.SourceDirectory != null && this.SourceDirectory.Exists)
				{
					result = this.SourceDirectory.GetFiles().Length;
				}

				return result;
			}
		}
		#endregion

		//Events
		#region FileProcessed
		public event EventHandler FileProcessed;
		#endregion

		#region Finished
		public event EventHandler Finished;
		#endregion

		//Methods
		#region BeginResizing
		public void BeginResizing()
		{
			ThreadStart entryPoint = new ThreadStart(ResizeImages);
			Thread thread = new Thread(entryPoint);
			thread.Start();
		}
		#endregion

		#region ResizeImages
		/// <summary>
		/// A new method stub.
		/// </summary>
		private void ResizeImages()
		{
			String targetImagesPath = Path.Combine(
				this.TargetDirectory.FullName,
				"Images");
			DirectoryInfo targetImagesDirectory = Directory.CreateDirectory(targetImagesPath);

			String targetThumbsPath = Path.Combine(
				this.TargetDirectory.FullName,
				"Thumbs");
			DirectoryInfo targetThumbsDirectory = Directory.CreateDirectory(targetThumbsPath);

			foreach (FileInfo current in this.SourceDirectory.GetFiles())
			{
				ResizeSingleImage(targetImagesDirectory, targetThumbsDirectory, current);
			}

			this.OnFinished();
		}
		#endregion

		#region ResizeSingleImage
		private void ResizeSingleImage(DirectoryInfo targetImagesDirectory, DirectoryInfo targetThumbsDirectory, FileInfo current)
		{
			try
			{
				Bitmap originalBitmap = new Bitmap(current.FullName);
				Bitmap targetImageBitmap = null;
				Bitmap targetThumbBitmap = null;

				if (originalBitmap.Width >= originalBitmap.Height)
				{
					//Is landscape
					double ratio = ((double)originalBitmap.Width / (double)originalBitmap.Height);

					targetImageBitmap = new Bitmap(
						originalBitmap,
						this.LongestImageSide,
						(Int32)(this.LongestImageSide / ratio));

					targetThumbBitmap = new Bitmap(
						originalBitmap,
						this.LongestThumbSide,
						(Int32)(this.LongestThumbSide / ratio));
				}
				else
				{
					//Is portrait
					double ratio = ((double)originalBitmap.Height / (double)originalBitmap.Width);

					targetImageBitmap = new Bitmap(
						originalBitmap,
						(Int32)(this.LongestImageSide / ratio),
						this.LongestImageSide);

					targetThumbBitmap = new Bitmap(
						originalBitmap,
						(Int32)(this.LongestThumbSide / ratio),
						this.LongestThumbSide);
				}

				String newImageFileName = Path.Combine(
					targetImagesDirectory.FullName,
					Path.GetFileName(current.Name.Replace(current.Extension, String.Empty)) + ".jpg");

				String newThumbFileName = Path.Combine(
					targetThumbsDirectory.FullName,
					Path.GetFileName(current.Name.Replace(current.Extension, String.Empty)) + ".jpg");

				targetImageBitmap.Save(
					newImageFileName,
					System.Drawing.Imaging.ImageFormat.Jpeg);

				targetThumbBitmap.Save(
					newThumbFileName,
					System.Drawing.Imaging.ImageFormat.Jpeg);

				this.OnFileProcessed();
			}
			catch
			{
			}
		}
		#endregion

		#region OnFileProcessed
		protected void OnFileProcessed()
		{
			if (this.FileProcessed != null)
			{
				this.FileProcessed(this, new EventArgs());
			}
		}
		#endregion

		#region OnFinished
		protected void OnFinished( )
		{
			if (this.Finished != null)
			{
				this.Finished(this, new EventArgs());
			}
		}
		#endregion
	}
}
