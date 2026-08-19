using System;
using System.Collections.Generic;
using System.Text;

namespace Session5_OOP
{
    internal abstract class Shipment
    {
        private string trackingCode = "";
        private string description = "";
        private decimal weight;
        private decimal deliveryFee;

        public static int TotalShipmentsCreated = 0;

        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }


        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }


        public DeliveryAddress Destination { get; set; }

        public abstract decimal EstimatedCost { get; }

        public Shipment(string code)
        {
            TrackingCode = code;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
        }

      
        public Shipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress destination)
        {
            TrackingCode = code;
            Description = desc;
            Weight = weight;
            DeliveryFee = fee;
            Destination = destination;

            TotalShipmentsCreated++;
        }



        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight > 0)
            {
                Weight = newWeight + packingWeight;
            }
        }

        public abstract void PrintShipment();

        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(Destination.City,Destination.Street,Destination.BuildingNumber);

            return copy;
        }

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("static initialization has happened");
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;

        }

    }
}
