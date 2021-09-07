using System;
using cinema_functions;
using NUnit.Framework;

namespace cinema_functions.test
{

    [TestFixture]

    public class TicketPriceControllerTests
    {
        // Test cases used to pass arguments into test methods.
       
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

            TicketPriceController TicketPrice = new TicketPriceController();

            // Act 

            decimal price = TicketPrice.Adult_Before_5(pr_quantity, pr_person, pr_day, pr_time);

            // Assert

            Assert.That(price == result);
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
    }
}
