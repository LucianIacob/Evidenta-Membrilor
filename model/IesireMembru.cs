// Decompiled with JetBrains decompiler
// Type: Evidenta_Membrilor.IesireMembru
// Assembly: Evidenta Membrilor, Version=2.0.6229.22937, Culture=neutral, PublicKeyToken=null
// MVID: 60AE883C-445C-4F93-ADAD-DEA6593052EE
// Assembly location: C:\Users\liacob\Dropbox\Betel\Evidenta membrilor\Evidenta Membrilor.exe

namespace Evidenta_Membrilor
{
  public class IesireMembru
  {
    private string motiv;
    private string data;
    private string expl;

    public string Motiv
    {
      get
      {
        return this.motiv;
      }
      set
      {
        this.motiv = value;
      }
    }

    public string Data
    {
      get
      {
        return this.data;
      }
      set
      {
        this.data = value;
      }
    }

    public string Expl
    {
      get
      {
        return this.expl;
      }
      set
      {
        this.expl = value;
      }
    }

    public IesireMembru(string m, string d, string e)
    {
      this.Motiv = m;
      this.Data = d;
      this.Expl = e;
    }
  }
}
