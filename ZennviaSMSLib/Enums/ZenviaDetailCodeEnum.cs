using System;
using System.Collections.Generic;
using System.Text;

namespace ZennviaSMSLib.Enums
{
	public enum ZenviaDetailCodeEnum
	{
		Message_Sent = 000,
		Message_successfully_canceled = 002,
		Empty_message_content = 010,
		Message_body_invalid = 011,
		Message_content_overflow = 012,
		Incorrect_or_incomplete_to_mobile_number = 013,
		Empty_to_mobile_number = 014,
		Scheduling_date_invalid_or_incorrect = 015,
		ID_overflow = 016,
		Parameter_url_is_invalid_or_incorrect = 017,
		Field_from_invalid = 018,
		id_fieldismandatory = 021,
		Message_with_same_ID_already_sent = 080,
		Message_Queued = 100,
		Message_sent_to_operator = 110,
		Message_confirmation_unavailable = 111,
		Message_received_by_mobile = 120,
		Message_blocked = 130,
		Message_blocked_by_predictive_cleansing = 131,
		Message_already_canceled = 132,
		Message_content_in_analysis = 133,
		Message_blocked_by_forbidden_content = 134,
		Aggregate_is_Invalid_or_Inactive = 135,
		Message_expired = 136,
		Mobile_number_not_covered = 140,
		International_sending_not_allowed = 141,
		Inactive_mobile_number = 145,
		Message_expired_in_operator = 150,
		Operator_network_error = 160,
		Message_rejected_by_operator = 161,
		Message_cancelled_or_blocked_by_operator = 162,
		Bad_message = 170,
		Bad_number = 171,
		Missing_parameter = 172,
		Message_ID_notfound = 180,
		Unknown_error = 190,
		Messages_Sent = 200,
		Messages_scheduled_but_Account_Limit_Reached = 210,
		File_empty_or_not_sent = 240,
		File_too_large = 241,
		File_readerror = 242,
		Received_messages_found = 300,
		No_received_messages_found = 301,
		Entity_saved = 400,
		Authentication_error = 900,
		Account_type_not_support_this_operation = 901,
		Account_Limit_Reached_Please_contact_support = 990,
		Wrong_operation_requested = 998,
		Unknown_Error = 999
	}
}
