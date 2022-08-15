# DoctorsProgram
This program is made in order to help our doctors.
Each doctor can sign in to this program and take care of the patients.
In this program the doctor can enter the ID of the patient and enter the patient details, also the doctor can import the
blood test results of the patient and according to them and the others patient detailsthe software can diagnose the patient 
and give him medical treatment.
According the patient details the program gives the doctor a few possible diagnosis and a few possible medical treatments.
All the details of the doctors(username and password), and the patients are saved in Excel files-we used the IRON-XL package
in order to import the patient blood test result, it should exist in the excel file. otherwise it shows nothing and the program 
won't be able to diagnosis the patient and give a possible medical treatment.
About the files:
	1. Diag.xlsx - Shows each disease and its treatment
	2. DoctorsDetailes.xlsx - Saves the doctors Username and password after he signed in, only users that in this file are able to get into the program
	3. Excel.cs - The Excel class we created, contains the constructor and functions that are realated to xlsx files
	4. PatientDetailes.xlsx - Contains the patients details, if the patient ID already exists in the file it will show all the patient details that was already saved, 
														if not it will the the patient details for the first time after the doctor will click on the save button. The patient blood test result 
														had to be entered manually to this excel file, in order to be able to show them in the program itself. 
	5. Form1.cs - The first window in the program where the doctor login the program if he has a user, if not it he had to register.
	6. Form2.cs - The registration window. After the registration the doctors username and password is saved in the DoctorsDetailes.xlsx file and from now on the doctor can login to the program
	7. Form3.cs - The window where the doctor enter the patient ID and get to see the patient details, and change them if neaded, also in this window the doctor can import the 
								patients blood test result and get the help of the program that can give possible diagnosis and a possible medical treatments.
	#The programs language is hebrew.							
														
