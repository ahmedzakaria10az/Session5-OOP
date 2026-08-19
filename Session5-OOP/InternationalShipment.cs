using System;
using System.Collections.Generic;
using System.Text;

namespace Session5_OOP
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

        public InternationalShipment(string code, string desc, decimal weight, decimal fee, string destinationCountry, decimal customsFee, DeliveryAddress destination)
       : base(code, desc, weight, fee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("GenerateCustomsReport");
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }


        public string GetTrackingStatus()
        {
            return $"Shipment: {TrackingCode} has been Delivered";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}
