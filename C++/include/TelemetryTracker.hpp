#ifndef TELEMETRY_CHECKER_HPP
#define TELEMETRY_TRACKER_HPP

#include <string>

class TelemetryTracker {
private:
     std::string tankId;
     double currentVolume;
     double maxCapacity;

public:
     TelemetryTracker(const std::string& id, double current, double max);

double calculateFillPercentage() const;
std::string evaluateStatus() const;

std:: string getTankId() const;
void updateVolume(double newVolume);
};

#endif
