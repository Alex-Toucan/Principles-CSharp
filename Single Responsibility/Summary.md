### **Code Summary - Single Responsibility Principle**

##### **Top-Level Class**
Program.cs -> Always only resposible for the application process (the what) not the sub-processes (the how)
#### **Calling methods in Sub-Classes**
StandardMessages.cs PersonDataCapture.cs PersonValidator.cs AccountGenerator.cs

#### **Splitting responsibilities**
Fewer responsibiliites in 1 class -> fewer opportunities to introduce bugs during changes.