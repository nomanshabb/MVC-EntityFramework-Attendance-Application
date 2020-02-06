using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AttendanceApp.Models
{
	public class Attendance
	{
		public int ID { get; set; }

		public DateTime ComingTime { get; set; }


		[DisplayName("Date")]
		public DateTime DateOfDay { get; set; }

		public DateTime? LeaveTime { get; set; }

		public int EmployeeID { get; set; }
		[NotMapped]
		public string TotalTime
		{
			get 
			{

				if (LeaveTime != null)
				{
					TimeSpan time;
					time = LeaveTime.Value - ComingTime;
					return new DateTime(time.Ticks).ToString("HH:mm:ss");
				}
				else return "";
					
				
			}
			set { }
		}



		//public virtual Employee employee { get; set; }

	}
}