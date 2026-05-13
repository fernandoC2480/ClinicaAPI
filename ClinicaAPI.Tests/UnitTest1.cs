using ClinicaAPI.Models;
using Xunit;

namespace ClinicaAPI.Tests
{
    public class PacienteTest
    {
        [Fact]
        public void ValidarAsignacionNombre()
        {
            // Arrange (Preparar)
            var paciente = new Paciente();
            var nombreEsperado = "Carlos Perez";

            // Act (Ejecutar)
            paciente.Nombre = "Carlos Perez";

            // Assert (Verificar)
            Assert.Equal(nombreEsperado, paciente.Nombre);
        }

        [Fact]
        public void ValidarEdadPacienteNoNegativa()
        {
            // Arrange
            var paciente = new Paciente();
            paciente.Edad = 25;

            // Assert
            Assert.True(paciente.Edad > 0, "La edad del paciente debe ser mayor a cero");
        }
    }
}