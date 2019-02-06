namespace EjercicioTecnicoFDV.Test
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using Model;

    [TestFixture]
    public class BikesRentTest
    {
        private const decimal FamilyRentDiscount = 0.7m;
        private const int ByHour = 5;
        private const int ByDay = 20;
        private const int ByWeek = 60;

        [Test]
        public void RentByHourForFiveHours()
        {
            var hourRent = new HourRent();
            hourRent.SetRentedPeriod(5);

            Assert.IsTrue(hourRent.CalculateRent() == 5 * ByHour);
        }

        [Test]
        public void RentByDayForFiveDays()
        {
            var dayRent = new DayRent();
            dayRent.SetRentedPeriod(5);

            Assert.IsTrue(dayRent.CalculateRent() == 5 * ByDay);
        }

        [Test]
        public void RentByWeekForFiveWeeks()
        {
            var weekRent = new WeekRent();
            weekRent.SetRentedPeriod(5);

            Assert.IsTrue(weekRent.CalculateRent() == 5 * ByWeek);
        }

        [Test]
        public void RentForFamilyRental()
        {
            var dayRent = GetDayRent(20, 5);
            var hourRent = GetHourRent(5, 5);
            var weekRent = GetWeekRent(60, 5);

            var familyRent = new FamilyRent();
            var rentals = new List<Rental> { dayRent, hourRent, weekRent };

            familyRent.AddRentals(rentals);

            var result = familyRent.CalculateRent();

            Assert.IsTrue(familyRent.Rentals.Count < 6);
            Assert.IsTrue(familyRent.Rentals.Count > 2);
            Assert.IsTrue(result == (20 * 5 + 5 * 5 + 60 * 5) * FamilyRentDiscount);
        }

        [Test]
        public void AddTwoRentals_ToFamilyRental_ShouldThrowAnException()
        {
            var dayRent = GetDayRent(20, 5);
            var hourRent = GetHourRent(5, 5);

            var familyRent = new FamilyRent();
            var rentals = new List<Rental> { dayRent, hourRent };

            Assert.Throws<FamilyRentException>(() => familyRent.AddRentals(rentals));
        }

        [Test]
        public void AddSixRentals_ToFamilyRental_ShouldThrowAnException()
        {
            var dayRent1 = GetDayRent(20, 5);
            var hourRent1 = GetHourRent(5, 5);
            var dayRent2 = GetDayRent(20, 5);
            var hourRent2 = GetHourRent(5, 5);
            var dayRent3 = GetDayRent(20, 5);
            var hourRent3 = GetHourRent(5, 5);

            var familyRent = new FamilyRent();
            var rentals = new List<Rental>
            {
                dayRent1,
                hourRent1,
                dayRent2,
                hourRent2,
                dayRent3,
                hourRent3
            };


            Assert.Throws<FamilyRentException>(() => familyRent.AddRentals(rentals));
        }

        [Test]
        public void AddZeroRentals_ToFamilyRental_ShouldThrowAnException()
        {
            var familyRent = new FamilyRent();
            var rentals = new List<Rental>();

            Assert.Throws<FamilyRentException>(() => familyRent.AddRentals(null));
            Assert.Throws<FamilyRentException>(() => familyRent.AddRentals(rentals));
        }

        private static DayRent GetDayRent(int rentalPrice, int rentedPeriod)
        {
            return new DayRent() { RentalPrice = rentalPrice, RentedPeriod = rentedPeriod };
        }

        private static HourRent GetHourRent(int rentalPrice, int rentedPeriod)
        {
            return new HourRent() { RentalPrice = rentalPrice, RentedPeriod = rentedPeriod };
        }

        private static WeekRent GetWeekRent(int rentalPrice, int rentedPeriod)
        {
            return new WeekRent() { RentalPrice = rentalPrice, RentedPeriod = rentedPeriod };
        }
    }
}
