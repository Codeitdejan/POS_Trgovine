﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCPOS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string id_partner {
            get {
                return ((string)(this["id_partner"]));
            }
            set {
                this["id_partner"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string id_roba {
            get {
                return ((string)(this["id_roba"]));
            }
            set {
                this["id_roba"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public string PDV {
            get {
                return ((string)(this["PDV"]));
            }
            set {
                this["PDV"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string id_zaposlenik {
            get {
                return ((string)(this["id_zaposlenik"]));
            }
            set {
                this["id_zaposlenik"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string idSkladiste {
            get {
                return ((string)(this["idSkladiste"]));
            }
            set {
                this["idSkladiste"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public string defaultSkladiste {
            get {
                return ((string)(this["defaultSkladiste"]));
            }
            set {
                this["defaultSkladiste"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\\pc_pos_database.sdf")]
        public string pc_pos_databaseConnectionString {
            get {
                return ((string)(this["pc_pos_databaseConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal verzija_programa {
            get {
                return ((decimal)(this["verzija_programa"]));
            }
            set {
                this["verzija_programa"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string br_konta {
            get {
                return ((string)(this["br_konta"]));
            }
            set {
                this["br_konta"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://46.229.245.211/KonektorPostgres.asmx")]
        public string PC_POS_WebReference_KonektorPostgres {
            get {
                return ((string)(this["PC_POS_WebReference_KonektorPostgres"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://new.pc1.hr/konektor.asmx")]
        public string PC_POS_pc1_konektor {
            get {
                return ((string)(this["PC_POS_pc1_konektor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public string trazi_robno_prvih {
            get {
                return ((string)(this["trazi_robno_prvih"]));
            }
            set {
                this["trazi_robno_prvih"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool artikli_koji_su_na_skl {
            get {
                return ((bool)(this["artikli_koji_su_na_skl"]));
            }
            set {
                this["artikli_koji_su_na_skl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.pc1.hr/pcpos/provjera_nadogradnje.php")]
        public string domena_za_sinkronizaciju {
            get {
                return ((string)(this["domena_za_sinkronizaciju"]));
            }
            set {
                this["domena_za_sinkronizaciju"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://software.pc1.hr/wsSoftKontrol.asmx")]
        public string PC_POS_wsSoftKontrol_wsSoftKontrol {
            get {
                return ((string)(this["PC_POS_wsSoftKontrol_wsSoftKontrol"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.pc1.hr/pcpos/provjera_nadogradnje.php")]
        public string domena_za_nadogradnju {
            get {
                return ((string)(this["domena_za_nadogradnju"]));
            }
            set {
                this["domena_za_nadogradnju"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CREATE OR REPLACE FUNCTION postavi_kolicinu_sql_funkcija()\r\n          RETURNS voi" +
            "d AS\r\n          $BODY$\r\n          BEGIN\r\n\r\n          --RACUNI\r\n          CREATE " +
            "TEMP TABLE _racuni AS\r\n          SELECT sifra_robe AS sifra,id_skladiste as skla" +
            "diste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FR" +
            "OM racun_stavke GROUP BY sifra_robe,id_skladiste;\r\n\r\n          --KALKULACIJE\r\n  " +
            "        CREATE TEMP TABLE _kalkulacije AS\r\n          SELECT sifra AS sifra,id_sk" +
            "ladiste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0)" +
            " AS kolicina FROM kalkulacija_stavke GROUP BY sifra,id_skladiste;\r\n\r\n          -" +
            "-IZDATNICE\r\n          CREATE TEMP TABLE _izdatnice AS\r\n          SELECT sifra AS" +
            " sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as " +
            "NUMERIC)),0) AS kolicina FROM izdatnica_stavke LEFT JOIN izdatnica ON izdatnica." +
            "broj=izdatnica_stavke.broj AND izdatnica.id_izdatnica=izdatnica_stavke.id_izdatn" +
            "ica GROUP BY sifra,id_skladiste;\r\n\r\n          --PRIMKE\r\n          CREATE TEMP TA" +
            "BLE _primke AS\r\n          SELECT sifra AS sifra,id_skladiste as skladiste,COALES" +
            "CE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM primka_st" +
            "avke LEFT JOIN primka ON primka.id_primka=primka_stavke.id_primka GROUP BY sifra" +
            ",id_skladiste;\r\n\r\n          --FAKTURE\r\n          CREATE TEMP TABLE _fakture AS\r\n" +
            "          SELECT sifra AS sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REPL" +
            "ACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM faktura_stavke LEFT JOIN " +
            "fakture ON fakture.broj_fakture = faktura_stavke.broj_fakture AND fakture.id_duc" +
            "an=faktura_stavke.id_ducan AND fakture.id_kasa=faktura_stavke.id_kasa WHERE fakt" +
            "ure.oduzmi_iz_skladista=\'1\' GROUP BY sifra,id_skladiste;\r\n\r\n          --MEĐUSKLA" +
            "DIŠNICA IZ SKLADIŠTA\r\n          CREATE TEMP TABLE _meduskladisnica_iz_skladista " +
            "AS\r\n          SELECT sifra AS sifra,meduskladisnica.id_skladiste_od as skladiste" +
            ",COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM me" +
            "duskladisnica_stavke LEFT JOIN meduskladisnica ON meduskladisnica.broj=medusklad" +
            "isnica_stavke.broj AND meduskladisnica.id_skladiste_od=meduskladisnica_stavke.iz" +
            "_skladista GROUP BY sifra,id_skladiste_od;\r\n\r\n          --MEĐUSKLADIŠNICA U SKLA" +
            "DIŠTE\r\n          CREATE TEMP TABLE _meduskladisnica_u_skladiste AS\r\n          SE" +
            "LECT sifra AS sifra,meduskladisnica.id_skladiste_do as skladiste,COALESCE(SUM(CA" +
            "ST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM meduskladisnica_st" +
            "avke LEFT JOIN meduskladisnica ON meduskladisnica.broj=meduskladisnica_stavke.br" +
            "oj AND meduskladisnica.id_skladiste_od=meduskladisnica_stavke.iz_skladista GROUP" +
            " BY sifra,id_skladiste_do;\r\n\r\n          --OTPREMNICA\r\n          CREATE TEMP TABL" +
            "E _otpremnica AS\r\n          SELECT sifra_robe AS sifra,id_skladiste as skladiste" +
            ",COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM ot" +
            "premnica_stavke GROUP BY sifra_robe,id_skladiste;\r\n\r\n          --OTPIS ROBE\r\n   " +
            "       CREATE TEMP TABLE _otpis_robe AS\r\n          SELECT sifra AS sifra,id_skla" +
            "diste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) A" +
            "S kolicina FROM otpis_robe_stavke LEFT JOIN otpis_robe ON otpis_robe.broj=otpis_" +
            "robe_stavke.broj GROUP BY sifra,id_skladiste;\r\n\r\n          --POVRAT ROBE\r\n      " +
            "    CREATE TEMP TABLE _povrat_robe AS\r\n          SELECT sifra AS sifra,id_skladi" +
            "ste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS " +
            "kolicina FROM povrat_robe_stavke LEFT JOIN povrat_robe ON povrat_robe.broj=povra" +
            "t_robe_stavke.broj GROUP BY sifra,id_skladiste;\r\n\r\n          --POCETNO\r\n        " +
            "  CREATE TEMP TABLE _pocetno AS\r\n          SELECT sifra AS sifra,id_skladiste as" +
            " skladiste,COALESCE(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC),0) AS kolicina FR" +
            "OM pocetno GROUP BY sifra,id_skladiste,kolicina;\r\n\r\n          --RADNI NALOG STAV" +
            "KE\r\n          CREATE TEMP TABLE _radni_nalog_stavke AS\r\n          SELECT sifra_r" +
            "obe AS sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'." +
            "\') as NUMERIC)),0) AS kolicina FROM radni_nalog_stavke LEFT JOIN radni_nalog ON " +
            "radni_nalog.broj_naloga=radni_nalog_stavke.broj_naloga GROUP BY sifra_robe,id_sk" +
            "ladiste;\r\n\r\n          --RADNI NALOG STAVKE--&gt;NORMATIVI\r\n          CREATE TEMP" +
            " TABLE _radni_nalog_normativi AS\r\n          SELECT normativi_stavke.sifra_robe A" +
            "S sifra,normativi_stavke.id_skladiste as skladiste,\r\n          COALESCE(SUM\r\n   " +
            "       (\r\n          CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)*\r\n          (SELE" +
            "CT SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)) FROM radni_nalog_stavke LEFT " +
            "JOIN radni_nalog ON radni_nalog.broj_naloga=radni_nalog_stavke.broj_naloga\r\n    " +
            "      WHERE normativi.sifra_artikla=radni_nalog_stavke.sifra_robe\r\n          )\r\n" +
            "          ),0) AS kolicina\r\n          FROM normativi_stavke\r\n          LEFT JOIN" +
            " normativi ON normativi.broj_normativa = normativi_stavke.broj_normativa\r\n      " +
            "    GROUP BY sifra_robe,id_skladiste;\r\n\r\n          --NORMATIVI (NA USLUGU SE DOD" +
            "AJU PRODAJNI ARTIKLI)\r\n          CREATE TEMP TABLE _normativi_usluga AS\r\n       " +
            "   SELECT normativi_stavke.sifra_robe AS sifra,normativi_stavke.id_skladiste as " +
            "skladiste,\r\n          COALESCE(SUM\r\n          (\r\n          CAST(REPLACE(kolicina" +
            ",\',\',\'.\') as NUMERIC)*\r\n          (SELECT SUM(CAST(REPLACE(kolicina,\',\',\'.\') as " +
            "NUMERIC)) FROM racun_stavke LEFT JOIN racuni ON racuni.broj_racuna=racun_stavke." +
            "broj_racuna AND racuni.id_ducan=racun_stavke.id_ducan AND racuni.id_kasa=racun_s" +
            "tavke.id_kasa\r\n          WHERE normativi.sifra_artikla=racun_stavke.sifra_robe\r\n" +
            "          )\r\n          ),0) AS kolicina\r\n          FROM normativi_stavke\r\n      " +
            "    LEFT JOIN normativi ON normativi.broj_normativa = normativi_stavke.broj_norm" +
            "ativa\r\n          LEFT JOIN roba ON roba.sifra=normativi.sifra_artikla\r\n         " +
            " WHERE roba.oduzmi=\'NE\'\r\n          GROUP BY sifra_robe,id_skladiste;\r\n\r\n        " +
            "  CREATE TEMP TABLE bitne_sifre AS\r\n          SELECT sifra FROM _racuni\r\n       " +
            "   UNION\r\n          SELECT sifra FROM _kalkulacije\r\n          UNION\r\n          S" +
            "ELECT sifra FROM _izdatnice\r\n          UNION\r\n          SELECT sifra FROM _faktu" +
            "re\r\n          UNION\r\n          SELECT sifra FROM _meduskladisnica_iz_skladista\r\n" +
            "          UNION\r\n          SELECT sifra FROM _meduskladisnica_u_skladiste\r\n     " +
            "     UNION\r\n          SELECT sifra FROM _otpremnica\r\n          UNION\r\n          " +
            "SELECT sifra FROM _otpis_robe\r\n          UNION\r\n          SELECT sifra FROM _pov" +
            "rat_robe\r\n          UNION\r\n          SELECT sifra FROM _pocetno\r\n          UNION" +
            "\r\n          SELECT sifra FROM _radni_nalog_stavke\r\n          UNION\r\n          SE" +
            "LECT sifra FROM _radni_nalog_normativi\r\n          UNION\r\n          SELECT sifra " +
            "FROM _normativi_usluga;\r\n\r\n          UPDATE roba_prodaja SET kolicina=\r\n        " +
            "  (\r\n          REPLACE(CAST(\r\n          COALESCE(\r\n          COALESCE((SELECT _p" +
            "ocetno.kolicina FROM _pocetno WHERE _pocetno.sifra=roba_prodaja.sifra AND _pocet" +
            "no.skladiste=roba_prodaja.id_skladiste),0)\r\n          +\r\n          COALESCE((SEL" +
            "ECT _kalkulacije.kolicina FROM _kalkulacije WHERE _kalkulacije.sifra=roba_prodaj" +
            "a.sifra AND _kalkulacije.skladiste=roba_prodaja.id_skladiste),0)\r\n          +\r\n " +
            "         COALESCE((SELECT _radni_nalog_stavke.kolicina FROM _radni_nalog_stavke " +
            "WHERE _radni_nalog_stavke.sifra=roba_prodaja.sifra AND _radni_nalog_stavke.sklad" +
            "iste=roba_prodaja.id_skladiste),0)\r\n          +\r\n          COALESCE((SELECT _pri" +
            "mke.kolicina FROM _primke WHERE _primke.sifra=roba_prodaja.sifra AND _primke.skl" +
            "adiste=roba_prodaja.id_skladiste),0)\r\n          +\r\n          COALESCE((SELECT _m" +
            "eduskladisnica_u_skladiste.kolicina FROM _meduskladisnica_u_skladiste WHERE _med" +
            "uskladisnica_u_skladiste.sifra=roba_prodaja.sifra AND _meduskladisnica_u_skladis" +
            "te.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALESCE((SEL" +
            "ECT _racuni.kolicina FROM _racuni WHERE _racuni.sifra=roba_prodaja.sifra AND _ra" +
            "cuni.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALESCE((S" +
            "ELECT _izdatnice.kolicina FROM _izdatnice WHERE _izdatnice.sifra=roba_prodaja.si" +
            "fra AND _izdatnice.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n       " +
            "   COALESCE((SELECT _fakture.kolicina FROM _fakture WHERE _fakture.sifra=roba_pr" +
            "odaja.sifra AND _fakture.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n " +
            "         COALESCE((SELECT _meduskladisnica_iz_skladista.kolicina FROM _medusklad" +
            "isnica_iz_skladista WHERE _meduskladisnica_iz_skladista.sifra=roba_prodaja.sifra" +
            " AND _meduskladisnica_iz_skladista.skladiste=roba_prodaja.id_skladiste),0)\r\n    " +
            "      -\r\n          COALESCE((SELECT _otpremnica.kolicina FROM _otpremnica WHERE " +
            "_otpremnica.sifra=roba_prodaja.sifra AND _otpremnica.skladiste=roba_prodaja.id_s" +
            "kladiste),0)\r\n          -\r\n          COALESCE((SELECT _otpis_robe.kolicina FROM " +
            "_otpis_robe WHERE _otpis_robe.sifra=roba_prodaja.sifra AND _otpis_robe.skladiste" +
            "=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALESCE((SELECT _povrat_" +
            "robe.kolicina FROM _povrat_robe WHERE _povrat_robe.sifra=roba_prodaja.sifra AND " +
            "_povrat_robe.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COA" +
            "LESCE((SELECT _radni_nalog_normativi.kolicina FROM _radni_nalog_normativi WHERE " +
            "_radni_nalog_normativi.sifra=roba_prodaja.sifra AND _radni_nalog_normativi.sklad" +
            "iste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALESCE((SELECT _nor" +
            "mativi_usluga.kolicina FROM _normativi_usluga WHERE _normativi_usluga.sifra=roba" +
            "_prodaja.sifra AND _normativi_usluga.skladiste=roba_prodaja.id_skladiste),0)\r\n  " +
            "        ,0)\r\n          AS character varying),\'.\',\',\')\r\n          ) WHERE sifra I" +
            "N (SELECT sifra FROM bitne_sifre);\r\n          UPDATE roba_prodaja SET kolicina=\'" +
            "0\' WHERE sifra IN (SELECT sifra FROM roba WHERE oduzmi=\'NE\');\r\n\r\n          END;\r" +
            "\n          $BODY$ LANGUAGE plpgsql;")]
        public string pohranjena_procedura_kolicina {
            get {
                return ((string)(this["pohranjena_procedura_kolicina"]));
            }
            set {
                this["pohranjena_procedura_kolicina"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CREATE OR REPLACE FUNCTION postavi_kolicinu_sql_funkcija_prema_sifri(skup_sifra c" +
            "haracter varying)\r\n          RETURNS void AS\r\n          $BODY$\r\n          BEGIN\r" +
            "\n\r\n          --RACUNI\r\n          CREATE TEMP TABLE _racuni AS\r\n          SELECT " +
            "sifra_robe AS sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina" +
            ",\',\',\'.\') as NUMERIC)),0) AS kolicina FROM racun_stavke GROUP BY sifra_robe,id_s" +
            "kladiste;\r\n\r\n          --KALKULACIJE\r\n          CREATE TEMP TABLE _kalkulacije A" +
            "S\r\n          SELECT sifra AS sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(R" +
            "EPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM kalkulacija_stavke GRO" +
            "UP BY sifra,id_skladiste;\r\n\r\n          --IZDATNICE\r\n          CREATE TEMP TABLE " +
            "_izdatnice AS\r\n          SELECT sifra AS sifra,id_skladiste as skladiste,COALESC" +
            "E(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM izdatnica_" +
            "stavke LEFT JOIN izdatnica ON izdatnica.broj=izdatnica_stavke.broj AND izdatnica" +
            ".id_izdatnica=izdatnica_stavke.id_izdatnica GROUP BY sifra,id_skladiste;\r\n\r\n    " +
            "      --PRIMKE\r\n          CREATE TEMP TABLE _primke AS\r\n          SELECT sifra A" +
            "S sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as" +
            " NUMERIC)),0) AS kolicina FROM primka_stavke LEFT JOIN primka ON primka.id_primk" +
            "a=primka_stavke.id_primka GROUP BY sifra,id_skladiste;\r\n\r\n          --FAKTURE\r\n " +
            "         CREATE TEMP TABLE _fakture AS\r\n          SELECT sifra AS sifra,id_sklad" +
            "iste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS" +
            " kolicina FROM faktura_stavke LEFT JOIN fakture ON fakture.broj_fakture = faktur" +
            "a_stavke.broj_fakture AND fakture.id_ducan=faktura_stavke.id_ducan AND fakture.i" +
            "d_kasa=faktura_stavke.id_kasa WHERE fakture.oduzmi_iz_skladista=\'1\' GROUP BY sif" +
            "ra,id_skladiste;\r\n\r\n          --MEĐUSKLADIŠNICA IZ SKLADIŠTA\r\n          CREATE T" +
            "EMP TABLE _meduskladisnica_iz_skladista AS\r\n          SELECT sifra AS sifra,medu" +
            "skladisnica.id_skladiste_od as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\'," +
            "\'.\') as NUMERIC)),0) AS kolicina FROM meduskladisnica_stavke LEFT JOIN medusklad" +
            "isnica ON meduskladisnica.broj=meduskladisnica_stavke.broj AND meduskladisnica.i" +
            "d_skladiste_od=meduskladisnica_stavke.iz_skladista GROUP BY sifra,id_skladiste_o" +
            "d;\r\n\r\n          --MEĐUSKLADIŠNICA U SKLADIŠTE\r\n          CREATE TEMP TABLE _medu" +
            "skladisnica_u_skladiste AS\r\n          SELECT sifra AS sifra,meduskladisnica.id_s" +
            "kladiste_do as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)" +
            "),0) AS kolicina FROM meduskladisnica_stavke LEFT JOIN meduskladisnica ON medusk" +
            "ladisnica.broj=meduskladisnica_stavke.broj AND meduskladisnica.id_skladiste_od=m" +
            "eduskladisnica_stavke.iz_skladista GROUP BY sifra,id_skladiste_do;\r\n\r\n          " +
            "--OTPREMNICA\r\n          CREATE TEMP TABLE _otpremnica AS\r\n          SELECT sifra" +
            "_robe AS sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REPLACE(kolicina,\',\'," +
            "\'.\') as NUMERIC)),0) AS kolicina FROM otpremnica_stavke GROUP BY sifra_robe,id_s" +
            "kladiste;\r\n\r\n          --OTPIS ROBE\r\n          CREATE TEMP TABLE _otpis_robe AS\r" +
            "\n          SELECT sifra AS sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REP" +
            "LACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM otpis_robe_stavke LEFT J" +
            "OIN otpis_robe ON otpis_robe.broj=otpis_robe_stavke.broj GROUP BY sifra,id_sklad" +
            "iste;\r\n\r\n          --POVRAT ROBE\r\n          CREATE TEMP TABLE _povrat_robe AS\r\n " +
            "         SELECT sifra AS sifra,id_skladiste as skladiste,COALESCE(SUM(CAST(REPLA" +
            "CE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM povrat_robe_stavke LEFT JO" +
            "IN povrat_robe ON povrat_robe.broj=povrat_robe_stavke.broj GROUP BY sifra,id_skl" +
            "adiste;\r\n\r\n          --POCETNO\r\n          CREATE TEMP TABLE _pocetno AS\r\n       " +
            "   SELECT sifra AS sifra,id_skladiste as skladiste,COALESCE(CAST(REPLACE(kolicin" +
            "a,\',\',\'.\') as NUMERIC),0) AS kolicina FROM pocetno GROUP BY sifra,id_skladiste,k" +
            "olicina;\r\n\r\n          --RADNI NALOG STAVKE\r\n          CREATE TEMP TABLE _radni_n" +
            "alog_stavke AS\r\n          SELECT sifra_robe AS sifra,id_skladiste as skladiste,C" +
            "OALESCE(SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)),0) AS kolicina FROM radn" +
            "i_nalog_stavke LEFT JOIN radni_nalog ON radni_nalog.broj_naloga=radni_nalog_stav" +
            "ke.broj_naloga GROUP BY sifra_robe,id_skladiste;\r\n\r\n          --RADNI NALOG STAV" +
            "KE--&gt;NORMATIVI\r\n          CREATE TEMP TABLE _radni_nalog_normativi AS\r\n      " +
            "    SELECT normativi_stavke.sifra_robe AS sifra,normativi_stavke.id_skladiste as" +
            " skladiste,\r\n          COALESCE(SUM\r\n          (\r\n          CAST(REPLACE(kolicin" +
            "a,\',\',\'.\') as NUMERIC)*\r\n          (SELECT SUM(CAST(REPLACE(kolicina,\',\',\'.\') as" +
            " NUMERIC)) FROM radni_nalog_stavke LEFT JOIN radni_nalog ON radni_nalog.broj_nal" +
            "oga=radni_nalog_stavke.broj_naloga\r\n          WHERE normativi.sifra_artikla=radn" +
            "i_nalog_stavke.sifra_robe\r\n          )\r\n          ),0) AS kolicina\r\n          FR" +
            "OM normativi_stavke\r\n          LEFT JOIN normativi ON normativi.broj_normativa =" +
            " normativi_stavke.broj_normativa\r\n          GROUP BY sifra_robe,id_skladiste;\r\n\r" +
            "\n          --NORMATIVI (NA USLUGU SE DODAJU PRODAJNI ARTIKLI)\r\n          CREATE " +
            "TEMP TABLE _normativi_usluga AS\r\n          SELECT normativi_stavke.sifra_robe AS" +
            " sifra,normativi_stavke.id_skladiste as skladiste,\r\n          COALESCE(SUM\r\n    " +
            "      (\r\n          CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)*\r\n          (SELEC" +
            "T SUM(CAST(REPLACE(kolicina,\',\',\'.\') as NUMERIC)) FROM racun_stavke LEFT JOIN ra" +
            "cuni ON racuni.broj_racuna=racun_stavke.broj_racuna AND racuni.id_ducan=racun_st" +
            "avke.id_ducan AND racuni.id_kasa=racun_stavke.id_kasa\r\n          WHERE normativi" +
            ".sifra_artikla=racun_stavke.sifra_robe\r\n          )\r\n          ),0) AS kolicina\r" +
            "\n          FROM normativi_stavke\r\n          LEFT JOIN normativi ON normativi.bro" +
            "j_normativa = normativi_stavke.broj_normativa\r\n          LEFT JOIN roba ON roba." +
            "sifra=normativi.sifra_artikla\r\n          WHERE roba.oduzmi=\'NE\'\r\n          GROUP" +
            " BY sifra_robe,id_skladiste;\r\n\r\n          UPDATE roba_prodaja SET kolicina=\r\n   " +
            "       (\r\n          REPLACE(CAST(\r\n          COALESCE(\r\n          COALESCE((SELE" +
            "CT _pocetno.kolicina FROM _pocetno WHERE _pocetno.sifra=roba_prodaja.sifra AND _" +
            "pocetno.skladiste=roba_prodaja.id_skladiste),0)\r\n          +\r\n          COALESCE" +
            "((SELECT _kalkulacije.kolicina FROM _kalkulacije WHERE _kalkulacije.sifra=roba_p" +
            "rodaja.sifra AND _kalkulacije.skladiste=roba_prodaja.id_skladiste),0)\r\n         " +
            " +\r\n          COALESCE((SELECT _radni_nalog_stavke.kolicina FROM _radni_nalog_st" +
            "avke WHERE _radni_nalog_stavke.sifra=roba_prodaja.sifra AND _radni_nalog_stavke." +
            "skladiste=roba_prodaja.id_skladiste),0)\r\n          +\r\n          COALESCE((SELECT" +
            " _primke.kolicina FROM _primke WHERE _primke.sifra=roba_prodaja.sifra AND _primk" +
            "e.skladiste=roba_prodaja.id_skladiste),0)\r\n          +\r\n          COALESCE((SELE" +
            "CT _meduskladisnica_u_skladiste.kolicina FROM _meduskladisnica_u_skladiste WHERE" +
            " _meduskladisnica_u_skladiste.sifra=roba_prodaja.sifra AND _meduskladisnica_u_sk" +
            "ladiste.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALESCE" +
            "((SELECT _racuni.kolicina FROM _racuni WHERE _racuni.sifra=roba_prodaja.sifra AN" +
            "D _racuni.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALES" +
            "CE((SELECT _izdatnice.kolicina FROM _izdatnice WHERE _izdatnice.sifra=roba_proda" +
            "ja.sifra AND _izdatnice.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n  " +
            "        COALESCE((SELECT _fakture.kolicina FROM _fakture WHERE _fakture.sifra=ro" +
            "ba_prodaja.sifra AND _fakture.skladiste=roba_prodaja.id_skladiste),0)\r\n         " +
            " -\r\n          COALESCE((SELECT _meduskladisnica_iz_skladista.kolicina FROM _medu" +
            "skladisnica_iz_skladista WHERE _meduskladisnica_iz_skladista.sifra=roba_prodaja." +
            "sifra AND _meduskladisnica_iz_skladista.skladiste=roba_prodaja.id_skladiste),0)\r" +
            "\n          -\r\n          COALESCE((SELECT _otpremnica.kolicina FROM _otpremnica W" +
            "HERE _otpremnica.sifra=roba_prodaja.sifra AND _otpremnica.skladiste=roba_prodaja" +
            ".id_skladiste),0)\r\n          -\r\n          COALESCE((SELECT _otpis_robe.kolicina " +
            "FROM _otpis_robe WHERE _otpis_robe.sifra=roba_prodaja.sifra AND _otpis_robe.skla" +
            "diste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALESCE((SELECT _po" +
            "vrat_robe.kolicina FROM _povrat_robe WHERE _povrat_robe.sifra=roba_prodaja.sifra" +
            " AND _povrat_robe.skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n        " +
            "  COALESCE((SELECT _radni_nalog_normativi.kolicina FROM _radni_nalog_normativi W" +
            "HERE _radni_nalog_normativi.sifra=roba_prodaja.sifra AND _radni_nalog_normativi." +
            "skladiste=roba_prodaja.id_skladiste),0)\r\n          -\r\n          COALESCE((SELECT" +
            " _normativi_usluga.kolicina FROM _normativi_usluga WHERE _normativi_usluga.sifra" +
            "=roba_prodaja.sifra AND _normativi_usluga.skladiste=roba_prodaja.id_skladiste),0" +
            ")\r\n          ,0)\r\n          AS character varying),\'.\',\',\')\r\n          ) WHERE si" +
            "fra IN (skup_sifra);\r\n          UPDATE roba_prodaja SET kolicina=\'0\' WHERE sifra" +
            " IN (SELECT sifra FROM roba WHERE oduzmi=\'NE\');\r\n\r\n          DROP TABLE IF EXIST" +
            "S _racuni;\r\n          DROP TABLE IF EXISTS _primke;\r\n          DROP TABLE IF EXI" +
            "STS _kalkulacije;\r\n          DROP TABLE IF EXISTS _izdatnice;\r\n          DROP TA" +
            "BLE IF EXISTS _fakture;\r\n          DROP TABLE IF EXISTS _meduskladisnica_iz_skla" +
            "dista;\r\n          DROP TABLE IF EXISTS _meduskladisnica_u_skladiste;\r\n          " +
            "DROP TABLE IF EXISTS _otpremnica;\r\n          DROP TABLE IF EXISTS _otpis_robe;\r\n" +
            "          DROP TABLE IF EXISTS _povrat_robe;\r\n          DROP TABLE IF EXISTS _po" +
            "cetno;\r\n          DROP TABLE IF EXISTS _radni_nalog_stavke;\r\n          DROP TABL" +
            "E IF EXISTS _radni_nalog_normativi;\r\n          DROP TABLE IF EXISTS _normativi_u" +
            "sluga;\r\n\r\n          END;\r\n          $BODY$ LANGUAGE plpgsql;")]
        public string pohranjena_procedura_kolicina_prema_sifri {
            get {
                return ((string)(this["pohranjena_procedura_kolicina_prema_sifri"]));
            }
            set {
                this["pohranjena_procedura_kolicina_prema_sifri"] = value;
            }
        }
    }
}
