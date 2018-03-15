# TheTutors
And your assignment this week is to write a program where tutors have a credit rate to help a student and students have to transfer credits to a tutor for their services.

Start by creating your classes in an People folder.

Students and tutors both have a first name and last name.

Tutors have a cost.  This value can be read or updated by any other class.
Tutors have earned credit from helping students.  This value can not be accessed by any class other than the Tutor class.
Create a method that pays a tutor by increasing their earned credit by their cost.  Display a message with the tutor's new credit balance.  Use the tutor's name in the message.

Students have a starting amount of credit (100).  In the student constructor, read a configuration value using the System.Configuration assembly like the example in class.
    The value stored should not be able to be accessed by any other class.
    If you get stuck, just hard code the starting value instead of making it configurable.
A student can earn credit, so create a method that adds credit to a student.
A student can pay a tutor, so create a method that pays a tutor.
    If the student does not have enough credit to cover the cost of tutor, display a message.  Use the students name in the message.
    If the student does have enough credit, reduce the students current credits based on the tutor cost, pay the tutor and display a success message.  Use the tutors name in the message.
    Always display a message after the transaction that shows how many credits the student has left.
    
Now update your Program Main class with the following flow.

    Create a new student.
    Create a new tutor that costs 50 credits.
    Create a new tutor that costs 75 credits.
    Have the student pay tutor 1, this should produce a success message.
    Have the student pay tutor 2, this should produce a failure message.
    Give the student 100 more credits.
    Have the student pay tutor 2, this should produce a success message.
