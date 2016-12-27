﻿using System;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.UI;

namespace SolitaireAI {
	public static class Util {
		public static void Log(string message) {
			Console.WriteLine(message);
			Debug.WriteLine(message);
		}
		
		public static double CompareHistograms(Mat img, Mat img2) {
			using (Mat hist = new Mat())
			using (Mat hist2 = new Mat())
			using (VectorOfMat vm = new VectorOfMat())
			using (VectorOfMat vm2 = new VectorOfMat()) {
				vm.Push(img);
				vm2.Push(img2);
				var channels = new int[] { 0 };
				var histSize = new int[] { 256 };
				var ranges = new float[] { 0, 256, };
				CvInvoke.CalcHist(vm, channels, null, hist, histSize, ranges, false);
				CvInvoke.CalcHist(vm2, channels, null, hist2, histSize, ranges, false);

				//CvInvoke.Normalize(hist, hist, 0, 255, NormType.MinMax);
				//CvInvoke.Normalize(hist2, hist2, 0, 255, NormType.MinMax);

				//double res = CvInvoke.CompareHist(hist, hist2, HistogramCompMethod.Bhattacharyya);
				//Debug.Log("Cards in Stock: " + (res > 0.5));

				return CvInvoke.CompareHist(hist, hist2, HistogramCompMethod.Correl);
			}
		}

		// Compare two images by getting the L2 error (square-root of sum of squared error).
		public static double GetSimilarity(Mat A, Mat B) {
			if (A.Rows > 0 && A.Rows == B.Rows && A.Cols > 0 && A.Cols == B.Cols) {
				// Calculate the L2 relative error between images.
				double errorL2 = CvInvoke.Norm(A, B, NormType.L2);
				// Convert to a reasonable scale, since L2 error is summed across all pixels of the image.
				double similarity = errorL2 / (double)(A.Rows * A.Cols);
				return similarity;
			}
			else {
				//Images have a different size
				return 100000000.0;  // Return a bad value
			}
		}

		/*public static double Correlation(Mat image_1, Mat image_2) {
			// convert data-type to "float"
			Mat im_float_1 = new Mat();
			image_1.ConvertTo(im_float_1, DepthType.Cv32F);
			Mat im_float_2 = new Mat();
			image_2.ConvertTo(im_float_2, DepthType.Cv32F);

			int n_pixels = im_float_1.Rows * im_float_1.Cols;

			// Compute mean and standard deviation of both images
			MCvScalar im1_Mean = new MCvScalar(), im1_Std = new MCvScalar(), im2_Mean = new MCvScalar(), im2_Std = new MCvScalar();
			CvInvoke.MeanStdDev(im_float_1, ref im1_Mean, ref im1_Std);
			CvInvoke.MeanStdDev(im_float_2, ref im2_Mean, ref im2_Std);

			// Compute covariance and correlation coefficient
			
			double covar = (im_float_1 - im1_Mean).dot(im_float_2 - im2_Mean) / n_pixels;
			double correl = covar / (im1_Std[0] * im2_Std[0]);

			return correl;
		}*/
	}
}
