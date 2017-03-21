namespace Evidenta_Membrilor
{
    public class ActCult
    {
        private string act;
        private string data;
        private string biserica;
        private string pastor;

        public string Act
        {
            get
            {
                return this.act;
            }
            set
            {
                this.act = value;
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

        public string Biserica
        {
            get
            {
                return this.biserica;
            }
            set
            {
                this.biserica = value;
            }
        }

        public string Pastor
        {
            get
            {
                return this.pastor;
            }
            set
            {
                this.pastor = value;
            }
        }

        public ActCult(string act, string data, string biserica, string pastor)
        {
            this.act = act;
            this.data = data;
            this.biserica = biserica;
            this.pastor = pastor;
        }
    }
}
