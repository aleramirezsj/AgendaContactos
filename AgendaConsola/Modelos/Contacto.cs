﻿using System;
using System.Collections.Generic;

namespace AgendaConsola.Modelos;

public partial class Contacto
{
    public int Id { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long? Telefono { get; set; }

    public string? Direccion { get; set; }

    public bool? Favorito { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Apellido} {Nombre} {Email}" ;
    }
}
