/*
This is the Calculator Logic for the Software Testing and Quality Assurance Semester Project.
These methods compute the following: sample standard deviation, population standard deviation, mean, Z-Score, single linear regression equation, and the Y-value.
Matt Crowley
Kennesaw State University
Fall 2024
*/
 
namespace CalculatorLogic;

public class CalculatorLogic {
    
    // This is the method for computing the sample standard deviation.
    // preq-LOGIC-3
    public static double ComputeTheSampleStandardDeviation(List<double> listOfSamplesForSampleStandardDeviation)
    {
        // Failure Statements
        if (listOfSamplesForSampleStandardDeviation.Count == 0) {
            throw new ArgumentException("The list of provided samples cannot be empty.");
        }
        if (listOfSamplesForSampleStandardDeviation.Count == 1) {
            throw new ArgumentException("The list of provided samples must be more than one.");
        }
        if (listOfSamplesForSampleStandardDeviation.Any(anyNumber => double.IsNaN(anyNumber))) {
            throw new ArgumentException("The provided list contains invalid numbers.");
        }
        
        // Computing The Sample Standard Deviation.
        double average = listOfSamplesForSampleStandardDeviation.Average();
        double squares = listOfSamplesForSampleStandardDeviation.Sum(number => Math.Pow(number - average, 2));
        return Math.Sqrt(squares / (listOfSamplesForSampleStandardDeviation.Count - 1));
    }
    
    // This is the method for computing the population standard deviation.
    // preq-LOGIC-4
    public static double ComputeThePopulationStandardDeviation(List<double> listOfSamplesForPopulationStandardDeviation)
    {
        //Failure Statements
        if (listOfSamplesForPopulationStandardDeviation.Count == 0) {
            throw new ArgumentException("The list of provided samples cannot be empty.");
        }
        if (listOfSamplesForPopulationStandardDeviation.Count == 1) {
            throw new ArgumentException("The list of provided samples must be more than one.");
        }
        if (listOfSamplesForPopulationStandardDeviation.Any(anyNumber => double.IsNaN(anyNumber))) {
            throw new ArgumentException("The provided list contains invalid numbers.");
        }

        // Computing The Population Standard Deviation.
        double average = listOfSamplesForPopulationStandardDeviation.Average();
        double squares = listOfSamplesForPopulationStandardDeviation.Sum(number => Math.Pow(number - average, 2));
        return Math.Sqrt(squares / listOfSamplesForPopulationStandardDeviation.Count);
    }
    
    // This is the method for computing the mean.
    // preq-LOGIC-5
    public static double ComputeTheMean(List<double> valuesForTheMean)
    {
        // Failure Statements
        if (valuesForTheMean.Count == 0) {
            throw new ArgumentException("The list of provided values is empty.");
        }
        
        if (valuesForTheMean.Any(anyNumber => double.IsNaN(anyNumber))) {
            throw new ArgumentException("The provided list contains invalid numbers.");
        }
        
        // Computing The Mean.
        return valuesForTheMean.Average();
    }
    
    // This is the method for computing the Z-Score.
    // preq-LOGIC-6
    public static double ComputeTheZScore(List<double> valuesForTheZScore)
    {
        // Failure Statements
        if (valuesForTheZScore.Count != 3) {
            throw new ArgumentException("The list of provided values must be exactly three.");
        }
        if (valuesForTheZScore[1] == 0) {
            throw new ArgumentException("The mean cannot be zero.");
        }
        if (valuesForTheZScore[2] == 0) {
            throw new ArgumentException("The standard deviation cannot be zero.");
        }
        
        // Computing The Z-Score.
        return (valuesForTheZScore[0] - valuesForTheZScore[1]) / valuesForTheZScore[2];
    }
    
    // This is the method for computing the single linear regression equation.
    // preq-LOGIC-7
    public static string ComputeTheSingleLinearRegressionEquation(List<(double x, double y)> dataForSingleLinearRegressionEquation)
    {
        // A Failure Statement
        if (dataForSingleLinearRegressionEquation.Count == 0) {
            throw new ArgumentException("The list of provided data cannot be empty.");
        }
        double x = dataForSingleLinearRegressionEquation[0].x; double y = dataForSingleLinearRegressionEquation[0].y;
        
        // Failure Statements
        if (dataForSingleLinearRegressionEquation.All(plots => plots.x == 0 && plots.y == 0)) {
            return "y = 0x + 0";
        }
        if (dataForSingleLinearRegressionEquation.All(plot => plot.x == x)) {
            throw new InvalidOperationException("The X values cannot all be the same.");
        }
        if (dataForSingleLinearRegressionEquation.All(plot => plot.y == y)) {
            throw new InvalidOperationException("The Y values cannot all be the same.");
        }

        // Computing The Single Linear Regression Equation.
        double sumOfX = 0.0; double sumOfY = 0.0; double sumOfXAndY = 0.0; double sumOfX2 = 0.0;

        for (int i = 0; i < dataForSingleLinearRegressionEquation.Count; i++) {
            (double x, double y) point = dataForSingleLinearRegressionEquation[i];
            sumOfX2 += point.x * point.x; sumOfX += point.x; sumOfY += point.y; sumOfXAndY += point.x * point.y;
        }
        
        double slope = (dataForSingleLinearRegressionEquation.Count * sumOfXAndY - sumOfX * sumOfY) / (dataForSingleLinearRegressionEquation.Count * sumOfX2 - sumOfX * sumOfX);
        double yIntercept = (sumOfY - slope * sumOfX) / dataForSingleLinearRegressionEquation.Count;
        return "y = " + slope + "x + " + yIntercept + "";
    }
    
    // This is the method for computing the y-value.
    // preq-LOGIC-8
    public static double PredictTheYValue(List<double> valuesForTheYValue)
    {
        // Failure Statement
        if (valuesForTheYValue.Count != 3) {
            throw new ArgumentException("The list of provided values must be exactly three.");
        }
        
        // Computing the Y-Value.
        return valuesForTheYValue[0] * valuesForTheYValue[1] + valuesForTheYValue[2];
    }
}