using System;
using System.Collections.Generic;
using System.Text;

namespace Session5_OOP
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string type;

            if (shipment is StandardShipment)
            {
                type = "StandardShipment";
            }
            else if (shipment is ExpressShipment)
            {
                type = "ExpressShipment";
            }
            else if (shipment is InternationalShipment)
            {
                type = "InternationalShipment";
            }
            else
            {
                type = "Invalid";
            }

            return $"{shipment.TrackingCode} | {type} | {shipment.Weight} | {shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            string status = shipment.GetTrackingStatus();

            if (status == "Delivered")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
