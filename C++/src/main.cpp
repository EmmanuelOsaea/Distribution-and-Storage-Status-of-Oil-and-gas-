#include <iostream>
#include "../include/TelemetryTracker.hpp"

int main() {
TelemetryTracker tank01("TK-NORTH-01", 86000.0, 100000.0);

std::cout << "--- Oil & Gas Telemetry Processing Subsystem ---\n";
std::cout << "Asset Monitored: " << tank01.getTankId() << "\n";
std::cout << "Utilization: " << tank01.calculateFillPercentage() << "%\n">
std::cout << "Operational Risk State: " << tank01.evaluateStatus()  << "\n">
  
return 0;
}
