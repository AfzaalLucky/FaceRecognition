﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.Face;


using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;




namespace FaceRecognitionEMGU
{


    public class EmguFaceDetector
    {


        private List<Image<Gray, byte>> images;
        private List<int> labels;


        //const attrs
        private const string CROPPED_IMAGE_DIR = @"cropped_image";
        private const string CROPPED_IMAGE_FILE = @"cropped_image.conf";
        private const char SEPARATOR = ';';



        //public FaceRecognizer model = new FisherFaceRecognizer(0, double.MaxValue);
        public FaceRecognizer model;

        public CascadeClassifier cascade;

         public int detect(System.Drawing.Bitmap img)
         {
            // Normalizing it to grayscale
             Image<Gray, byte> normalizedMasterImage = new Image<Gray, byte>(img);
             
             return detect (normalizedMasterImage);
         }

         public int detect(Image<Gray, byte> img)
        {
            var faces = cascade.DetectMultiScale(img);

            if (img == null) return -1;

            if (img.Height != 200 || img.Width != 200)
                img = img.Resize(200, 200, Emgu.CV.CvEnum.Inter.Cubic);


            var res = model.Predict(img);
            return res.Label;
        }


        public EmguFaceDetector(String preloadedTraining="")
        {
            

            model = new FisherFaceRecognizer(2, 3000);

            if (preloadedTraining == "")
            {
                images = new List<Image<Gray, byte>>();
                labels = new List<int>();
                prepareTrainingData();
                model.Train(images.ToArray(), labels.ToArray());
                model.Save("Default");
            }
            else
            {
                if (preloadedTraining=="Default")
                    model.Load(preloadedTraining);
                else
                    model.Load(preloadedTraining);
            }

            cascade = new CascadeClassifier(AppDomain.CurrentDomain.BaseDirectory + "haarcascades\\haarcascade_frontalface_default.xml");

       
        }



        private void prepareTrainingData()
        {
           
           string file = AppDomain.CurrentDomain.BaseDirectory + CROPPED_IMAGE_DIR + "\\" + CROPPED_IMAGE_FILE;
           
            if (!File.Exists(file))
            {
                string errMsg = "No valid input file was given, please check the given filename.";
                System.Console.WriteLine(errMsg);
                throw new Exception(errMsg);
            }

            try
            {
                StreamReader rd = new StreamReader(new FileStream(file, FileMode.Open, FileAccess.Read));
                string line, path, label;
                while ((line = rd.ReadLine()) != null)
                {
                    String[] pathInfos = line.Split(SEPARATOR);
                    if (pathInfos.Length > 0)
                    {
                        path = pathInfos[0];
                        label = pathInfos[1];
                        Image<Gray, byte> img = null;

                        if (path != null && label != null)
                        {
                            
                            path = AppDomain.CurrentDomain.BaseDirectory + CROPPED_IMAGE_DIR + "\\" + path + ".jpg";

                            if (File.Exists(path))
                            {
                                img = new Image<Gray, byte>(path);
                                if (img.Height != 200 || img.Width != 200)
                                    img = img.Resize(200, 200, Emgu.CV.CvEnum.Inter.Cubic);

                                images.Add(img);
                                labels.Add(int.Parse(label));
                            }
                        }
                    }
                }//end of while

                rd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
