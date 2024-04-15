using System;
using System.Collections.Generic;

namespace HastaneHastaKayit.Models;

public partial class Doktor
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string DoktorKimligi { get; set; } = null!;

    public long Tc { get; set; }

    public string Email { get; set; } = null!;

    public string Sifre { get; set; } = null!;
}
