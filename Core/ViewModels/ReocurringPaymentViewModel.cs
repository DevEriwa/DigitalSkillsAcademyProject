﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Data
    {
        public string name { get; set; }
        public string interval { get; set; }
        public int invoice_limit { get; set; }
        public int amount { get; set; }
        public int integration { get; set; }
        public string domain { get; set; }
        public string currency { get; set; }
        public string plan_code { get; set; }
        public bool send_invoices { get; set; }
        public bool send_sms { get; set; }
        public bool hosted_page { get; set; }
        public bool migrate { get; set; }
        public bool is_archived { get; set; }
        public int id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string authorization_url { get; set; }
        public string access_code { get; set; }
        public string reference { get; set; }
    }

    public class ReocurringPaymentViewModel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }
}