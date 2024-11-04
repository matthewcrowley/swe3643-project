/*
These are the Unit Tests for the Calculator Logic for the Software Testing and Quality Assurance Semester Project.
These unit tests follow the AAA unit test methodology.
These tests achieve 100% coverage across all paths.
Matt Crowley
Kennesaw State University
Fall 2024
*/

namespace CalculatorLogicUnitTests;

using CalculatorLogic;

public class CalculatorLogicUnitTests {
    
    // This is the beginning of the unit tests for the ComputeTheSampleStandardDeviation() method.
    // These tests cover failure statements along with valid inputs.
    // preq-UNIT-TEST-2
    [Test]
    public void ComputeTheSampleStandardDeviation_ValidListOfInputs_ReturnsTheCorrectSampleStandardDeviation()
    {
        // ARRANGE
        List<double> listOfSamplesForSampleStandardDeviation = new List<double> {9.0,6.0,8.0,5.0,7.0};

        // ACT
        double sampleStandardDeviation = CalculatorLogic.ComputeTheSampleStandardDeviation(listOfSamplesForSampleStandardDeviation);

        // ASSERT
        Assert.AreEqual(1.5811388300841898, sampleStandardDeviation);
    }

    // preq-UNIT-TEST-2
    [Test]
    public void ComputeTheSampleStandardDeviation_EmptyListOfInputs_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> listOfSamplesForSampleStandardDeviation = new List<double>();
        
        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheSampleStandardDeviation(listOfSamplesForSampleStandardDeviation));
        
        // ASSERT
        Assert.That(errorMessage.Message, Is.EqualTo("The list of provided samples cannot be empty."));
    }
    
    // preq-UNIT-TEST-2
    [Test]
    public void ComputeTheSampleStandardDeviation_InputListOfOne_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> listOfSamplesForSampleStandardDeviation = new List<double> {1.0};
        
        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheSampleStandardDeviation(listOfSamplesForSampleStandardDeviation));
        
        // ASSERT
        Assert.That(errorMessage.Message, Is.EqualTo("The list of provided samples must be more than one."));
    }
    
    // preq-UNIT-TEST-2
    [Test]
    public void ComputeTheSampleStandardDeviation_InputListContainsInvalidNumber_ThrowsAnArgumentException()
    {
        // ARRANGE
        var listOfSamplesForSampleStandardDeviation = new List<double> {double.NaN, 1.0, 2.0, 3.0};

        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheSampleStandardDeviation(listOfSamplesForSampleStandardDeviation));
        
        // ASSERT
        Assert.AreEqual("The provided list contains invalid numbers.", errorMessage.Message);
    }
    
    // preq-UNIT-TEST-2
    [Test]
    public void ComputeTheSampleStandardDeviation_InputListContainsAllZeros_ReturnsZero()
    {
        // ARRANGE
        var listOfSamplesForSampleStandardDeviation = new List<double> {0.0, 0.0};

        // ACT
        double sampleStandardDeviation = CalculatorLogic.ComputeTheSampleStandardDeviation(listOfSamplesForSampleStandardDeviation);

        // ASSERT
        Assert.AreEqual(0.0, sampleStandardDeviation);
    }

    // This is the beginning of the unit tests for the ComputeThePopulationStandardDeviation() method.
    // These tests cover failure statements along with valid inputs.
    // preq-UNIT-TEST-3
    [Test]
    public void ComputeThePopulationStandardDeviation_ValidListOfSInputs_ReturnsTheCorrectPopulationStandardDeviation()
    {
        // ARRANGE
        var listOfSamplesForPopulationStandardDeviation = new List<double> {9.0, 6.0, 8.0, 5.0, 7.0};
        
        // ACT
        double populationStandardDeviation = CalculatorLogic.ComputeThePopulationStandardDeviation(listOfSamplesForPopulationStandardDeviation);
        
        // ASSERT
        Assert.AreEqual(1.4142135623730951, populationStandardDeviation);
    }
    
    // preq-UNIT-TEST-3
    [Test]
    public void ComputeThePopulationStandardDeviation_EmptyListOfInputs_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> listOfSamplesForPopulationStandardDeviation = new List<double>();
        
        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeThePopulationStandardDeviation(listOfSamplesForPopulationStandardDeviation));
        
        // ASSERT
        Assert.That(errorMessage.Message, Is.EqualTo("The list of provided samples cannot be empty."));
    }
    
    // preq-UNIT-TEST-3
    [Test]
    public void ComputeThePopulationStandardDeviation_InputListOfOne_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> listOfSamplesForPopulationStandardDeviation = new List<double> {1.0};
        
        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeThePopulationStandardDeviation(listOfSamplesForPopulationStandardDeviation));
        
        // ASSERT
        Assert.That(errorMessage.Message, Is.EqualTo("The list of provided samples must be more than one."));
    }
    
    // preq-UNIT-TEST-3
    [Test]
    public void ComputeThePopulationStandardDeviation_InvalidNumberInInputList_ThrowsAnArgumentException()
    {
        // ARRANGE
        var listOfSamplesForPopulationStandardDeviation = new List<double> {double.NaN, 1.0, 2.0, 3.0};

        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeThePopulationStandardDeviation(listOfSamplesForPopulationStandardDeviation));
        
        // ASSERT
        Assert.AreEqual("The provided list contains invalid numbers.", errorMessage.Message);
    }
    
    // preq-UNIT-TEST-3
    [Test]
    public void ComputeThePopulationStandardDeviation_ListOfAllZeros_ReturnsZero()
    {
        // ARRANGE
        List<double> listOfSamplesForPopulationStandardDeviation = new List<double> {0.0, 0.0};

        // ACT
        double populationStandardDeviation = CalculatorLogic.ComputeThePopulationStandardDeviation(listOfSamplesForPopulationStandardDeviation);

        // ASSERT
        Assert.AreEqual(0.0, populationStandardDeviation);
    }
    
    // This is the beginning of the unit tests for the ComputeTheMean() method.
    // These tests cover failure statements along with valid inputs.
    // preq-UNIT-TEST-4
    [Test]
    public void ComputeTheMean_ValidListOfInputs_ReturnsTheCorrectMean()
    {
        // ARRANGE
        List<double> valuesForTheMean = new List<double> {9.0, 6.0, 8.0, 5.0, 7.0};
        
        // ACT
        double mean = CalculatorLogic.ComputeTheMean(valuesForTheMean);
        
        // ASSERT
        Assert.AreEqual(7, mean);
    }
    
    // preq-UNIT-TEST-4
    [Test]
    public void ComputeTheMean_EmptyListOfInputs_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> valuesForTheMean = new List<double>();
        
        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheMean(valuesForTheMean));
        
        // ASSERT
        Assert.That(errorMessage.Message, Is.EqualTo("The list of provided values is empty."));
    }
    
    // preq-UNIT-TEST-4
    [Test]
    public void ComputeTheMean_InvalidNumberInListOfInputs_ThrowsAnArgumentException()
    {
        // Arrange
        List<double> valuesForTheMean = new List<double> {double.NaN, 1.0, 2.0, 3.0};

        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheMean(valuesForTheMean));
        
        // ASSERT
        Assert.AreEqual("The provided list contains invalid numbers.", errorMessage.Message);
    }
    
    // This is the beginning of the unit tests for the ComputeTheZScore() method.
    // These tests cover failure statements along with valid inputs.
    // preq-UNIT-TEST-5
    [Test]
    public void ComputeTheZScore_ValidListOfInputs_ReturnsTheCorrectZScore()
    {
        // ARRANGE
        List<double> valuesForTheZScore = new List<double> {11.5, 7.0, 1.5811388300841898};

        // ACT
        double zScore = CalculatorLogic.ComputeTheZScore(valuesForTheZScore);

        // ASSERT
        Assert.AreEqual(2.846049894151541, zScore);
    }
    
    // preq-UNIT-TEST-5
    [Test]
    public void ComputeTheZScore_InvalidMeanInInput_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> valuesForTheZScore = new List<double> {11.5, 0, 1.5811388300841898};

        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheZScore(valuesForTheZScore));
        
        // ASSERT
        Assert.AreEqual("The mean cannot be zero.", errorMessage.Message);
    }
    
    // preq-UNIT-TEST-5
    [Test]
    public void ComputeTheZScore_InvalidStandardDeviationInInput_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> valuesForTheZScore = new List<double> {11.5, 7.0, 0};

        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheZScore(valuesForTheZScore));
        
        // ASSERT
        Assert.AreEqual("The standard deviation cannot be zero.", errorMessage.Message);
    }
    
    // preq-UNIT-TEST-5
    [Test]
    public void ComputeTheZScore_InvalidListLength_ThrowsArgumentException()
    {
        // ARRANGE
        List<double> valuesForTheZScore = new List<double> {11.5, 7.0};

        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheZScore(valuesForTheZScore));
        
        // ASSERT
        Assert.AreEqual("The list of provided values must be exactly three.", errorMessage.Message);
    }
    
    // This is the beginning of the unit tests for the ComputeTheSingleLinearRegressionEquation() method.
    // These tests cover failure statements along with valid inputs.
    // preq-UNIT-TEST-6
    [Test]
    public void ComputeTheSingleLinearRegressionEquation_ValidListOfData_ReturnsTheCorrectEquation()
    {
        // ARRANGE
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>
        {
            (1.47, 52.21),
            (1.5, 53.12),
            (1.52, 54.48),
            (1.55, 55.84),
            (1.57, 57.2),
            (1.6, 58.57),
            (1.63, 59.93),
            (1.65, 61.29),
            (1.68, 63.11),
            (1.7, 64.47),
            (1.73, 66.28),
            (1.75, 68.1),
            (1.78, 69.92),
            (1.8, 72.19),
            (1.83, 74.46)
        };

        // ACT
        string singleLinearRegressionEquation = CalculatorLogic.ComputeTheSingleLinearRegressionEquation(dataForSingleLinearRegressionEquation);

        // ASSERT
        Assert.AreEqual("y = 61.272186542107434x + -39.061955918838656", singleLinearRegressionEquation);
    }
    
    // preq-UNIT-TEST-6
    [Test]
    public void ComputeTheSingleLinearRegressionEquation_EmptyList_ThrowsAnArgumentException()
    {
        // ARRANGE
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>();

        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeTheSingleLinearRegressionEquation(dataForSingleLinearRegressionEquation)); 
        
        // ASSERT
        Assert.AreEqual("The list of provided data cannot be empty.", errorMessage.Message);
    }
    
    // preq-UNIT-TEST-6
    [Test]
    public void ComputeTheSingleLinearRegressionEquation_ListOfAllZeros_ReturnsAZeroEquation()
    {
        // ARRANGE
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>
        {
            (0, 0),
            (0, 0),
            (0, 0)
        };

        // ACT
        string singleLinearRegressionEquation = CalculatorLogic.ComputeTheSingleLinearRegressionEquation(dataForSingleLinearRegressionEquation);

        // ASSERT
        Assert.AreEqual("y = 0x + 0", singleLinearRegressionEquation);
    }
    
    // preq-UNIT-TEST-6
    [Test]
    public void ComputeTheSingleLinearRegressionEquation_AllXValuesOfTheListAreTheSame_ThrowsAnInvalidOperationException()
    {
        // ARRANGE
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>
        {
            (1, 2),
            (1, 3),
            (1, 5)
        };

        // ACT
        var errorMessage = Assert.Throws<InvalidOperationException>(() => CalculatorLogic.ComputeTheSingleLinearRegressionEquation(dataForSingleLinearRegressionEquation));
        
        // ASSERT
        Assert.AreEqual("The X values cannot all be the same.", errorMessage.Message);
    }
    
    // preq-UNIT-TEST-6
    [Test]
    public void ComputeTheSingleLinearRegressionEquation_AllYValuesOfTheListAreTheSame_ThrowsAnInvalidOperationException()
    {
        // ARRANGE
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>
        {
            (2, 5),
            (3, 5),
            (4, 5)
        };

        // ACT
        var errorMessage = Assert.Throws<InvalidOperationException>(() => CalculatorLogic.ComputeTheSingleLinearRegressionEquation(dataForSingleLinearRegressionEquation));
        
        // ASSERT
        Assert.AreEqual("The Y values cannot all be the same.", errorMessage.Message);
    }
    
    // This is the beginning of the unit tests for the PredictTheYValue() method.
    // These tests cover failure statements along with valid inputs.
    // preq-UNIT-TEST-7
    [Test]
    public void PredictTheYValue_ListOfOneInput_ThrowsAnArgumentException()
    {
        // ARRANGE
        List<double> valuesForTheYValue = new List<double> {1.0};
        
        // ACT
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.PredictTheYValue(valuesForTheYValue));
        
        // ASSERT
        Assert.That(errorMessage.Message, Is.EqualTo("The list of provided values must be exactly three."));
    }
    
    // preq-UNIT-TEST-7
    [Test]
    public void PredictTheYValue_ValidListOfInputs_ReturnsTheCorrectYValue()
    {
        // ARRANGE
        List<double> valuesForTheYValue = new List<double> {1.535, 61.272186542107434, -39.061955918838656};
        
        // ACT
        double yValue = CalculatorLogic.PredictTheYValue(valuesForTheYValue);
        
        // ASSERT
        Assert.AreEqual(54.990850423296244, yValue);
    }
}