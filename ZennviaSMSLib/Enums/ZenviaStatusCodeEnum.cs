using System;
using System.Collections.Generic;
using System.Text;

namespace ZennviaSMSLib.Enums
{
	public enum ZenviaStatusCodeEnum
	{
		Ok = 00,
		Scheduled = 01,
		Sent = 02,
		Delivered = 03,
		Not_Received = 04,
		Blocked_No_Coverage = 05,
		Blocked_Black_listed = 06,
		Blocked_Invalid_Number = 07,
		Blocked_Content_not_allowed = 08,
		Blocked_Message_Expired = 08,
		Blocked = 09,
		Error = 10
	}
}
