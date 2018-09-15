using System;
using System.Data.SqlClient;



namespace HomeWork.Task01
{
    class TestOnUbuntu
    {

        public static void ConnDB()
        {
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GTDP7CC;Initial Catalog=QuanLyDeAn;Integrated Security=True");


            try
            {
                Console.WriteLine("Openning Connection...");
                conn.Open();
                string sql = "select * from NHANVIEN";
                SqlCommand command = new SqlCommand(sql, conn);
                

                GetAllStaff(conn);




                Console.WriteLine("Connection successfull");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }


            Console.ReadKey();
        }
        public static void GetAllStaff(SqlConnection conn)
        {
            string sql = "select * from NHANVIEN";

            


            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();




            if (dataReader.HasRows)
            {
                int i = 0;
                while (dataReader.Read())
                {
                    i++;
                    string codeStaff = dataReader.GetString(0);
                    Console.WriteLine("code {0}: " + codeStaff, i);


                }
            }
        }
        public static void ConnectDB()
        {
            
            
            using (SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.101,1433;Initial Catalog=QuanLyDeAn;Integrated Security=True"))
            {
                
                
                
                try
                {
                    connection.Open();
                    string sql = "select HONV,TENNV from NHANVIEN";
                    SqlCommand command = new SqlCommand(sql, connection);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader()) {
                        int i = 0;
                        while (sqlDataReader.Read())
                        {
                            i++;
                            string honv = sqlDataReader.GetString(0);
                            string tennv = sqlDataReader.GetString(1);
                            Console.WriteLine("{0} | {1} | {2}", i, honv, tennv);


                        }
                        sqlDataReader.Close();
                    } 

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error :" + ex.Message);
                }
                finally
                {

                    
                     connection.Close();

                    
                }
                

            }
            Console.WriteLine("end connect ...");

        }


    }
}
