// Decompiled with JetBrains decompiler
// Type: Evidenta_Membrilor.DisplayedMember
// Assembly: Evidenta Membrilor, Version=2.0.6229.22937, Culture=neutral, PublicKeyToken=null
// MVID: 60AE883C-445C-4F93-ADAD-DEA6593052EE
// Assembly location: C:\Users\liacob\Dropbox\Betel\Evidenta membrilor\Evidenta Membrilor.exe

namespace Evidenta_Membrilor
{
  public class DisplayedMember
  {
    private string nume;
    private string prenume;
    private int nrFisa;

    public int NrFisa
    {
      get
      {
        return this.nrFisa;
      }
      set
      {
        this.nrFisa = value;
      }
    }

    public string Prenume
    {
      get
      {
        return this.prenume;
      }
      set
      {
        this.prenume = value;
      }
    }

    public string Nume
    {
      get
      {
        return this.nume;
      }
      set
      {
        this.nume = value;
      }
    }

    public DisplayedMember(string nume, string prenume, int nrFisa)
    {
      this.Nume = nume;
      this.Prenume = prenume;
      this.NrFisa = nrFisa;
    }
  }
}
