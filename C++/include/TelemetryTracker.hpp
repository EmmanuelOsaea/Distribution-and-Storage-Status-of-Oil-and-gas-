#ifndef TELEMETRY CHECKER HPP
#define TELEMETRY TRACKER HPP

#include <string>

class TelemetryTracker {
private:
     std::string tankId;
     double current volume;
     double maxCapacity;

public:
     TelemetryTracker(std:: string id, double current, double max);
double calculateFillPercentage() const;
std:: string evaluateStatus const;

std:: string getTankId() const;
void updateVolume(double newVolume);
};

#endif
