#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Uno.Extensions;
using Windows.Foundation;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Storage
{
	public partial class StorageFile : StorageItem, IStorageFile
	{
		private static async Task<StorageFile> GetFileFromApplicationUriAsyncTask(CancellationToken ct, Uri uri)
		{
			if(uri.Scheme != "ms-appx")
			{
				throw new InvalidOperationException("Uri is not using the ms-appx scheme");
			}

			var path = uri.PathAndQuery;

			return await StorageFile.GetFileFromPathAsync(await AssetsManager.DownloadAsset(ct, path));
		}
	}
}
