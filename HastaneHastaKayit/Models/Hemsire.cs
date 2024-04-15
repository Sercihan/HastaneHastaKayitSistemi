using System;
using System.Collections.Generic;

namespace HastaneHastaKayit.Models;

public partial class Hemsire
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public long Tc { get; set; }
}
