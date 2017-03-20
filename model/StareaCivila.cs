// Decompiled with JetBrains decompiler
// Type: Evidenta_Membrilor.StareaCivila
// Assembly: Evidenta Membrilor, Version=2.0.6229.22937, Culture=neutral, PublicKeyToken=null
// MVID: 60AE883C-445C-4F93-ADAD-DEA6593052EE
// Assembly location: C:\Users\liacob\Dropbox\Betel\Evidenta membrilor\Evidenta Membrilor.exe

namespace Evidenta_Membrilor
{
  public class StareaCivila
  {
    private string dataNasterii;
    private string loculNasterii;
    private string cnp;
    private string tata;
    private string mama;
    private string situatia;
    private string situatiaExpl;
    private string modif;
    private string modifExpl;

    public string DataNasterii
    {
      get
      {
        return this.dataNasterii;
      }
      set
      {
        this.dataNasterii = value;
      }
    }

    public string LoculNasterii
    {
      get
      {
        return this.loculNasterii;
      }
      set
      {
        this.loculNasterii = value;
      }
    }

    public string Cnp
    {
      get
      {
        return this.cnp;
      }
      set
      {
        this.cnp = value;
      }
    }

    public string Tata
    {
      get
      {
        return this.tata;
      }
      set
      {
        this.tata = value;
      }
    }

    public string Mama
    {
      get
      {
        return this.mama;
      }
      set
      {
        this.mama = value;
      }
    }

    public string Situatia
    {
      get
      {
        return this.situatia;
      }
      set
      {
        this.situatia = value;
      }
    }

    public string SituatiaExpl
    {
      get
      {
        return this.situatiaExpl;
      }
      set
      {
        this.situatiaExpl = value;
      }
    }

    public string Modif
    {
      get
      {
        return this.modif;
      }
      set
      {
        this.modif = value;
      }
    }

    public string ModifExpl
    {
      get
      {
        return this.modifExpl;
      }
      set
      {
        this.modifExpl = value;
      }
    }

    public StareaCivila(string data, string locul, string cnp, string tata, string mama, string situatia, string sitExpl, string modif, string modifExpl)
    {
      this.dataNasterii = data;
      this.loculNasterii = locul;
      this.cnp = cnp;
      this.tata = tata;
      this.mama = mama;
      this.situatia = situatia;
      this.situatiaExpl = sitExpl;
      this.modif = modif;
      this.modifExpl = modifExpl;
    }
  }
}
