DT Coding Exam
==============

 

Coding Exam for DT Tech lead, the project will convert an input decimal number
to English words.

 

| Name                    | Value              |
|-------------------------|--------------------|
| Author                  | Haihao Yan         |
| Date                    | 04/05/2017         |
| .Net Version            | 4.5                |
| Development Environment | Visual Studio 2015 |

 

Solution Overview
-----------------

 

| Name                 | Decription                                                                                                                                                   |
|----------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------|
| DT.CodeExam.Command  | Console application used for testing foundation library. It can also be used for creating scheduled tasks for future project.                                |
| DT.CodeExam.Core     | Core library which provides the foundation logic for converting numbers to word.                                                                             |
| DT.CodeExam.Services | WebService server, we adopted WCF as it is one of the most recommended solution from Microsoft                                                               |
| DT.CodeExam.UnitTest | Test library which contains all test cases for entire solutions. We didn’t have code coverage report due to the version of visual studio that we are using.  |
| DT.CodeExam.Web      | MVC project which consumes WCF Services and display it to end user                                                                                           |

 

How to run the project
----------------------

 

Please uses the following steps to run the project

1.  Open the .sln file

2.  Right click “DT.CodeExam.Web” -\> Debug

3.  Once successfully started, you will be able to see the test site

 

Note: please make sure Port: 8733 is available. It is where the WCF services
hosted.

 

How to run the Test
-------------------

 

Please uses the following steps to run the test cases

1.  Open Visual Studio 2015

2.  On top menu select “Test” \> “Run” \> “All Tests”

 

Once successfully executed, you shall be able to see the test execution report
in test explorer.
