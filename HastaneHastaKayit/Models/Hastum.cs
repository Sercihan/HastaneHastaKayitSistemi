using System;
using System.Collections.Generic;

namespace HastaneHastaKayit.Models;

public partial class Hastum
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public long Tc { get; set; }

    public string Teshis { get; set; } = null!;

    public int TedaviSuresi { get; set; }
}
