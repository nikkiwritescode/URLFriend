using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLfriend.Panels;
using URLfriend.Theme;
using URLfriend.Utilities;

namespace URLfriend.IO
{
    public static class NetIO
    {
        public static async Task InitiateDownload(string original, MainWindow window)
        {
            if (MainWindow.CurrentlyDownloadingItem == null)
            {
                window.DisableButtons();

                if (ThemeUtils.CurrentPalette == null) return;
                var palette = ThemeUtils.CurrentPalette;

                var downloadingColor = palette.PositiveColor.GetColor();

                foreach (ListViewItem item in window.FileNameList.Items)
                {
                    MainWindow.CurrentlyDownloadingItem = item;
                    MainWindow.CurrentlyDownloadingItem.UseItemStyleForSubItems = false;

                    var httpLink = item.SubItems[0];
                    var status = item.SubItems[1];
                    var progress = item.SubItems[2];
                    var fileName = item.SubItems[3];

                    window.ChangeAllLaterFileStatusesToWaiting(item, window.FileNameList.Items);
                    status.Text = @"Downloading";
                    status.ForeColor = downloadingColor;
                    await DownloadFileAsync(httpLink.Text, window.SetOutputDirectoryLabel.Text, fileName.Text);
                }
            }
            else //if a download is ongoing
            {
                MainWindow.CurrentTask?.Dispose();
                window.DownloadAllButton.Text = original;
                window.ClearListButtonEnabled = true;
                window.ReadFileButtonEnabled = true;
                window.SetOutputDirectoryButtonEnabled = true;
            }
        }

        private static async Task DownloadFileAsync(string downloadLink, string outputDirectory, string outputFileName)
        {
            var link = new Uri(downloadLink);
            var webClient = new WebClient { Proxy = null };
            webClient.DownloadFileCompleted += FileDownloadComplete;
            webClient.DownloadProgressChanged += FileDownloadProgressUpdate;
            try
            {
                await webClient.DownloadFileTaskAsync(link, (outputDirectory + "/" + outputFileName));
            }
            catch (WebException e)
            {
                // Do something with {e}
            }
        }

        private static HttpStatusCode GetHttpStatusCode(System.Exception err)
        {
            if (!(err is WebException we)) return 0;
            return we.Response is HttpWebResponse response ? response.StatusCode : (HttpStatusCode)0;
        }

        private static void FileDownloadProgressUpdate(object sender, DownloadProgressChangedEventArgs e)
        {
            var received = GetDataString(e.BytesReceived);
            var total = GetDataString(e.TotalBytesToReceive);
            var progress = received + @" / " + total + @" (" + DataManipulation.GetPercentage(e.BytesReceived, e.TotalBytesToReceive) + @"%)";
            MainWindow.CurrentlyDownloadingItem.SubItems[2].Text = progress;
        }

        private static string GetDataString(long amountInBytes)
        {
            const long bytesinKB = 1024;
            const long bytesInMB = 1048576;
            const long bytesInGB = 1073741824;
            const long bytesInTB = 1099511627776;

            if (amountInBytes < bytesinKB) { return amountInBytes + " bytes"; }
            if (amountInBytes > bytesinKB && amountInBytes < bytesInMB) { return DataManipulation.ConvertBytesToKilobytes(amountInBytes).ToString("0") + " KB"; }
            if (amountInBytes > bytesInMB && amountInBytes < bytesInGB) { return DataManipulation.ConvertBytesToMegabytes(amountInBytes).ToString("0.00") + " MB"; }
            if (amountInBytes > bytesInGB && amountInBytes < bytesInTB) { return DataManipulation.ConvertBytesToGigabytes(amountInBytes).ToString("0.00") + " GB"; }

            return null;
        }

        private static void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                var httpStatusCode = GetHttpStatusCode(e.Error);
                if (httpStatusCode == HttpStatusCode.NotFound) {
                    MainWindow.CurrentlyDownloadingItem.SubItems[1].Text = @"404 Not Found"; }
                else {
                    MainWindow.CurrentlyDownloadingItem.SubItems[1].Text = @"Error! => " + httpStatusCode; }
            }
            else if (e.Error == null && e.Cancelled) {
                MainWindow.CurrentlyDownloadingItem.SubItems[1].Text = @"Canceled!"; }
            else if (e.Error == null && !e.Cancelled) {
                MainWindow.CurrentlyDownloadingItem.SubItems[1].Text = @"Completed!"; }

            MainWindow.CurrentlyDownloadingItem = null;
            MainWindow.CurrentTask = null;
        }
    }
}