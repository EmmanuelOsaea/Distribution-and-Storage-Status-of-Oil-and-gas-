#include ".../include/TelemtryTracker.hpp"
Telemetry tracker::Telemetry tracker(std::string id, double current, double max)
     :tankId(id), currentVolume(current), maxCapacity(max) {}

double TelemetryTracker::calculateFillPercentage() const {
  if (maxCapacity <= 0) return 0.0;
return (currentVolume / maxCapacity * 100.0;
}

std::string TelemetryTracker::evaluateStatus() cons {
     double percentage = calculateFillPercentage();



void TelemetryTracker: updateVolume(double newVolume) {
if (newVolume >= 0 && newVolume <= maxCapacity) {
currentVolume = newVolume;
}
}
