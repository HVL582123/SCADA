using AlarmViewer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlarmViewer.Pages
{
    public class AlarmsModel : PageModel
    {
        readonly IConfiguration _configuration;

        public List<Alarm> alarms = new List<Alarm>();
        public string connectionString;

        public AlarmsModel(IConfiguration configuration) {
            _configuration = configuration;
        }
        public void OnGet()
        {
            alarms = GetAlarmList();
        }
        
        public IActionResult OnPostAcknowledge(int alarmId)
        {
            alarms = GetAlarmList();
            //Assuming the AlarmId exists as it comes from a table
            Alarm alarm = alarms.FirstOrDefault(a => a.AlarmId == alarmId);

            if( alarm != null)
            {
                alarm.UpdateAlarm(_configuration.GetConnectionString("ConnectionString"), alarmId);

                return RedirectToPage();
            }

            return NotFound();
        }

        private List<Alarm> GetAlarmList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<Alarm> alarmList = new List<Alarm>();

            Alarm alarm = new Alarm();

            alarmList = alarm.GetAlarms(connectionString);

            return alarmList;
        }
    }
}
