﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace MarioApp
{
    class DataContracts
    {
        public void ContractsInsertAndUpdate(string marLocatie, string sqlNew, string sqlUpdate, string cnn)
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

                    List<VsoftContract> contractsNew = new List<VsoftContract>();
                    List<VsoftContract > contractsUpdate = new List<VsoftContract>();

                    


                    while (readerNew.Read())
                    {
                        decimal ioB010;
                        if (!Convert.IsDBNull(readerNew["decB010"]))
                        {
                            ioB010 = (decimal)readerNew["decB010"];
                        }
                        else
                        {
                            ioB010 = 0;
                        }

                        decimal ioB014;
                        if (!Convert.IsDBNull(readerNew["decB014"]))
                        {
                            ioB014 = (decimal)readerNew["decB014"];
                        }
                        else
                        {
                            ioB014 = 0;
                        }
                                               
                        contractsNew.Add(new VsoftContract
                        {
                            Id = readerNew["A000"].ToString().Trim(' '),
                            A010 = readerNew["A010"].ToString().Trim(' '),                                                        
                            VsoftCustomerId = readerNew["A110"].ToString().Trim(' '),
                            Vs99 = readerNew["vs99"].ToString().Trim(' '),
                            Vs98 = readerNew["vs98"].ToString().Trim(' '),
                            V164 = readerNew["v164"].ToString().Trim(' '),
                            V165 = readerNew["v165"].ToString().Trim(' '),
                            Aw2 = readerNew["AW_2"].ToString().Trim(' '),
                            A325 = readerNew["A325"].ToString().Trim(' '),
                            A600 = readerNew["A600"].ToString().Trim(' '),
                            Vs97 = readerNew["vs97"].ToString().Trim(' '),
                            B010 = readerNew["B010"].ToString().Trim(' '),
                            B014 = readerNew["B014"].ToString().Trim(' '),
                            V166 = readerNew["v166"].ToString().Trim(' '),
                            V223 = readerNew["v223"].ToString().Trim(' '),
                            Vs96 = readerNew["vs96"].ToString().Trim(' '),
                            V167 = readerNew["v167"].ToString().Trim(' '),
                                                                            

                            DecB010 = ioB010,
                            DecB014 = ioB014,

                            Dece069 = readerNew["dece069"].ToString().Trim(' '),

                            E069 = readerNew["e069"].ToString().Trim(' '),
                            E070 = readerNew["e070"].ToString().Trim(' '),
                            E071 = readerNew["e071"].ToString().Trim(' '),
                            E072 = readerNew["e072"].ToString().Trim(' ')                            
                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        connection.Execute("spVsoftContracts_InsertFull @Id, @A010, @Vs99, @Vs98, @V164, @V165, @Aw2, @A325, @A600, @Vs97, @B010, @B014, @V166, @V223, @Vs96, @V167, @DecB010, @DecB014, @Dece069, @E069, @E070, @E071, @E072, @VsoftCustomerId", contractsNew);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    readerNew.Close();


                    while (readerUpdate.Read())
                    {
                        decimal ioB010;
                        if (!Convert.IsDBNull(readerUpdate["decB010"]))
                        {
                            ioB010 = (decimal)readerUpdate["decB010"];
                        }
                        else
                        {
                            ioB010 = 0;
                        }

                        decimal ioB014;
                        if (!Convert.IsDBNull(readerUpdate["decB014"]))
                        {
                            ioB014 = (decimal)readerUpdate["decB014"];
                        }
                        else
                        {
                            ioB014 = 0;
                        }

                        contractsUpdate.Add(new VsoftContract 
                        {
                            Id = readerUpdate["A000"].ToString().Trim(' '),
                            A010 = readerUpdate["A010"].ToString().Trim(' '),
                            VsoftCustomerId = readerUpdate["A110"].ToString().Trim(' '),
                            Vs99 = readerUpdate["vs99"].ToString().Trim(' '),
                            Vs98 = readerUpdate["vs98"].ToString().Trim(' '),
                            V164 = readerUpdate["v164"].ToString().Trim(' '),
                            V165 = readerUpdate["v165"].ToString().Trim(' '),
                            Aw2 = readerUpdate["AW_2"].ToString().Trim(' '),
                            A325 = readerUpdate["A325"].ToString().Trim(' '),
                            A600 = readerUpdate["A600"].ToString().Trim(' '),
                            Vs97 = readerUpdate["vs97"].ToString().Trim(' '),
                            B010 = readerUpdate["B010"].ToString().Trim(' '),
                            B014 = readerUpdate["B014"].ToString().Trim(' '),
                            V166 = readerUpdate["v166"].ToString().Trim(' '),
                            V223 = readerUpdate["v223"].ToString().Trim(' '),
                            Vs96 = readerUpdate["vs96"].ToString().Trim(' '),
                            V167 = readerUpdate["v167"].ToString().Trim(' '),


                            DecB010 = ioB010,
                            DecB014 = ioB014,

                            Dece069 = readerUpdate["dece069"].ToString().Trim(' '),

                            E069 = readerUpdate["e069"].ToString().Trim(' '),
                            E070 = readerUpdate["e070"].ToString().Trim(' '),
                            E071 = readerUpdate["e071"].ToString().Trim(' '),
                            E072 = readerUpdate["e072"].ToString().Trim(' ')

                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        connection.Execute("spVsoftContracts_UpdateFull @Id, @A010, @Vs99, @Vs98, @V164, @V165, @Aw2, @A325, @A600, @Vs97, @B010, @B014, @V166, @V223, @Vs96, @V167, @DecB010, @DecB014, @Dece069, @E069, @E070, @E071, @E072, @VsoftCustomerId", contractsUpdate);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    readerUpdate.Close();

                    OleDbCommand command = new OleDbCommand("UPDATE Polissen SET dnnSync=True, dnnSyncAlready = True", cnnMarJet);
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
