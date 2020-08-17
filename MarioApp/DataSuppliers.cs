using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace MarioApp
{
    class DataSuppliers
    {
        public void SuppliersInsertAndUpdate(string marLocatie, string sqlNew, string sqlUpdate, string cnn)
        {            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(cnn))
            {
                try
                {
                    OleDbConnection cnnMarJet = new OleDbConnection
                    {
                        ConnectionString = marLocatie
                    };

                    cnnMarJet.Open();

                    OleDbCommand cmdNew = new OleDbCommand
                    {
                        Connection = cnnMarJet,
                        CommandText = sqlNew
                    };

                    OleDbCommand cmdUpdate = new OleDbCommand
                    {
                        Connection = cnnMarJet,
                        CommandText = sqlUpdate
                    };


                    OleDbDataReader readerNew = cmdNew.ExecuteReader();
                    OleDbDataReader readerUpdate = cmdUpdate.ExecuteReader();

                    List<VsoftSupplier> suppliersNew = new List<VsoftSupplier>();
                    List<VsoftSupplier> suppliersUpdate = new List<VsoftSupplier>();


                    while (readerNew.Read())
                    {
                        suppliersNew.Add(new VsoftSupplier
                        {
                            Id = readerNew["A110"].ToString().Trim(' '),
                            A102 = readerNew["A102"].ToString().Trim(' '),
                            A100 = readerNew["A100"].ToString().Trim(' '),
                            Vs01 = readerNew["vs01"].ToString().Trim(' '),
                            A125 = readerNew["A125"].ToString().Trim(' '),
                            A10c = readerNew["A10C"].ToString().Trim(' '),
                            A104 = readerNew["A104"].ToString().Trim(' '),
                            A105 = readerNew["A105"].ToString().Trim(' '),
                            A106 = readerNew["A106"].ToString().Trim(' '),
                            A107 = readerNew["A107"].ToString().Trim(' '),

                            A108 = readerNew["A108"].ToString().Trim(' '),
                            V149 = readerNew["v149"].ToString().Trim(' '),
                            A109 = readerNew["A109"].ToString().Trim(' '),
                            V150 = readerNew["v150"].ToString().Trim(' '),
                            Vs03 = readerNew["vs03"].ToString().Trim(' '),
                            A10a = readerNew["A10A"].ToString().Trim(' '),
                            Vs02 = readerNew["vs02"].ToString().Trim(' '),
                            V224 = readerNew["v224"].ToString().Trim(' '),
                            V163 = readerNew["v163"].ToString().Trim(' '),
                            V016 = readerNew["v016"].ToString().Trim(' '),

                            V161 = readerNew["v161"].ToString().Trim(' '),
                            A161 = readerNew["A161"].ToString().Trim(' '),
                            A170 = readerNew["A170"].ToString().Trim(' '),

                            V259 = readerNew["v259"].ToString().Trim(' '),
                            V260 = readerNew["v260"].ToString().Trim(' '),

                            A400 = readerNew["A400"].ToString().Trim(' '),
                            V015 = readerNew["v015"].ToString().Trim(' '),
                            V151 = readerNew["v151"].ToString().Trim(' '),
                            V111 = readerNew["v111"].ToString().Trim(' '),
                            Vs04 = readerNew["vs04"].ToString().Trim(' '),
                            V017 = readerNew["v017"].ToString().Trim(' '),
                            V018 = readerNew["v018"].ToString().Trim(' '),

                            V001 = readerNew["v001"].ToString().Trim(' '),
                            V002 = readerNew["v002"].ToString().Trim(' '),
                            V226 = readerNew["v226"].ToString().Trim(' '),
                            V227 = readerNew["v227"].ToString().Trim(' '),
                            V247 = readerNew["v247"].ToString().Trim(' '),
                            V254 = readerNew["v254"].ToString().Trim(' '),

                            V255 = readerNew["v255"].ToString().Trim(' '),
                            V256 = readerNew["v256"].ToString().Trim(' '),
                            V262 = readerNew["v262"].ToString().Trim(' ')
                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        connection.Execute("spVsoftSuppliers_InsertFull  @Id, @A102, @A100, @Vs01, @A125, @A10c, @A104, @A105, @A106, @A107, @A108, @V149, @A109, @V150, @Vs03, @A10a, @Vs02, @V224, @V163, @V016, @V161, @A161, @A170, @V259, @V260, @A400, @V015, @V151, @V111, @Vs04, @V017, @V018, @V001, @V002, @V226, @V227, @V247, @V254, @Decv018, @V255, @V256, @V262", suppliersNew);
                    }
                    catch (Exception)
                    {
                        throw;
                    }                            
                    readerNew.Close();


                    while (readerUpdate.Read())
                    {
                        suppliersUpdate.Add(new VsoftSupplier
                        {
                            Id = readerUpdate["A110"].ToString().Trim(' '),
                            A102 = readerUpdate["A102"].ToString().Trim(' '),
                            A100 = readerUpdate["A100"].ToString().Trim(' '),
                            Vs01 = readerUpdate["vs01"].ToString().Trim(' '),
                            A125 = readerUpdate["A125"].ToString().Trim(' '),
                            A10c = readerUpdate["A10C"].ToString().Trim(' '),
                            A104 = readerUpdate["A104"].ToString().Trim(' '),
                            A105 = readerUpdate["A105"].ToString().Trim(' '),
                            A106 = readerUpdate["A106"].ToString().Trim(' '),
                            A107 = readerUpdate["A107"].ToString().Trim(' '),

                            A108 = readerUpdate["A108"].ToString().Trim(' '),
                            V149 = readerUpdate["v149"].ToString().Trim(' '),
                            A109 = readerUpdate["A109"].ToString().Trim(' '),
                            V150 = readerUpdate["v150"].ToString().Trim(' '),
                            Vs03 = readerUpdate["vs03"].ToString().Trim(' '),
                            A10a = readerUpdate["A10A"].ToString().Trim(' '),
                            Vs02 = readerUpdate["vs02"].ToString().Trim(' '),
                            V224 = readerUpdate["v224"].ToString().Trim(' '),
                            V163 = readerUpdate["v163"].ToString().Trim(' '),
                            V016 = readerUpdate["v016"].ToString().Trim(' '),

                            V161 = readerUpdate["v161"].ToString().Trim(' '),
                            A161 = readerUpdate["A161"].ToString().Trim(' '),
                            A170 = readerUpdate["A170"].ToString().Trim(' '),

                            V259 = readerUpdate["v259"].ToString().Trim(' '),
                            V260 = readerUpdate["v260"].ToString().Trim(' '),

                            A400 = readerUpdate["A400"].ToString().Trim(' '),
                            V015 = readerUpdate["v015"].ToString().Trim(' '),
                            V151 = readerUpdate["v151"].ToString().Trim(' '),
                            V111 = readerUpdate["v111"].ToString().Trim(' '),
                            Vs04 = readerUpdate["vs04"].ToString().Trim(' '),
                            V017 = readerUpdate["v017"].ToString().Trim(' '),
                            V018 = readerUpdate["v018"].ToString().Trim(' '),

                            // Decv018 = 0,

                            V001 = readerUpdate["v001"].ToString().Trim(' '),
                            V002 = readerUpdate["v002"].ToString().Trim(' '),
                            V226 = readerUpdate["v226"].ToString().Trim(' '),
                            V227 = readerUpdate["v227"].ToString().Trim(' '),
                            V247 = readerUpdate["v247"].ToString().Trim(' '),
                            V254 = readerUpdate["v254"].ToString().Trim(' '),

                            V255 = readerUpdate["v255"].ToString().Trim(' '),
                            V256 = readerUpdate["v256"].ToString().Trim(' '),
                            V262 = readerUpdate["v262"].ToString().Trim(' ')
                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        connection.Execute("spVsoftSuppliers_UpdateFull  @Id, @A102, @A100, @Vs01, @A125, @A10c, @A104, @A105, @A106, @A107, @A108, @V149, @A109, @V150, @Vs03, @A10a, @Vs02, @V224, @V163, @V016, @V161, @A161, @A170, @V259, @V260, @A400, @V015, @V151, @V111, @Vs04, @V017, @V018, @V001, @V002, @V226, @V227, @V247, @V254, @Decv018, @V255, @V256, @V262", suppliersUpdate);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    readerUpdate.Close();
                    
                    OleDbCommand command = new OleDbCommand("UPDATE Leveranciers SET dnnSync=True, dnnSyncAlready = True", cnnMarJet);
                    command.ExecuteNonQuery();
                    cnnMarJet.Close();
                }
                catch (Exception)
                {                    
                    throw;
                }
            }
        }
    }
}
