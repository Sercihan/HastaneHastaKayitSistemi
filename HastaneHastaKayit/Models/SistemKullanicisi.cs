using System;
using System.Collections.Generic;

namespace HastaneHastaKayit.Models;

public partial class SistemKullanicisi
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Sifre { get; set; } = null!;
}
