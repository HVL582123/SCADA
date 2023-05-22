using System.Data;
using System.Data.SqlClient;

namespace AlarmViewer.Models
{
    public class Alarm
    {
        public int AlarmId { get; set; }
        public string TagName { get; set; }
        public DateTime ActivationTime { get; set; }
        public int Acknowledged { get; set; }
        public string AlarmType { get; set; }
        public DateTime? AcknowledgeTime { get; set; }  //Nullable object
        public int Priority { get; set; }
        public string Description { get; set; }

        public List<Alarm> GetAlarms(string connectionString) {
            List<Alarm> alarmList = new List<Alarm>();

            SqlConnection connection = new SqlConnection(connectionString);

            //Get data from the View in the SQL DB
            string selectSQL = "select * from AlarmView";

            connection.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, connection);

            SqlDataReader dr = cmd.ExecuteReader();

            if( dr != null)
            {
                while(dr.Read())
                {
                    Alarm alarm = new Alarm();

                    alarm.AlarmId = Convert.ToInt32(dr["AlarmId"]);
                    alarm.TagName = dr["Tagname"].ToString();
                    alarm.AlarmType = dr["AlarmType"].ToString();
                    alarm.ActivationTime = Convert.ToDateTime(dr["ActivationTime"]);

                    if (dr["AcknowledgeTime"] != DBNull.Value)
                    {
                        alarm.AcknowledgeTime = Convert.ToDateTime(dr["AcknowledgeTime"]);
                    }
                    else
                    {
                        alarm.AcknowledgeTime = null;
                    }

                    alarmList.Add(alarm);
                }
            }
            return alarmList;
        }

        public void CreateAlarm(string connectionString, Alarm alarm) {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreateAlarm", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@TagName", alarm.TagName));
                    cmd.Parameters.Add(new SqlParameter("@ActivationTime", alarm.ActivationTime));
                    cmd.Parameters.Add(new SqlParameter("@AlarmType", alarm.AlarmType));
                    cmd.Parameters.Add(new SqlParameter("@Priority", alarm.Priority));
                    cmd.Parameters.Add(new SqlParameter("@Description", alarm.Description));
                
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //Set the alarm to acknowledged
        public void UpdateAlarm(string connectionString, int AlarmId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateAlarm", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@AlarmId", AlarmId));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
