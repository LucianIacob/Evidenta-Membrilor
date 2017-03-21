namespace Evidenta_Membrilor
{
    public class PersonalData
    {
        private string dataInscrierii;
        private string nume;
        private string prenume;
        private string localitate;
        private string strada;
        private string numarul;
        private string judet;
        private string telefon;
        private string studii;
        private string calitatea;

        public string DataInscrierii
        {
            get
            {
                return this.dataInscrierii;
            }
            set
            {
                this.dataInscrierii = value;
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

        public string Localitate
        {
            get
            {
                return this.localitate;
            }
            set
            {
                this.localitate = value;
            }
        }

        public string Strada
        {
            get
            {
                return this.strada;
            }
            set
            {
                this.strada = value;
            }
        }

        public string Numarul
        {
            get
            {
                return this.numarul;
            }
            set
            {
                this.numarul = value;
            }
        }

        public string Judet
        {
            get
            {
                return this.judet;
            }
            set
            {
                this.judet = value;
            }
        }

        public string Telefon
        {
            get
            {
                return this.telefon;
            }
            set
            {
                this.telefon = value;
            }
        }

        public string Studii
        {
            get
            {
                return this.studii;
            }
            set
            {
                this.studii = value;
            }
        }

        public string Calitatea
        {
            get
            {
                return this.calitatea;
            }
            set
            {
                this.calitatea = value;
            }
        }

        public PersonalData(string data, string nume, string prenume, string loc, string str, string numar, string judet, string tel, string studii, string calitate)
        {
            this.dataInscrierii = data;
            this.nume = nume;
            this.prenume = prenume;
            this.localitate = loc;
            this.strada = str;
            this.numarul = numar;
            this.judet = judet;
            this.telefon = tel;
            this.studii = studii;
            this.calitatea = calitate;
        }
    }
}
