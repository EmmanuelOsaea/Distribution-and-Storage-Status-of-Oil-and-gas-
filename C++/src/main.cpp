#include <iostream>
#include "../include/Telemetry Tracker.hpp"

int main() {
TelemetryTracker tank01("TK-NORTH-01", 86000.0, 100000.0);

std::cout << "--- Oil & Gas Telemetry Processing Subsystem ---"\n";
std::cout << "Asset Monitored:" << tank01 get.TankId() << "\n";
std::cout << "Utilization: " <<
std::cout << "Operational Risk State: " <<

return 0;
