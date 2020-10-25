import urllib.request
import pandas as pd
import geopandas
import geopy
from geopy.geocoders import Nominatim
import os


def clean_header(file_to_process):
    df = pd.read_csv(file_to_process)
    keeps_only_latidue_longitude = ['GPS Time', 'Device Time', 'GPS Speed (Meters/second)', 'Horizontal Dilution of Precision', 'Altitude', 'Bearing', 'G(x)', 'G(y)', 'G(z)', 'G(calibrated)', 'Timing Advance(°)', 'Fuel Remaining (Calculated from vehicle profile)(%)', 'Engine Load(%)', 'Engine Load(Absolute)(%)', 'Kilometers Per Litre(Instant)(kpl)', 'Kilometers Per Litre(Long Term Average)(kpl)', 'Litres Per 100 Kilometer(Instant)(l/100km)', 'Litres Per 100 Kilometer(Long Term Average)(l/100km)', 'Trip average KPL(kpl)', 'Trip average Litres/100 KM(l/100km)', 'Distance to empty (Estimated)(km)', 'Fuel used (trip)(l)', 'Turbo Pressure Control(psi)', 'Actual engine % torque(%)', 'Drivers demand engine % torque(%)', 'Engine reference torque(Nm)', 'Fuel cost (trip)(cost)', 'CO₂ in g/km (Instantaneous)(g/km)', 'CO₂ in g/km (Average)(g/km)', 'GPS vs OBD Speed difference(km/h)', 'Trip Distance(km)', 'Trip distance (stored in vehicle profile)(km)', 'Distance travelled with MIL/CEL lit(km)', 'Distance travelled since codes cleared(km)', 'Volumetric Efficiency (Calculated)(%)', 'EGR Commanded(%)', 'EGR Error(%)', 'Fuel Rate (direct from ECU)(L/m)', 'Fuel flow rate/minute(cc/min)', 'Fuel flow rate/hour(l/hr)', 'Engine RPM(rpm)', 'GPS Accuracy(m)', 'GPS Altitude(m)', 'GPS Latitude(°)', 'GPS Longitude(°)', 'GPS Bearing(°)', 'GPS Satellites', 'Fuel Level (From Engine ECU)(%)', 'NOx Post SCR(ppm)', 'NOx Pre SCR(ppm)', 'O2 Sensor1 Equivalence Ratio', 'O2 Sensor1 Equivalence Ratio(alternate)', 'O2 Sensor2 Equivalence Ratio', 'O2 Sensor3 Equivalence Ratio', 'O2 Sensor4 Equivalence Ratio', 'O2 Sensor5 Equivalence Ratio', 'O2 Sensor6 Equivalence Ratio', 'O2 Sensor7 Equivalence Ratio', 'O2 Sensor8 Equivalence Ratio', 'O2 Volts Bank 1 sensor 1(V)', 'O2 Volts Bank 1 sensor 2(V)', 'O2 Volts Bank 1 sensor 3(V)', 'O2 Volts Bank 1 sensor 4(V)', 'O2 Volts Bank 2 sensor 1(V)', 'O2 Volts Bank 2 sensor 2(V)', 'Percentage of Idle driving(%)', 'Percentage of Highway driving(%)', 'Percentage of City driving(%)', 'Throttle Position(Manifold)(%)', 'Absolute Throttle Position B(%)', 'Relative Throttle Position(%)', 'Relative Accelerator Pedal Position(%)', 'Fuel pressure(psi)', 'Intake Manifold Pressure(psi)', 'Fuel Rail Pressure(psi)', 'Exhaust Pressure(psi)', 'Turbo Boost & Vacuum Gauge(psi)', 'Evap System Vapour Pressure(Pa)', 'Air Fuel Ratio(Commanded)(:1)', 'Air Fuel Ratio(Measured)(:1)', 'Commanded Equivalence Ratio(lambda)', 'Torque(Nm)', 'Engine kW (At the wheels)(kW)', 'Acceleration Sensor(X axis)(g)', 'Acceleration Sensor(Y axis)(g)', 'Acceleration Sensor(Z axis)(g)', 'Acceleration Sensor(Total)(g)', 'Run time since engine start(s)', 'Trip time(whilst moving)(s)', 'Voltage (OBD Adapter)(V)', 'Speed (GPS)(km/h)', 'Speed (OBD)(km/h)', 'Average trip speed(whilst stopped or moving)(km/h)', 'Average trip speed(whilst moving only)(km/h)']
    gps_long_lat = df.drop(columns=keeps_only_latidue_longitude)
    return gps_long_lat

def add_csv_to_df(file_to_process):
    return pd.read_csv(file_to_process)

drivers = ["Angelo", "Aniceto"]

for driver in drivers:
    absolute_path = "C:\\Users\\angel\\GitHub\\UniMolFinalExam\\Dataset\\Prepared_CSV"
    csv_root = absolute_path + "\\" + driver
    coordinates_data = dict()
    full_data = dict()

    for directory, subdir_list, file_list in os.walk(csv_root):
        for file_name in file_list:
            print('File:', file_name)
            path_to_read_csv = csv_root + "\\" + file_name
            print(path_to_read_csv)

            temp_dataframe = clean_header(path_to_read_csv)
            temp_file_name_ext = file_name.replace('.csv','')
            final_file_name = temp_file_name_ext.replace('trackLog-','')
            coordinates_data[final_file_name] = temp_dataframe

            full_data[final_file_name] = add_csv_to_df(path_to_read_csv)
            print()
        print()


print("###############################################")

print(coordinates_data)

print("###############################################")

print(full_data)

print("###############################################")
