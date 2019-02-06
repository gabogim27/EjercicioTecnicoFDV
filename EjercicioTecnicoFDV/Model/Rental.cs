namespace EjercicioTecnicoFDV.Model
{
    using Interfaces;

    public abstract class Rental : IRental
    {
        public decimal RentalPrice { get; set; }

        public int RentedPeriod { get; set; }

        public virtual void SetRentedPeriod(int rentedPeriod)
        {
            RentedPeriod = rentedPeriod;
        }

        public virtual decimal CalculateRent()
        {
            return RentalPrice;
        }
    }
}
