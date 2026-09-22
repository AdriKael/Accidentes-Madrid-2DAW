namespace Accidentes_Madrid.Models;

public sealed record Accidente(
    string NumExpediente,
    DateTime Fecha, 
    TimeSpan SemaphoreAcl,
    string Localizacion,
    int Numero,
    int CodDistrito,
    string Distrito,
    TipoAccidente TipoAccidente,
    string EstadoMeteorologico,
    string TipoVehiculo,
    TipoPersona TipoPersona,
    string RangoEdad,
    Sexo Sexo,
    string CodLesividad,
    Gravedad Gravedad,
    string? CoordenadaXUtm,
    string? CoordenadaYUtm,
    bool PositivoAlcohol,
    bool PositivoDroga
    );