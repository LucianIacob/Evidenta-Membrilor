namespace Evidenta_Membrilor
{
    public class PrimireMembru
    {
        private string modalitatea;
        private string data;
        private string expl;

        public string Modalitatea
        {
            get
            {
                return this.modalitatea;
            }
            set
            {
                this.modalitatea = value;
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

        public PrimireMembru(string mod, string data, string expl)
        {
            this.modalitatea = mod;
            this.data = data;
            this.expl = expl;
        }
    }
}
