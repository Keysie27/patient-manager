﻿namespace SGP.Core.Domain.Entities
{
    public class Cita
    {
        public int IdCita { get; set; }
        public string? Estado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Causa { get; set; }

        //ForeignKeys:
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }

        //Navigation propertys:
        public Paciente? Paciente { get; set; }
        public Medico? Medico { get; set; }
    }
}
