using System;
using System.Collections.Generic;
using System.Text;

namespace Session5_OOP
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress destination)

       : base(code, desc, weight, fee, destination)
        {
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }


        public string GetTrackingStatus()
        {
            return $"Shipment: {TrackingCode} is Ready";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }


    }
}
