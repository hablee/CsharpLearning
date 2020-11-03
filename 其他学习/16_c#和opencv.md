- 首先新建一个空白控制台工程

- 然后右键选择项目，管理NuGet程序包，选择浏览，搜索OpenCvSharp4安装，搜索OpenCvSharp4.runtime.win安装

- 键入代码
```c#
using System;
using OpenCvSharp;

namespace firstOpencv
{
    class Program
    {
        static void Main(string[] args)
        {
            CVSImage cvImage = new CVSImage(@"D:\pythonLean\test\2.jpg");
            Console.WriteLine("image width: {0}", cvImage.Width);
            Console.WriteLine("image height: {0}", cvImage.Height);
            cvImage.showImage("picture", 0);
        }
    }
    class CVSImage
    {
        private string path;
        /// <summary>
        /// 图像文件路径
        /// </summary>
        public string Path { get => path; set => path = value; }

        private int width;
        /// <summary>
        /// 宽
        /// </summary>
        public int Width { get => width; }

        private int height;
        /// <summary>
        /// 高
        /// </summary>
        public int Height { get => height; }

        private long size;
        /// <summary>
        /// 图像尺寸size = height * width
        /// </summary>
        public long Size { get => size; }

        private Mat srcImag;

        public CVSImage()
        {
            path = "";
            width = 0;
            height = 0;
            size = 0;
            srcImag = new Mat();
        }

        public CVSImage(string imagePath,int readMode = 1)
        {
            path = imagePath;
            srcImag = Cv2.ImRead(path, (ImreadModes)readMode);
            width = srcImag.Width;
            height = srcImag.Height;
            size = width * height;
        }

        public int showImage(string winName, int widowType = 1, int showTime = 0)
        {
            if (srcImag == null || showTime < 0)
            {
                return -1;
            }
            WindowMode mode = (WindowMode)widowType;
            Cv2.NamedWindow(winName, mode);
            Cv2.ImShow(winName, srcImag);
            Cv2.WaitKey(showTime);

            return 0;
        }
    }
}

```
