namespace EjercicioTecnicoFDV.Interfaces
{
    public interface IRental
    {
        void SetRentedPeriod(int rentedTime);

        decimal CalculateRent();
    }
}
