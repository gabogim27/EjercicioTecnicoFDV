using System;

namespace EjercicioTecnicoFDV
{
    public class FamilyRentException : Exception
    {
        public FamilyRentException()
        {
        }

        public FamilyRentException(string message)
            : base(message)
        { }

        public FamilyRentException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
