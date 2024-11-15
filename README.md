# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator Unit Tests

This repository contains the source code for the Calculator Logic and the CalculatorLogic Unit Tests. It also contains this README that lists the project team members, explains the system architecture with a professional diagram, explains the enviornment that this project was built in, along with step-by-step instructions on how to execute the project code on your own machine. On top of this, this README also reviews the 100% unit test coverage that my tests cover, and provides a quality YouTube video that further explains this repository and how to execute the unit tests on your machine.

**This project includes:** 

- A calculator module that performs these statistical functions:
	- The computation of the mean from a list of numeric values.
	- The computation of the sample and population standard deviations from a list of numeric values.
	- The computation of the Z-score from a value, mean, and standard deviation.
	- The computation of the single variable regression formula in the form of y = mx + b where you derive m (slope) and b (intercept) from a list of x,y numeric pairs.
	- The prediction of the Y-value from a regression formula where you supply the X value, the slope (m) and the intercept (b).
- A calculator unit tests module that achieves 100% coverage while testing:
	- Failing states.
	- Succeeding states.
	- Other various tests to achieve **100%** coverage.
	- A total of **24** unit tests.
- A README.md file that explains and contains the following:
	- The person behind this project.
	- A professional diagram explaining the system architecture.
	- The environment required for this project.
	- Step-by-step instructions on how to execute these unit tests on your own machine.
	- Images demonstrating successfully ran unit tests along with their coverage of 100%.
	- A YouTube video fully explaining this repository and the steps needed to clone this project and run the tests.

## Table of Contents

- [Environment](#environment)
- [Team Members](#team-members)
- [Architecture](#architecture)
- [Executing Unit Tests](#executing-unit-tests)
- [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage)
- [Final Video Presentation](#final-video-presentation)

## Environment


## Team Members
This project was completed by one person:
- Matt Crowley 
	- Fun Fact: Loves animals! Would not hurt a fly!

## Architecture
The system is designed in a way where the two modules are loosely coupled. There are two different projects in this Rider solution. There is a CalculatorLogic project and a CalculatorLogicUnitTests project. The unit test class does not perform any mathematical operations whatsoever. It simply references the calculator logic module and performs tests on it. The tests achieve 100% coverage whilst testing for various different failing states and succeeding states. This diagram was created in PlantUML, and I will provide the diagram along with the code below.

**System Architecture Diagram**

![Project System Architecture](README.assets/CalculatorUnitTestsProjectArchitecture.PNG)

**PlantUML Code**

```
@startuml
allowmixing

package "Calculator Logic Module" #lightblue
{
    class CalculatorLogic {
        + ComputeTheSampleStandardDeviation()
        + ComputeThePopulationStandardDeviation()
        + ComputeTheMean()
        + ComputeTheZScore()
        + ComputeTheSingleLinearRegressionEquation()
        + PredictTheYValue()
    }

}

package "Calculator Logic Unit Tests via NUnit (C#)" #lightyellow
{
  class CalculatorLogicUnitTests {
    + ComputeTheSampleStandardDeviation_ValidListOfInputs_ReturnsTheCorrectSampleStandardDeviation()
    + ComputeTheSampleStandardDeviation_EmptyListOfInputs_ThrowsAnArgumentException()
    + ComputeTheSampleStandardDeviation_InputListOfOne_ThrowsAnArgumentException()
    + ComputeTheSampleStandardDeviation_InputListContainsInvalidNumber_ThrowsAnArgumentException()
    + ComputeTheSampleStandardDeviation_InputListContainsAllZeros_ReturnsZero()
    + ComputeThePopulationStandardDeviation_ValidListOfSInputs_ReturnsTheCorrectPopulationStandardDeviation()
    + ComputeThePopulationStandardDeviation_EmptyListOfInputs_ThrowsAnArgumentException()
    + ComputeThePopulationStandardDeviation_InputListOfOne_ThrowsAnArgumentException()
    + ComputeThePopulationStandardDeviation_InvalidNumberInInputList_ThrowsAnArgumentException()
    + ComputeThePopulationStandardDeviation_ListOfAllZeros_ReturnsZero()
    + ComputeTheMean_ValidListOfInputs_ReturnsTheCorrectMean()
    + ComputeTheMean_EmptyListOfInputs_ThrowsAnArgumentException()
    + ComputeTheMean_InvalidNumberInListOfInputs_ThrowsAnArgumentException()
    + ComputeTheZScore_ValidListOfInputs_ReturnsTheCorrectZScore()
    + ComputeTheZScore_InvalidMeanInInput_ThrowsAnArgumentException()
    + ComputeTheZScore_InvalidStandardDeviationInInput_ThrowsAnArgumentException()
    + ComputeTheZScore_InvalidListLength_ThrowsArgumentException()
    + ComputeTheSingleLinearRegressionEquation_ValidListOfData_ReturnsTheCorrectEquation()
    + ComputeTheSingleLinearRegressionEquation_EmptyList_ThrowsAnArgumentException()
    + ComputeTheSingleLinearRegressionEquation_ListOfAllZeros_ReturnsAZeroEquation()
    + ComputeTheSingleLinearRegressionEquation_AllXValuesOfTheListAreTheSame_ThrowsAnInvalidOperationException()
    + ComputeTheSingleLinearRegressionEquation_AllYValuesOfTheListAreTheSame_ThrowsAnInvalidOperationException()
    + PredictTheYValue_ListOfOneInput_ThrowsAnArgumentException()
    + PredictTheYValue_ValidListOfInputs_ReturnsTheCorrectYValue()
  }
}

CalculatorLogicUnitTests -> CalculatorLogic : References

@enduml
```

## Executing Unit Tests
I will now walk you through executing the unit tests of this project through the command line. This will be a step by-step-process with numbered instructions. After I show you how to execute the tests from the command line, I will then provide an optional section showing you how to execute the tests in the Rider IDE (*if you have it on your machine*), but it is not needed to execute the tests because you can ignore that section and execute the unit tests from the command prompt.<br>Please note that these command line instructions are tailored to those who have little to no experience in the command line / terminal.<br>
**Executing the Unit Tests from the Command Line**
This is the step-by-step process to cloning this repository to your machine and executing the unit tests from your command line. When given a command for you to input into your command line, feel free to copy and paste!
1.	Clone the repository to your machine.
To clone the repository to your machine, press the green "Code" button on the top right of the repository, and then copy the link to your clipboard.
![RepoCloneImage](README.assets/RepoCloneImage.PNG)
2.	Open your command line / terminal.
On Windows, open the "Start" menu and type `cmd` and click "Command Prompt". If you are on Mac, click the Launchpad icon in the Dock, type `Terminal` and click "Terminal".
![CommandLineImage](README.assets/CommandLineImage.PNG)
3.	Direct to a chosen directory.
You want to choose where you want to place your cloned repository. To direct to any given directory, use the `cd` command, followed by the name of the directory. You can choose any directory for this, but I wanted to place the cloned repository in my Downloads folder, so my command was `cd Downloads`.
![CommandLineDownloadsImage](README.assets/CommandLineDownloadsImage.PNG)
4.	Clone the repository.
Once you have directed to your chosen directory, use the `git clone` command followed by the URL of the repository. For example, my command for cloning this repository to my machine was `git clone https://github.com/matthewcrowley/swe3643-project.git`.
![CommandLineRepoCloned](README.assets/CommandLineRepoCloned.PNG)
5.	Navigate to the newly cloned repository.
The name of this repository is "swe3643-project", so the command to navigate to the repository is `cd swe3643-project`.
![NavigateToProject](README.assets/NavigateToProject.PNG)
6.	Navigate to the source code directory.
The name of the directory is "src", so the command is `cd src`.
![NavigateToSource](README.assets/NavigateToSource.PNG)
7.	Navigate to the Calculator directory.
The name of this directory is simply "Calculator", so the command is `cd Calculator`.
![NavigateToCalculator](README.assets/NavigateToCalculator.PNG)
8.	Navigate to the Unit Tests directory.
The name of the unit test directory is "CalculatorLogicUnitTests", so the command is `cd CalculatorLogicUnitTests`.
![NavigateToUnitTests](README.assets/NavigateToUnitTests.PNG)
9.	Execute the Unit Tests.
Once in the unit tests directory, run the unit tests. The command for this is `dotnet test`.
![CommandLineUnitTests](README.assets/CommandLineUnitTests.PNG)

**Executing the Unit Tests from Rider IDE (OPTIONAL)**

## Reviewing Unit Test Coverage
In this project, I wrote a total of **24** unit tests to test the statistical functions in my Calculator Logic module. Once the tests are run through either the command line or the Rider C# IDE, they all succeed and achieve 100% test coverage of all the statements and their paths. The first two screen captures display all of the unit tests succeeding, whilst the following two screen captures show the 100% coverage in Test Coverage feature in Rider. <br>
<br>**Unit Test Successes**
![UnitTestsSuccess1](README.assets/UnitTestsSuccess1.PNG)
![UnitTestsSuccess2](README.assets/UnitTestsSuccess2.PNG)

**100% Unit Test Coverage**
![TotalTestCoverage1](README.assets/UnitTestsTotalCoverage1.PNG)
![TotalTestCoverage2](README.assets/UnitTestsTotalCoverage2.PNG)

## Final Video Presentation
This final video presentation on YouTube is of me walking you through this repository along with executing my unit tests from the command line. Along with this, I also hop into my Rider IDE to show off my Calculator Logic and my Calculator Logic Unit Tests and their **100%** coverage! Check it out!
