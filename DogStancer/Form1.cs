using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using HtmlAgilityPack;

namespace DogStancer
{
    public partial class Form1 : Form
    {
        private readonly IList<string> _fileList;

        public Form1()
        {
            InitializeComponent();
            Setting = LoadConfig();
            _fileList = new List<string>();
            FilePathOfJustMovedPic = null;
            _fileList = Directory.GetFiles(Setting.ImagesFolder).OrderBy(i => i).ToList();
            label1.Text = _fileList.Count.ToString();
            FilePathOfCurrentPic = _fileList.FirstOrDefault();
            pictureBox1.ImageLocation = FilePathOfCurrentPic;
            tbFilePath.Text = FilePathOfCurrentPic;
        }

        public Setting Setting { get; set; }

        private string FilePathOfCurrentPic { get; set; }
        private string FilePathOfJustMovedPic { get; set; }

        private void SaveConfig()
        {
            var filename = $"{Path.GetDirectoryName(Application.ExecutablePath)}/settings.xml";
            var sc = new SettingList {Settings = new List<Setting> {Setting}};
            var s = new XmlSerializer(typeof(SettingList));
            TextWriter tw = new StreamWriter(Path.GetFullPath(filename));
            s.Serialize(tw, sc);
        }

        private Setting LoadConfig()
        {
            var setting = new Setting();
            try
            {
                var filename = $"{Path.GetDirectoryName(Application.ExecutablePath)}/settings.xml";


                var serializer = new XmlSerializer(typeof(SettingList));
                using (var fileStream = new FileStream(filename, FileMode.Open))
                {
                    var result = (SettingList) serializer.Deserialize(fileStream);
                    setting = result.Settings.FirstOrDefault();
                    tbImagesToSort.Text = setting.ImagesFolder;
                    tbSortedImagesBasePath.Text = setting.SortedImagesFolderBasePath;
                    tbImagesDownloadPath.Text = setting.ImagesFolder;
                    return setting;
                }
            }
            catch (Exception e)
            {
                setting.SetDefaults();
                
                var sc = new SettingList {Settings = new List<Setting> {Setting}};

                return setting;

                Console.WriteLine(e);
                //throw;
            }


            //StreamReader reader = new StreamReader(filename);
            //reader.ReadToEnd();
            //var settings = (SettingList)serializer.Deserialize(reader);
            //reader.Close();


            //var s = new XmlSerializer(typeof(Setting));
            //TextWriter tw = new StreamWriter(System.IO.Path.GetFullPath(filename));
            //s.Serialize(tw, Setting);
            return setting;
        }


        private void MoveToFolderAndSetNextPic(string subPath)
        {
            var sortedSubPath = $@"{Setting.SortedImagesFolderBasePath}\{subPath}";
            if (!Directory.Exists(sortedSubPath))
            {
                Directory.CreateDirectory(sortedSubPath);
            }

            FilePathOfJustMovedPic = $@"{sortedSubPath}\{Path.GetFileName(FilePathOfCurrentPic)}";
            tbFilePath.Text = FilePathOfCurrentPic;

            File.Move(FilePathOfCurrentPic, FilePathOfJustMovedPic);
            _fileList.Remove(FilePathOfCurrentPic);
            label1.Text = _fileList.Count.ToString();
            FilePathOfCurrentPic = _fileList.FirstOrDefault();
            if (!string.IsNullOrEmpty(FilePathOfCurrentPic))
            {
                pictureBox1.ImageLocation = FilePathOfCurrentPic;
            }
        }


        private void btnOther_Click(object sender, EventArgs e)
        {
            MoveToFolderAndSetNextPic(Setting.pathOther);
        }

        private void btnNotADog_Click(object sender, EventArgs e)
        {
            MoveToFolderAndSetNextPic(Setting.pathNotADog);
        }

        private void btnStanding_Click(object sender, EventArgs e)
        {
            MoveToFolderAndSetNextPic(Setting.pathStanding);
        }

        private void btnRolling_Click(object sender, EventArgs e)
        {
            MoveToFolderAndSetNextPic(Setting.pathRolling);
        }

        private void btnLaying_Click(object sender, EventArgs e)
        {
            MoveToFolderAndSetNextPic(Setting.pathLaying);
        }

        private void btnSitting_Click(object sender, EventArgs e)
        {
            MoveToFolderAndSetNextPic(Setting.pathSitting);
        }

        private void btnJumping_Click(object sender, EventArgs e)
        {
            MoveToFolderAndSetNextPic(Setting.pathJumping);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (FilePathOfJustMovedPic != null)
            {
                FilePathOfCurrentPic = FilePathOfJustMovedPic;
                if (!string.IsNullOrEmpty(FilePathOfCurrentPic))
                {
                    pictureBox1.ImageLocation = FilePathOfCurrentPic;
                }
                tbFilePath.Text = FilePathOfCurrentPic;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnResizeAll_Click(object sender, EventArgs e)
        {
            ResizeImagesInFolder(Setting.SortedImagesFolderBasePath, Setting.ResizedImagesFolderBasePath, Setting.pathRolling);
            ResizeImagesInFolder(Setting.SortedImagesFolderBasePath, Setting.ResizedImagesFolderBasePath, Setting.pathJumping);
            ResizeImagesInFolder(Setting.SortedImagesFolderBasePath, Setting.ResizedImagesFolderBasePath, Setting.pathStanding);
            ResizeImagesInFolder(Setting.SortedImagesFolderBasePath, Setting.ResizedImagesFolderBasePath, Setting.pathLaying);
            ResizeImagesInFolder(Setting.SortedImagesFolderBasePath, Setting.ResizedImagesFolderBasePath, Setting.pathSitting);
        }


        private void ResizeImagesInFolder(string inPath, string outPath, string subPath)
        {
            var folderPathToResize = $@"{inPath}\{subPath}";

            var outFolderPath = $@"{outPath}\{subPath}";
            if (!Directory.Exists(outFolderPath))
            {
                Directory.CreateDirectory(outFolderPath);
            }


            var resizeFileList = Directory.GetFiles(folderPathToResize).OrderBy(i => i).ToList();

            foreach (var fileToResize in resizeFileList)
            {
                var inFilename = $@"{folderPathToResize}\{Path.GetFileName(fileToResize)}";
                //File.Move(inFilename, outFilename);
                resizeImage(folderPathToResize, outFolderPath, Path.GetFileName(fileToResize), 128, 128);
            }
        }


        private void resizeImage(string inPath, string outPath, string originalFilename,
            /* note changed names */
            int canvasWidth, int canvasHeight
            /* new */
        )
        {
            var image = Image.FromFile($@"{inPath}\{originalFilename}");
            var originalWidth = image.Width;
            var originalHeight = image.Height;

            Image thumbnail =
                new Bitmap(canvasWidth, canvasHeight); // changed parm names
            var graphic =
                Graphics.FromImage(thumbnail);

            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;

            /* ------------------ new code --------------- */

            // Figure out the ratio
            var ratioX = canvasWidth / (double) originalWidth;
            var ratioY = canvasHeight / (double) originalHeight;
            // use whichever multiplier is smaller
            var ratio = ratioX < ratioY ? ratioX : ratioY;

            // now we can get the new height and width
            var newHeight = Convert.ToInt32(originalHeight * ratio);
            var newWidth = Convert.ToInt32(originalWidth * ratio);

            // Now calculate the X,Y position of the upper-left corner 
            // (one of these will always be zero)
            var posX = Convert.ToInt32((canvasWidth - originalWidth * ratio) / 2);
            var posY = Convert.ToInt32((canvasHeight - originalHeight * ratio) / 2);

            graphic.Clear(Color.White); // white padding
            graphic.DrawImage(image, posX, posY, newWidth, newHeight);

            /* ------------- end new code ---------------- */

            var info =
                ImageCodecInfo.GetImageEncoders();
            EncoderParameters encoderParameters;
            encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 100L);


            //thumbnail.Save(path + newWidth + "." + originalFilename, info[1], encoderParameters);
            thumbnail.Save($@"{outPath}\resize_{originalFilename}", info[1], encoderParameters);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        

        private void btnDownloadGoogleImages_Click(object sender, EventArgs e)
        {
            //https://www.codeproject.com/Articles/259621/Google-Image-Search-Client-in-Csharp-and-WPF
            try
            {
                if (!string.IsNullOrEmpty(tbImagesDownloadPath.Text) && !string.IsNullOrEmpty(tbGoogleImagesUrl.Text))
                {
                    var document = new HtmlWeb().Load(tbGoogleImagesUrl.Text);


                    // Now, using LINQ to get all Images
                    List<HtmlNode> imageNodes = null;
                    imageNodes = (from HtmlNode node in document.DocumentNode.SelectNodes("//img")
                        where node.Name == "img"
                              && node.Attributes["src"] != null
                        //&& node.Attributes["class"] != null
                        //      && node.Attributes["class"].Value.StartsWith("rg_ic")
                        select node).ToList();

                    foreach (var node in imageNodes)
                    {
                        rtbUrlList.Text += node.Attributes["src"].Value + Environment.NewLine;
                    }


                    //var urls = document.DocumentNode.Descendants("div ")
                    //    .Select(i => i.GetAttributeValue("src", null))
                    //    .Where(s => !string.IsNullOrEmpty(s));


                    //foreach (HtmlNode node in document.DocumentNode.SelectNodes("//img"))
                    //{
                    //    rtbUrlList.Text += HtmlEntity.DeEntitize(node.NextSibling?.InnerText)?.Trim() + System.Environment.NewLine;
                    //}

                    //    foreach (var link in urls)
                    //{
                    //    rtbUrlList.Text += link + System.Environment.NewLine;
                    //}
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnImagesToSort_Click(object sender, EventArgs e)
        {
            folderDialogSettings.ShowDialog();
            tbImagesToSort.Text = folderDialogSettings.SelectedPath;
            Setting.ImagesFolder = tbImagesToSort.Text;
            tbImagesDownloadPath.Text = tbImagesToSort.Text;
        }

        private void btnSortedImages_Click(object sender, EventArgs e)
        {
            folderDialogSettings.ShowDialog();
            tbSortedImagesBasePath.Text = folderDialogSettings.SelectedPath;
            Setting.SortedImagesFolderBasePath = tbSortedImagesBasePath.Text;
        }

        private void btnImagesDownloadPath_Click(object sender, EventArgs e)
        {
            folderDialogSettings.ShowDialog();
            tbImagesDownloadPath.Text = folderDialogSettings.SelectedPath;
            Setting.SortedImagesFolderBasePath = tbImagesDownloadPath.Text;
            tbSortedImagesBasePath.Text = tbImagesDownloadPath.Text;
        }
    }
}