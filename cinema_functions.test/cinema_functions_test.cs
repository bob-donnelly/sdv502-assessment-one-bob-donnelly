// Importing required files i.e., NUnit to create unit tests.
// Importing cinema_functions.cs file to call classes and methods.

using System;
using cinema_functions;
using NUnit.Framework;

namespace cinema_functions.test
{
    // Test fixture is called before the main class to group all relevant unit test cases into an easy to run wrapper.

    [TestFixture]

    public class TicketPriceControllerTests
    {
        // Test cases used to pass arguments into test methods to generate accurate tests.
        // Test cases are broken down into methods then into each separate test case.
       
        [TestCase(1, "adult", "Monday", 3, 14.50)]
        [TestCase(5, "adult", "Wednesday", 4, 72.5)]
        [TestCase(1, "adult", "Tuesday", 2, -1)]
        [TestCase(0, "adult", "Friday", 4, -1)]
        [TestCase(-1, "adult", "Sunday", 1, -1)]
        [TestCase(1, "senior", "Sunday", 4, -1)]
        [TestCase(1, "child", "Sunday", 2, -1)]
        [TestCase(1, "student", "Sunday", 2, -1)]

        public void Adult_Before_5_Expect_14_50_Per_Person(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal result)
        {
            // Arrange 
            // Taking the TicketPriceController class from cinema_functions and making a variable assigning
            // a copy of TicketPriceController to access the method to test via the class with dot notation.

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act 
            // Action that is taken is that the price is calculated from the arguments passed into the method called from cinema_functions.cs file.

            decimal ticketPrice = TicketPrice.Adult_Before_5(pr_quantity, pr_person, pr_day, pr_time);

            // Assert
            // Asserting the price is equal to the result or the expected result we have filled out using That method comparing truthy values.

            Assert.That(ticketPrice == result);
        }

        [TestCase(1, "adult", "Monday", 7, 17.50)]
        [TestCase(3, "adult", "Wednesday", 6, 52.5)]
        [TestCase(1, "adult", "Tuesday", 6, -1)]
        [TestCase(0, "adult", "Thursday", 7, -1)]
        [TestCase(-1, "adult", "Sunday", 7, -1)]
        [TestCase(1, "senior", "Sunday", 4, -1)]
        [TestCase(1, "child", "Sunday", 2, -1)]
        [TestCase(1, "student", "Sunday", 2, -1)]

        public void Adult_After_5_Expect_17_50_Per_Person(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal result)
        {
            // Arrange

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act

            decimal ticketPrice = TicketPrice.Adult_After_5(pr_quantity, pr_person, pr_day, pr_time);

            // Assert 

            Assert.That(ticketPrice == result);
        }

        [TestCase(1, "adult", "Tuesday", 13)]
        [TestCase(2, "adult", "Tuesday", 26)]
        [TestCase(1, "adult", "Wednesday", -1)]
        [TestCase(0, "adult", "Tuesday", -1)]
        [TestCase(-1, "adult", "Tuesday", -1)]
        [TestCase(1, "Senior", "Tuesday", -1)]
        [TestCase(0, "Child", "Tuesday", -1)]
        [TestCase(-1, "Student", "Tuesday", -1)]

        public void Adult_Tuesday_Expect_13_Per_Person(int pr_quantity, string pr_person, string pr_day, decimal result)
        {
            // Arrange

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act

            decimal ticketPrice = TicketPrice.Adult_Tuesday(pr_quantity, pr_person, pr_day);

            // Assert

            Assert.That(ticketPrice == result);
        }

        [TestCase(1, "child", 12)]
        [TestCase(3, "Child", 36)]
        [TestCase(0, "child", -1)]
        [TestCase(-1, "child", -1)]
        [TestCase(1, "Adult", -1)]
        [TestCase(1, "Student", -1)]
        [TestCase(1, "Senior", -1)]

        public void Child_Under_16_Expect_12_Per_Person(int pr_quantity, string pr_person, decimal result)
        {
            //Arrange

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act

            decimal ticketPrice = TicketPrice.Child_Under_16(pr_quantity, pr_person);

            // Assert

            Assert.That(ticketPrice == result);
        }

        [TestCase(1, "Senior", 12.50)]
        [TestCase(2, "Senior", 25)]
        [TestCase(0, "Senior", -1)]
        [TestCase(-1, "Senior", -1)]
        [TestCase(1, "Adult", -1)]
        [TestCase(1, "Student", -1)]
        [TestCase(1, "Child", -1)]
        public void Senior_Expect_12_50_Per_Person(int pr_quantity, string pr_person, decimal result)
        {
            //Arrange

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act

            decimal ticketPrice = TicketPrice.Senior(pr_quantity, pr_person);

            // Assert

            Assert.That(ticketPrice == result);
        }

        [TestCase(1, "Student", 14)]
        [TestCase(4, "Student", 56)]
        [TestCase(0, "Student", -1)]
        [TestCase(-1, "Student", -1)]
        [TestCase(1, "Adult", -1)]
        [TestCase(1, "Child", -1)]
        [TestCase(1, "Senior", -1)]

        public void Student_Expect_14_Per_Person(int pr_quantity, string pr_person, decimal result)
        {
            //Arrange

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act

            decimal ticketPrice = TicketPrice.Student(pr_quantity, pr_person);

            // Assert

            Assert.That(ticketPrice == result);
        }

        [TestCase(1, 2, 2, 46)]
        [TestCase(1, 1, 3, 46)]
        [TestCase(4, 2, 2, 184)]
        [TestCase(2, 1, 3, 92)]
        [TestCase(2, 3, 5, 92)]
        [TestCase(0, 2, 2, -1)]
        [TestCase(-1, 1, 3, -1)]
        [TestCase(2, 2, 6, -1)]
        [TestCase(1, "adult", "senior", -1)]

        public void Family_Pass_Expect_46_All_Persons(int pr_quantity_ticket, int pr_quantity_adult, int pr_quantity_child, decimal result)
        {
            //Arrange

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act

            decimal ticketPrice = TicketPrice.Family_Pass(pr_quantity_ticket, pr_quantity_adult, pr_quantity_child);

            // Assert

            Assert.That(ticketPrice == result);
        }
    }
}
