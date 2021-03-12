using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace esame_week7
{
    public class connectio
    {
        //stringa per la connessione al db, db: POLIZIA
        const string connectionString = @"Persist Security Info = False; Integrated Security = true; Initial Catalog = NonEsiste; Server = .\SQLEXPRESS";

        public static void Provadb()
        {
            //utilizzo la modilità connessa per stampare la tabella Agente_Di_Polizia nel db POLIZIA
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //apro la connessione
                    connection.Open();
                }
                catch (SqlException exc) when (exc.Class > 19) //>19 fatale
                {
                    Console.WriteLine("Generata eccezione fatale");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("errore nella connessione del data base: " + ex.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Si è verificato un errore generico: " + e.Message);
                }
                finally
                {
                    //chiudo la connesione
                    connection.Close();
                }

            }
        }

        //Metodo per utilizzare l'eccezione custom
        public static void EccezioneCustomEs(string personaNome)
        {
            try
            {
                if (personaNome == null)
                {
                    throw new CustomExcepetion("Utente non trovato");
                }
            }
            catch (CustomExcepetion exc)
            {
                Console.WriteLine("Eccezione custom generata");
            }
            catch
            {
                Console.WriteLine("Altra eccezione trovata");
            }

        }
    }
