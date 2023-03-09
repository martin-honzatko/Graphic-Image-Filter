using GraphicImageFilter.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;

namespace GraphicImageFilter.VMs
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region private properties
        private ImageSource? _imageSource;
        private Effect? _imageEffect;
        private BitmapImage _bitmap;
        private TimeSpan _time;
        private DateTime _timeCode;
        private bool _loaded;
        #endregion

        #region RelayCommands
        public RelayCommand LoadMedia { get; set; }
        public RelayCommand GrayScale { get; set; }

        public RelayCommand ColourFolder { get; set; }

        public RelayCommand ColourCorrection { get; set; }

        public RelayCommand Blur { get; set; }

        public RelayCommand BlurParallel { get; set; }

        public RelayCommand ReturnChanges { get; set; }
        #endregion

        #region constructor
        public MainVM()
        {
            _bitmap = new BitmapImage();
            _timeCode = new DateTime();
            Time = new TimeSpan();
            LoadMedia = new RelayCommand(
                () =>
                {
                    if (_loaded == true)
                    {
                        _bitmap = new BitmapImage();
                        _loaded = false;
                    }

                    if (_loaded == false)
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                        fileDialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg";
                        fileDialog.RestoreDirectory = true;

                        if (fileDialog.ShowDialog() == true)
                        {
                            string selectedFileName = fileDialog.FileName;
                            ImageSource = GetBitmapImage(selectedFileName);
                            _loaded = true;
                        }
                    }
                }, () => true);
            GrayScale = new RelayCommand(
                () =>
                {
                    if (_loaded == false)
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                        fileDialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg";
                        fileDialog.RestoreDirectory = true;

                        if (fileDialog.ShowDialog() == true)
                        {
                            string selectedFileName = fileDialog.FileName;
                            ImageSource = GetBitmapImage(selectedFileName);
                            _loaded = true;
                        }
                    }

                    if (_loaded == true)
                    {
                        ImageSource = GetConvertedBitmap(PixelFormats.Gray32Float);
                    }
                }, () => true);

            ColourFolder = new RelayCommand(
                () =>
                {
                    if (_loaded == false)
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                        fileDialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg";
                        fileDialog.RestoreDirectory = true;

                        if (fileDialog.ShowDialog() == true)
                        {
                            string selectedFileName = fileDialog.FileName;
                            ImageSource = GetBitmapImage(selectedFileName);
                            _loaded = true;
                        }
                    }

                    if (_loaded == true)
                    {
                        ArrayBMIConverter.colourFolder = true;
                        var array2D = ArrayBMIConverter.BitmapImageToArray2D(_bitmap);
                        var wbm = ArrayBMIConverter.Array2DToWriteableBitmap(array2D, _bitmap);

                        ImageSource = ArrayBMIConverter.ConvertWriteableBitmapToBitmapImage(wbm);
                        ArrayBMIConverter.colourFolder = false;
                    }
                }, () => true);

            ColourCorrection = new RelayCommand(
                () =>
                {
                    if (_loaded == false)
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                        fileDialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg";
                        fileDialog.RestoreDirectory = true;

                        if (fileDialog.ShowDialog() == true)
                        {
                            string selectedFileName = fileDialog.FileName;
                            ImageSource = GetBitmapImage(selectedFileName);
                            _loaded = true;
                        }
                    }

                    if (_loaded == true)
                    {
                        ArrayBMIConverter.colourFolder = false;
                        var array2D = ArrayBMIConverter.BitmapImageToArray2D(_bitmap);
                        var wbm = ArrayBMIConverter.Array2DToWriteableBitmap(array2D, _bitmap);

                        ImageSource = ArrayBMIConverter.ConvertWriteableBitmapToBitmapImage(wbm);
                    }
                }, () => true);

            Blur = new RelayCommand(
                () =>
                {
                    if (_loaded == false)
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                        fileDialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg";
                        fileDialog.RestoreDirectory = true;

                        if (fileDialog.ShowDialog() == true)
                        {
                            string selectedFileName = fileDialog.FileName;
                            ImageSource = GetBitmapImage(selectedFileName);
                            _loaded = true;
                        }
                    }

                    if (_loaded == true)
                    {
                        BlurEffect blurEffect = new BlurEffect();
                        blurEffect.KernelType = KernelType.Gaussian;
                        blurEffect.Radius = 60;

                        ImageEffect = blurEffect;
                    }
                }, () => true);

            BlurParallel = new RelayCommand(
                () =>
                {
                    Parallel.Invoke(
                        () =>
                        {
                            if (_loaded == false)
                            {
                                OpenFileDialog fileDialog = new OpenFileDialog();
                                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                                fileDialog.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg";
                                fileDialog.RestoreDirectory = true;

                                if (fileDialog.ShowDialog() == true)
                                {
                                    string selectedFileName = fileDialog.FileName;
                                    ImageSource = GetBitmapImage(selectedFileName);
                                    _loaded = true;
                                }
                            }

                            if (_loaded == true)
                            {
                                _timeCode = DateTime.UtcNow;
                                BlurEffect blurEffect = new BlurEffect();
                                blurEffect.KernelType = KernelType.Gaussian;
                                blurEffect.Radius = 60;

                                ImageEffect = blurEffect;

                                Time = DateTime.UtcNow.Subtract(_timeCode);
                            }
                        });
                }, () => true);

            ReturnChanges = new RelayCommand(
                () =>
                {
                    if (_loaded == true)
                    {
                        ArrayBMIConverter.blue = 0xFF;
                        ArrayBMIConverter.green = 0xFF00;
                        ArrayBMIConverter.red = 0xFF0000;
                        ArrayBMIConverter.colourFolder = false;
                        ImageSource = _bitmap;
                        ImageEffect = null;
                        Time = new TimeSpan();
                    }
                }, () => true);
        }
        #endregion

        #region public properties
        public ImageSource? ImageSource
        {
            get { return _imageSource; }

            set
            {
                _imageSource = value;
                NotifyPropertyChanged();
            }
        }

        public Effect? ImageEffect
        {
            get { return _imageEffect; }

            set
            {
                _imageEffect = value;
                NotifyPropertyChanged();
            }
        }

        public TimeSpan Time
        {
            get { return _time; }

            set
            {
                _time = value;
                NotifyPropertyChanged();
            }
        }

        public int Blue
        {
            get { return ArrayBMIConverter.blue; }

            set
            {
                ArrayBMIConverter.blue = value;
                NotifyPropertyChanged();
            }
        }

        public int Green
        {
            get { return ColourIntHexConverter.ConvertGreen(ArrayBMIConverter.green); }

            set
            {
                ColourIntHexConverter.ConvertGreenBack(value);
                NotifyPropertyChanged();
            }
        }

        public int Red
        {
            get { return ColourIntHexConverter.ConvertRed(ArrayBMIConverter.red); }

            set
            {
                ColourIntHexConverter.ConvertRedBack(value);
                NotifyPropertyChanged();
            }
        }
        #endregion

        private BitmapImage GetBitmapImage(string fileName)
        {
            _bitmap.BeginInit();
            _bitmap.UriSource = new Uri(fileName);
            _bitmap.EndInit();

            return _bitmap;
        }

        private FormatConvertedBitmap GetConvertedBitmap(PixelFormat pixelFormat)
        {
            FormatConvertedBitmap grayBitmapSource = new FormatConvertedBitmap();
            grayBitmapSource.BeginInit();
            grayBitmapSource.Source = _bitmap;
            grayBitmapSource.DestinationFormat = pixelFormat;
            grayBitmapSource.EndInit();

            return grayBitmapSource;
        }

        #region NotifyPropertyChanged
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
    }
}
