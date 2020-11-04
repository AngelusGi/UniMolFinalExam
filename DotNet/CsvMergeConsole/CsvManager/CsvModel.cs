using CsvHelper.Configuration.Attributes;

namespace CsvManager
{
    /// <summary>
    /// classe come modello per le entità presenti nel file
    /// </summary>

    internal class CsvModel
    {
        [Name("GPS Time")]
        public string GpsTime { get; set; }

        [Name("Device Time")]
        public string DeviceTime { get; set; }

        public string Longitude { get; set; }
        public string Latitude { get; set; }

        [Name("GPS Speed (Meters/second)")]
        public string GPSSpeedMps { get; set; }

        public string Altitude { get; set; }

        [Name("G(x)")]
        public string Gx { get; set; }

        [Name("G(y)")]
        public string Gy { get; set; }

        [Name("G(z)")]
        public string Gz { get; set; }

        [Name("Kilometers Per Litre(Instant)(kpl)")]
        public string KmPerLiterInstant { get; set; }

        [Name("Litres Per 100 Kilometer(Instant)(l/100km)")]
        public string LitersPer100Km { get; set; }

        [Name("Actual engine % torque(%)")]
        public string EngineTorque { get; set; }

        [Name("Trip Distance(km)")]
        public string TripDistanceKm { get; set; }

        [Name("Engine RPM(rpm)")]
        public string EngineRpm { get; set; }

        [Name("GPS Accuracy(m)")]
        public string GpsAccuracy { get; set; }

        [Name("GPS Altitude(m)")]
        public string GpsAltitude { get; set; }

        [Name("GPS Latitude(°)")]
        public string GpsLatitude { get; set; }

        [Name("GPS Longitude(°)")]
        public string GpsLongitude { get; set; }

        [Name("Acceleration Sensor(X axis)(g)")]
        public string AccelerationSensorX { get; set; }

        [Name("Acceleration Sensor(Y axis)(g)")]
        public string AccelerationSensorY { get; set; }

        [Name("Acceleration Sensor(Z axis)(g)")]
        public string AccelerationSensorZ { get; set; }

        [Name("Acceleration Sensor(Total)(g)")]
        public string AccelerationSensorTotal { get; set; }

        [Name("Run time since engine start(s)")]
        public string RuntimeStart { get; set; }
    }

}
