using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace Evidenta_Membrilor
{
    public class TablesManager
    {
        private SQLiteConnection conn;

        public void createDataBaseFile()
        {
            if (File.Exists("evidenta_membrilor_db.sqlite"))
                return;
            SQLiteConnection.CreateFile("evidenta_membrilor_db.sqlite");
            Console.WriteLine("----Log: Created SQLite File");
        }

        public void createTables()
        {
            string commandText1 = "create table if not exists date_personale (id int primary key, nume varchar(50), prenume varchar(50), localitate varchar(50), strada varchar(60), numar varchar(10), judet varchar(30), telefon varchar(15), studii varchar(40), calitatea varchar(30), data_inscrierii varchar(10))";
            string commandText2 = "create table if not exists stare_civila (id int primary key, data_nasterii varchar(10), loc_nastere varchar(50), cnp varchar(14), tata varchar(30), mama varchar(30), situatia varchar(30), sit_expl varchar(100), modificari varchar(30), modif_expl varchar(100))";
            string commandText3 = "create table if not exists primire_membru (id int primary key, modalitate varchar(30), data varchar(10), explicatii varchar(100))";
            string commandText4 = "create table if not exists acte_cult (id int, act varchar(30), data varchar(10), biserica varchar(50), pastor varchar(50), primary key (id, act))";
            string commandText5 = "create table if not exists familia_partener (id int primary key, nume varchar(40), nr_fisa varchar(10), data_nasterii varchar(10), localitate varchar(40), religie varchar(30))";
            string commandText6 = "create table if not exists familia_copii (id int, copil_nr int, nume varchar(60), data_nasterii varchar(10), data_binec varchar(10), data_botez varchar(10), stare_civila varchar(20), nr_fisa varchar(10), primary key (id, copil_nr))";
            string commandText7 = "create table if not exists iesire_evidenta (id int primary key, motiv varchar(30), data varchar(10), explicatii varchar(100))";
            this.conn = new SQLiteConnection("Data Source=evidenta_membrilor_db.sqlite;");
            this.conn.Open();
            SQLiteConnection conn = this.conn;
            new SQLiteCommand(commandText1, conn).ExecuteNonQuery();
            Console.WriteLine("----Log: Table Date Personale created");
            new SQLiteCommand(commandText2, this.conn).ExecuteNonQuery();
            Console.WriteLine("----Log: Table Stare Civila created");
            new SQLiteCommand(commandText3, this.conn).ExecuteNonQuery();
            Console.WriteLine("----Log: Table Primire Membru created");
            new SQLiteCommand(commandText4, this.conn).ExecuteNonQuery();
            Console.WriteLine("----Log: Table Acte Cult created");
            new SQLiteCommand(commandText5, this.conn).ExecuteNonQuery();
            Console.WriteLine("----Log: Table Familia Partener created");
            new SQLiteCommand(commandText6, this.conn).ExecuteNonQuery();
            Console.WriteLine("----Log: Table Familia Copii created");
            new SQLiteCommand(commandText7, this.conn).ExecuteNonQuery();
            Console.WriteLine("----Log: Table Iesire Evidenta created");
        }

        public int getChildrenCount()
        {
            return Convert.ToInt32(new SQLiteCommand("SELECT count(*) FROM familia_copii", this.conn).ExecuteScalar());
        }

        public int getMembersCount()
        {
            return Convert.ToInt32(new SQLiteCommand("SELECT count(*) FROM date_personale", this.conn).ExecuteScalar());
        }

        public bool idAlreadyInDataBase(int id)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT id FROM date_personale WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Find id returned " + (object)sqLiteDataReader.StepCount + " rows.");
            return sqLiteDataReader.StepCount != 0;
        }

        public string insertDatePersonale(int id, string nume, string prenume, string localitatea, string strada, string numarul, string judet, string telefon, string studii, string calitatea, string data_inscrierii)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("insert into date_personale (id, nume, prenume, localitate, strada, numar, judet, telefon, studii, calitatea, data_inscrierii) values (@idParam,@numeParam,@prenumeParam,@locParam,@strParam,@nrParam,@judParam,@telParam,@studiiParam,@calitateaParam,@dataInscrieriiParam)", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@numeParam", (object)nume);
            sqLiteCommand.Parameters.AddWithValue("@prenumeParam", (object)prenume);
            sqLiteCommand.Parameters.AddWithValue("@locParam", (object)localitatea);
            sqLiteCommand.Parameters.AddWithValue("@strParam", (object)strada);
            sqLiteCommand.Parameters.AddWithValue("@nrParam", (object)numarul);
            sqLiteCommand.Parameters.AddWithValue("@judParam", (object)judet);
            sqLiteCommand.Parameters.AddWithValue("@telParam", (object)telefon);
            sqLiteCommand.Parameters.AddWithValue("@studiiParam", (object)studii);
            sqLiteCommand.Parameters.AddWithValue("@calitateaParam", (object)calitatea);
            sqLiteCommand.Parameters.AddWithValue("@dataInscrieriiParam", (object)data_inscrierii);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert date personale " + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string insertStareaCivila(int id, string dataNasterii, string loculNasterii, string cnp, string tata, string mama, string situatia, string situatia_expl, string modificari, string modificari_expl)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("insert into stare_civila (id, data_nasterii, loc_nastere, cnp, tata, mama, situatia, sit_expl, modificari, modif_expl) values (@idParam,@dataParam,@locParam,@cnpParam,@tataParam,@mamaParam,@situatiaParam,@sitExplParam,@modifParam,@modifExplParam)", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)dataNasterii);
            sqLiteCommand.Parameters.AddWithValue("@locParam", (object)loculNasterii);
            sqLiteCommand.Parameters.AddWithValue("@cnpParam", (object)cnp);
            sqLiteCommand.Parameters.AddWithValue("@tataParam", (object)tata);
            sqLiteCommand.Parameters.AddWithValue("@mamaParam", (object)mama);
            sqLiteCommand.Parameters.AddWithValue("@situatiaParam", (object)situatia);
            sqLiteCommand.Parameters.AddWithValue("@sitExplParam", (object)situatia_expl);
            sqLiteCommand.Parameters.AddWithValue("@modifParam", (object)modificari);
            sqLiteCommand.Parameters.AddWithValue("@modifExplParam", (object)modificari_expl);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert stare civila" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string insertPrimireMembru(int id, string modalitatea, string data, string explicatii)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("insert into primire_membru (id, modalitate, data, explicatii) values (@idParam,@modParam,@dataParam,@explParam)", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@modParam", (object)modalitatea);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)data);
            sqLiteCommand.Parameters.AddWithValue("@explParam", (object)explicatii);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert primire membru" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string insertActCult(int id, string act, string data, string biserica, string pastor)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("insert into acte_cult (id, act, data, biserica, pastor) values (@idParam,@actParam,@dataParam,@bisParam,@pastorParam)", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@actParam", (object)act);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)data);
            sqLiteCommand.Parameters.AddWithValue("@bisParam", (object)biserica);
            sqLiteCommand.Parameters.AddWithValue("@pastorParam", (object)pastor);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert acte cult" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string insertPartener(int id, string nume, string nrFisa, string dataNasterii, string loc, string religie)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("insert into familia_partener (id, nume, nr_fisa, data_nasterii, localitate, religie) values (@idParam,@numeParam,@nrFisaParam,@dataParam,@locParam,@relParam)", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@numeParam", (object)nume);
            sqLiteCommand.Parameters.AddWithValue("@nrFisaParam", (object)nrFisa);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)dataNasterii);
            sqLiteCommand.Parameters.AddWithValue("@locParam", (object)loc);
            sqLiteCommand.Parameters.AddWithValue("@relParam", (object)religie);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert partener" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string insertCopil(int id, int nrCopil, string nume, string dataN, string dataBi, string dataBo, string stare, string nrFIsa)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("insert into familia_copii (id, copil_nr, nume, data_nasterii, data_binec, data_botez, stare_civila, nr_fisa) values (@idParam,@nrParam,@numeParam,@nasParam,@binParam,@botParam,@stareParam,@nrFisaParam)", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@nrParam", (object)nrCopil);
            sqLiteCommand.Parameters.AddWithValue("@numeParam", (object)nume);
            sqLiteCommand.Parameters.AddWithValue("@nasParam", (object)dataN);
            sqLiteCommand.Parameters.AddWithValue("@binParam", (object)dataBi);
            sqLiteCommand.Parameters.AddWithValue("@botParam", (object)dataBo);
            sqLiteCommand.Parameters.AddWithValue("@stareParam", (object)stare);
            sqLiteCommand.Parameters.AddWithValue("@nrFisaParam", (object)nrFIsa);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert copii" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string insertIesireEvidenta(int id, string motiv, string data, string expl)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("insert into iesire_evidenta (id, motiv, data, explicatii) values (@idParam,@motivParam,@dataParam,@explParam)", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@motivParam", (object)motiv);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)data);
            sqLiteCommand.Parameters.AddWithValue("@explParam", (object)expl);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert iesire evidenta" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public List<DisplayedMember> getAllMembers(string query)
        {
            List<DisplayedMember> displayedMemberList = new List<DisplayedMember>();
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT id, nume, prenume, data_inscrierii FROM date_personale WHERE nume LIKE @query OR prenume LIKE @query OR id LIKE @query ORDER BY nume, prenume", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@query", (object)("%" + query + "%"));
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select all members returned " + (object)sqLiteDataReader.StepCount + " rows");
            while (sqLiteDataReader.Read())
                displayedMemberList.Add(new DisplayedMember(sqLiteDataReader["nume"].ToString(), sqLiteDataReader["prenume"].ToString(), int.Parse(sqLiteDataReader["id"].ToString())));
            sqLiteDataReader.Close();
            return displayedMemberList;
        }

        public PersonalData getMemberPersonalData(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT * FROM date_personale WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select personal data returned " + (object)sqLiteDataReader.StepCount + " rows.");
            sqLiteDataReader.Read();
            PersonalData personalData = new PersonalData(sqLiteDataReader["data_inscrierii"].ToString(), sqLiteDataReader["nume"].ToString(), sqLiteDataReader["prenume"].ToString(), sqLiteDataReader["localitate"].ToString(), sqLiteDataReader["strada"].ToString(), sqLiteDataReader["numar"].ToString(), sqLiteDataReader["judet"].ToString(), sqLiteDataReader["telefon"].ToString(), sqLiteDataReader["studii"].ToString(), sqLiteDataReader["calitatea"].ToString());
            sqLiteDataReader.Close();
            return personalData;
        }

        public StareaCivila getMemberStareCivila(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT * FROM stare_civila WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select stare civila returned " + (object)sqLiteDataReader.StepCount + " rows.");
            sqLiteDataReader.Read();
            StareaCivila stareaCivila = new StareaCivila(sqLiteDataReader["data_nasterii"].ToString(), sqLiteDataReader["loc_nastere"].ToString(), sqLiteDataReader["cnp"].ToString(), sqLiteDataReader["tata"].ToString(), sqLiteDataReader["mama"].ToString(), sqLiteDataReader["situatia"].ToString(), sqLiteDataReader["sit_expl"].ToString(), sqLiteDataReader["modificari"].ToString(), sqLiteDataReader["modif_expl"].ToString());
            sqLiteDataReader.Close();
            return stareaCivila;
        }

        public PrimireMembru getMemberPrimireInfo(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT * FROM primire_membru WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select primire membru returned " + (object)sqLiteDataReader.StepCount + " rows.");
            sqLiteDataReader.Read();
            PrimireMembru primireMembru = new PrimireMembru(sqLiteDataReader["modalitate"].ToString(), sqLiteDataReader["data"].ToString(), sqLiteDataReader["explicatii"].ToString());
            sqLiteDataReader.Close();
            return primireMembru;
        }

        public List<ActCult> getMemberActeCult(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT * FROM acte_cult WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select acte cult returned " + (object)sqLiteDataReader.StepCount + " rows.");
            List<ActCult> actCultList = new List<ActCult>();
            while (sqLiteDataReader.Read())
                actCultList.Add(new ActCult(sqLiteDataReader["act"].ToString(), sqLiteDataReader["data"].ToString(), sqLiteDataReader["biserica"].ToString(), sqLiteDataReader["pastor"].ToString()));
            sqLiteDataReader.Close();
            return actCultList;
        }

        public PartenerMembru getMemberPartener(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT * FROM familia_partener WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select sotia returned " + (object)sqLiteDataReader.StepCount + " rows.");
            sqLiteDataReader.Read();
            PartenerMembru partenerMembru = new PartenerMembru(sqLiteDataReader["nume"].ToString(), sqLiteDataReader["nr_fisa"].ToString(), sqLiteDataReader["data_nasterii"].ToString(), sqLiteDataReader["localitate"].ToString(), sqLiteDataReader["religie"].ToString());
            sqLiteDataReader.Close();
            return partenerMembru;
        }

        public List<MemberChild> getMemberChildren(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT * FROM familia_copii WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select childs returned " + (object)sqLiteDataReader.StepCount + " rows.");
            List<MemberChild> memberChildList = new List<MemberChild>();
            while (sqLiteDataReader.Read())
                memberChildList.Add(new MemberChild(int.Parse(sqLiteDataReader["copil_nr"].ToString()), sqLiteDataReader["nume"].ToString(), sqLiteDataReader["data_nasterii"].ToString(), sqLiteDataReader["data_binec"].ToString(), sqLiteDataReader["data_botez"].ToString(), sqLiteDataReader["stare_civila"].ToString(), sqLiteDataReader["nr_fisa"].ToString()));
            sqLiteDataReader.Close();
            return memberChildList;
        }

        public IesireMembru getMemberIesireInfo(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("SELECT * FROM iesire_evidenta WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            Console.WriteLine("#############Select iesire membru returned " + (object)sqLiteDataReader.StepCount + " rows.");
            sqLiteDataReader.Read();
            IesireMembru iesireMembru = new IesireMembru(sqLiteDataReader["motiv"].ToString(), sqLiteDataReader["data"].ToString(), sqLiteDataReader["explicatii"].ToString());
            sqLiteDataReader.Close();
            return iesireMembru;
        }

        public void deleteIesireEvidentaInfo(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM iesire_evidenta WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            Console.WriteLine("#############Sters iesire membru " + (object)sqLiteCommand.ExecuteNonQuery() + " rows.");
        }

        public void deleteMemberChilds(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM familia_copii WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            Console.WriteLine("#############Sters copii membru " + (object)sqLiteCommand.ExecuteNonQuery() + " rows.");
        }

        public void deleteMemberPartner(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM familia_partener WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            Console.WriteLine("#############Sters partener membru " + (object)sqLiteCommand.ExecuteNonQuery() + " rows.");
        }

        public void deleteActeCult(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM acte_cult WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            Console.WriteLine("#############Sters acte cult " + (object)sqLiteCommand.ExecuteNonQuery() + " rows.");
        }

        public void deletePrimireInfo(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM primire_membru WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            Console.WriteLine("#############Sters primire membru info " + (object)sqLiteCommand.ExecuteNonQuery() + " rows.");
        }

        public void deleteStareCivila(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM stare_civila WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            Console.WriteLine("#############Sters stare civila " + (object)sqLiteCommand.ExecuteNonQuery() + " rows.");
        }

        public void deleteDatePersonale(int memberId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("DELETE FROM date_personale WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)memberId);
            Console.WriteLine("#############Sters date personale " + (object)sqLiteCommand.ExecuteNonQuery() + " rows.");
        }

        public string updateDatePersonale(int id, string nume, string prenume, string localitatea, string strada, string numarul, string judet, string telefon, string studii, string calitatea, string data_inscrierii)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("UPDATE date_personale SET nume=@numeParam, prenume=@prenumeParam, localitate=@locParam, strada=@strParam, numar=@nrParam, judet=@judParam, telefon=@telParam, studii=@studiiParam, calitatea=@calitateaParam, data_inscrierii=@dataInscrieriiParam WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@numeParam", (object)nume);
            sqLiteCommand.Parameters.AddWithValue("@prenumeParam", (object)prenume);
            sqLiteCommand.Parameters.AddWithValue("@locParam", (object)localitatea);
            sqLiteCommand.Parameters.AddWithValue("@strParam", (object)strada);
            sqLiteCommand.Parameters.AddWithValue("@nrParam", (object)numarul);
            sqLiteCommand.Parameters.AddWithValue("@judParam", (object)judet);
            sqLiteCommand.Parameters.AddWithValue("@telParam", (object)telefon);
            sqLiteCommand.Parameters.AddWithValue("@studiiParam", (object)studii);
            sqLiteCommand.Parameters.AddWithValue("@calitateaParam", (object)calitatea);
            sqLiteCommand.Parameters.AddWithValue("@dataInscrieriiParam", (object)data_inscrierii);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Update date personale " + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string updateStareaCivila(int id, string dataNasterii, string loculNasterii, string cnp, string tata, string mama, string situatia, string situatia_expl, string modificari, string modificari_expl)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("UPDATE stare_civila SET data_nasterii=@dataParam, loc_nastere=@locParam, cnp=@cnpParam, tata=@tataParam, mama=@mamaParam, situatia=@situatiaParam, sit_expl=@sitExplParam, modificari=@modifParam, modif_expl=@modifExplParam WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)dataNasterii);
            sqLiteCommand.Parameters.AddWithValue("@locParam", (object)loculNasterii);
            sqLiteCommand.Parameters.AddWithValue("@cnpParam", (object)cnp);
            sqLiteCommand.Parameters.AddWithValue("@tataParam", (object)tata);
            sqLiteCommand.Parameters.AddWithValue("@mamaParam", (object)mama);
            sqLiteCommand.Parameters.AddWithValue("@situatiaParam", (object)situatia);
            sqLiteCommand.Parameters.AddWithValue("@sitExplParam", (object)situatia_expl);
            sqLiteCommand.Parameters.AddWithValue("@modifParam", (object)modificari);
            sqLiteCommand.Parameters.AddWithValue("@modifExplParam", (object)modificari_expl);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert stare civila" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string updatePrimireMembru(int id, string modalitatea, string data, string explicatii)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("UPDATE primire_membru SET modalitate=@modParam, data=@dataParam, explicatii=@explParam WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@modParam", (object)modalitatea);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)data);
            sqLiteCommand.Parameters.AddWithValue("@explParam", (object)explicatii);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert primire membru" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string updatePartener(int id, string nume, string nrFisa, string dataNasterii, string loc, string religie)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("UPDATE familia_partener SET nume=@numeParam, nr_fisa=@nrFisaParam, data_nasterii=@dataParam, localitate=@locParam, religie=@relParam WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@numeParam", (object)nume);
            sqLiteCommand.Parameters.AddWithValue("@nrFisaParam", (object)nrFisa);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)dataNasterii);
            sqLiteCommand.Parameters.AddWithValue("@locParam", (object)loc);
            sqLiteCommand.Parameters.AddWithValue("@relParam", (object)religie);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert partener" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }

        public string updateIesireEvidenta(int id, string motiv, string data, string expl)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand("UPDATE iesire_evidenta SET motiv=@motivParam, data=@dataParam, explicatii=@explParam WHERE id=@idParam", this.conn);
            sqLiteCommand.Parameters.AddWithValue("@idParam", (object)id);
            sqLiteCommand.Parameters.AddWithValue("@motivParam", (object)motiv);
            sqLiteCommand.Parameters.AddWithValue("@dataParam", (object)data);
            sqLiteCommand.Parameters.AddWithValue("@explParam", (object)expl);
            try
            {
                sqLiteCommand.ExecuteNonQuery();
                Console.WriteLine("-----Insert iesire evidenta" + DateTime.Now.ToString("HH:mm:ss.fff"));
                return Status.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----Log error: " + ex.Message);
                return ex.Message;
            }
        }
    }
}
