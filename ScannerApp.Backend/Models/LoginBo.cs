using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LoginBo : BaseBo
    {
        public string status { get; set; }
        public string token { get; set; }
        public string message { get; set; }
        public object client_name { get; set; }
        public Employee employee { get; set; }
        public int this_cashier { get; set; }
        public int all_cashier { get; set; }
        public string event_name { get; set; }
        public int event_id { get; set; }
        public int cashin_id { get; set; }
        public int last_cashin_id { get; set; }
        public object last_cashin { get; set; }
        public object cashin { get; set; }
        public Printer[] printers { get; set; }
        public object[] synced_ids { get; set; }
        public int sales_last_id { get; set; }
        public int tickets_last_id { get; set; }
    }

    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int role { get; set; }
        public string username { get; set; }
        public string pin { get; set; }
        public string available_job_codes { get; set; }
        public string available_pay_rates { get; set; }
        public int print_receipts_cash { get; set; }
        public int print_receipts_credit { get; set; }
        public object last_login { get; set; }
        public string date_added { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object deleted_at { get; set; }
        public Privilege privilege { get; set; }
    }

    public class Privilege
    {
        public int id { get; set; }
        public string name { get; set; }
        public int access_portal { get; set; }
        public int manage_employees { get; set; }
        public int manage_messages { get; set; }
        public int manage_addresses { get; set; }
        public int manage_tasks { get; set; }
        public int manage_cashins { get; set; }
        public int manage_web { get; set; }
        public int manage_pos { get; set; }
        public int manage_tickets { get; set; }
        public int manage_restaurant { get; set; }
        public int manage_timeclock { get; set; }
        public int manage_mobile_app { get; set; }
        public int manage_print_settings { get; set; }
        public int view_reports { get; set; }
        public int view_ticket_reports { get; set; }
        public int view_restaurant_reports { get; set; }
        public int view_employee_reports { get; set; }
        public int view_request_center { get; set; }
        public int send_messages { get; set; }
        public int send_replies { get; set; }
        public string employee_id { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public object deleted_at { get; set; }
    }

    public class Printer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string js_print_command { get; set; }
        public int is_black { get; set; }
        public int is_red { get; set; }
        public string font_size { get; set; }
        public int is_default_printer { get; set; }
        public string top_of_receipt_text { get; set; }
        public string bottom_of_receipt_text { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object deleted_at { get; set; }
    }
}
