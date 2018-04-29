using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using AForge;

namespace shape_recognizer
{
    class ImageHandler
    {
        public Bitmap bitmap { get; private set; }
        public BitmapData bitmapData { get; private set; }
        public ImageHandler (Bitmap rawImage)
        {
            bitmap = rawImage;           
        }

        public void GetImageObjects()
        {
            BlobCounter bc = new BlobCounter();
            bc.FilterBlobs = true;
            bc.ProcessImage(bitmap);
            Blob[] blobs = bc.GetObjectsInformation();            
        }      

        public List<List<System.Drawing.Point>> GetEdges()
        {
            // lock image
            BitmapData bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, bitmap.PixelFormat);

            // step 1 - turn background to black
            ColorFiltering colorFilter = new ColorFiltering();

            colorFilter.Red = new IntRange(0, 64);
            colorFilter.Green = new IntRange(0, 64);
            colorFilter.Blue = new IntRange(0, 64);
            colorFilter.FillOutsideRange = false;

            colorFilter.ApplyInPlace(bitmapData);

            // step 2 - locating objects
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 5;
            blobCounter.MinWidth = 5;

            blobCounter.ProcessImage(bitmapData);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            bitmap.UnlockBits(bitmapData);
            List<List<System.Drawing.Point>> edges = new List<List<System.Drawing.Point>>();
            for(int i = 0; i < blobs.Length; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                List<System.Drawing.Point> edgePointsNormal = ToPointsArray(edgePoints);
                edges.Add(edgePointsNormal);
            }
            return edges;
        }

        // Conver list of AForge.NET's points to array of .NET points
        private List<System.Drawing.Point> ToPointsArray(List<IntPoint> points)
        {
            List<System.Drawing.Point> array = new List<System.Drawing.Point>();

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array.Add(new System.Drawing.Point(points[i].X, points[i].Y));
            }

            return array;
        }
    }
}
