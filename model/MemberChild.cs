// Decompiled with JetBrains decompiler
// Type: Evidenta_Membrilor.MemberChild
// Assembly: Evidenta Membrilor, Version=2.0.6229.22937, Culture=neutral, PublicKeyToken=null
// MVID: 60AE883C-445C-4F93-ADAD-DEA6593052EE
// Assembly location: C:\Users\liacob\Dropbox\Betel\Evidenta membrilor\Evidenta Membrilor.exe

namespace Evidenta_Membrilor
{
  public class MemberChild
  {
    private int copil_nr;
    private string nume;
    private string data_nasterii;
    private string data_binec;
    private string data_botez;
    private string stare_civila;
    private string nr_fisa;

    public int Copil_nr
    {
      get
      {
        return this.copil_nr;
      }
      set
      {
        this.copil_nr = value;
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

    public string Data_nasterii
    {
      get
      {
        return this.data_nasterii;
      }
      set
      {
        this.data_nasterii = value;
      }
    }

    public string Data_binec
    {
      get
      {
        return this.data_binec;
      }
      set
      {
        this.data_binec = value;
      }
    }

    public string Data_botez
    {
      get
      {
        return this.data_botez;
      }
      set
      {
        this.data_botez = value;
      }
    }

    public string Stare_civila
    {
      get
      {
        return this.stare_civila;
      }
      set
      {
        this.stare_civila = value;
      }
    }

    public string Nr_fisa
    {
      get
      {
        return this.nr_fisa;
      }
      set
      {
        this.nr_fisa = value;
      }
    }

    public MemberChild(int nr, string nume, string datan, string datab, string databo, string stare, string fisa)
    {
      this.copil_nr = nr;
      this.nume = nume;
      this.data_nasterii = datan;
      this.data_binec = datab;
      this.data_botez = databo;
      this.stare_civila = stare;
      this.nr_fisa = fisa;
    }
  }
}
