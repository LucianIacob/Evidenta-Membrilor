namespace Evidenta_Membrilor
{
    public class PartenerMembru
    {
        private string nume;
        private string nrFisa;
        private string dataN;
        private string loc;
        private string rel;

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

        public string NrFisa
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

        public string DataN
        {
            get
            {
                return this.dataN;
            }
            set
            {
                this.dataN = value;
            }
        }

        public string Loc
        {
            get
            {
                return this.loc;
            }
            set
            {
                this.loc = value;
            }
        }

        public string Rel
        {
            get
            {
                return this.rel;
            }
            set
            {
                this.rel = value;
            }
        }

        public PartenerMembru(string nume, string nrFisa, string dataN, string loc, string rel)
        {
            this.nume = nume;
            this.nrFisa = nrFisa;
            this.dataN = dataN;
            this.loc = loc;
            this.rel = rel;
        }
    }
}
