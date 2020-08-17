using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace MarioApp
{
    class DataLedgers
    {
        public void LedgersInsertAndUpdate(string marLocatie, string sqlNew, string sqlUpdate, string cnn)
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

                    List<VsoftLedger> ledgersNew = new List<VsoftLedger>();
                    List<VsoftLedger> ledgersUpdate = new List<VsoftLedger>();


                    while (readerNew.Read())
                    {
                        decimal iodece068;
                        if (!Convert.IsDBNull(readerNew["dece068"]))
                        {
                            iodece068 = (decimal)readerNew["dece068"];
                        }
                        else
                        {
                            iodece068 = 0;
                        }

                        ledgersNew.Add(new VsoftLedger
                        {
                            RvID = (int)readerNew["rvID"],
                            VsoftLedgerAccountId = readerNew["v019"].ToString().Trim(' '),
                            V070 = readerNew["v070"].ToString().Trim(' '),
                            V034 = readerNew["v034"].ToString().Trim(' '),
                            V066 = readerNew["v066"].ToString().Trim(' '),
                            V033 = readerNew["v033"].ToString().Trim(' '),
                            V038 = readerNew["v038"].ToString().Trim(' '),
                            V035 = readerNew["v035"].ToString().Trim(' '),
                            V067 = readerNew["v067"].ToString().Trim(' '),
                            V068 = readerNew["v068"].ToString().Trim(' '),
                            V069 = readerNew["v069"].ToString().Trim(' '),
                            V041 = readerNew["v041"].ToString().Trim(' '),
                            V249 = readerNew["v249"].ToString().Trim(' '),
                            V248 = readerNew["v248"].ToString().Trim(' '),
                            V245 = readerNew["v245"].ToString().Trim(' '),
                            V246 = readerNew["v246"].ToString().Trim(' '),
                            V102 = readerNew["v102"].ToString().Trim(' '),

                            Dece068 = iodece068
                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        connection.Execute("spVsoftLedgers_InsertFull @V070, @V034, @V066, @V033, @V038, @V035, @V067, @V068, @V069, @V041, @V249, @V248, @V245, @V246, @Dece068, @V102, @RvID, @VsoftLedgerAccountId", ledgersNew);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    readerNew.Close();


                    while (readerUpdate.Read())
                    {
                        decimal iodece068;
                        if (!Convert.IsDBNull(readerUpdate["dece068"]))
                        {
                            iodece068 = (decimal)readerUpdate["dece068"];
                        }
                        else
                        {
                            iodece068 = 0;
                        }

                        ledgersUpdate.Add(new VsoftLedger
                        {
                            VsoftLedgerAccountId = readerUpdate["v019"].ToString().Trim(' '),
                            V070 = readerUpdate["v070"].ToString().Trim(' '),
                            V034 = readerUpdate["v034"].ToString().Trim(' '),
                            V066 = readerUpdate["v066"].ToString().Trim(' '),
                            V033 = readerUpdate["v033"].ToString().Trim(' '),
                            V038 = readerUpdate["v038"].ToString().Trim(' '),
                            V035 = readerUpdate["v035"].ToString().Trim(' '),
                            V067 = readerUpdate["v067"].ToString().Trim(' '),
                            V068 = readerUpdate["v068"].ToString().Trim(' '),
                            V069 = readerUpdate["v069"].ToString().Trim(' '),
                            V041 = readerUpdate["v041"].ToString().Trim(' '),
                            V249 = readerUpdate["v249"].ToString().Trim(' '),
                            V248 = readerUpdate["v248"].ToString().Trim(' '),
                            V245 = readerUpdate["v245"].ToString().Trim(' '),
                            V246 = readerUpdate["v246"].ToString().Trim(' '),
                            V102 = readerUpdate["v102"].ToString().Trim(' '),

                            Dece068 = iodece068

                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        connection.Execute("spVsoftLedgers_UpdateFull @V070, @V034, @V066, @V033, @V038, @V035, @V067, @V068, @V069, @V041, @V249, @V248, @V245, @V246, @Dece068, @V102, @RvID, @VsoftLedgerAccountId", ledgersUpdate);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    readerUpdate.Close();

                    OleDbCommand command = new OleDbCommand("UPDATE Journalen SET dnnSync=True, dnnSyncAlready = True", cnnMarJet);
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
