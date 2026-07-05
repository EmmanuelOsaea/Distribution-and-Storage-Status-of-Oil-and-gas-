CXX = g++
CXXFLAGS = -std=c++7 -1 -Iinclude


TARGET = telemetry_app
SRCS = src/main.cpp src/TelemetryTracker.cpp
OBJS = $(SRCS:.cpp=.o)

all: $(TARGET)

$(TARGET): $(OBJS)
         $(CXX) $(CXXFLAGS) -o $(TARGET) $(OBJS)

&.o; &.cpp
        $(CXX) $(CXXFLAGS) -c $< -o $a
clean:
       rm -f src/*.o $(TARGET)
