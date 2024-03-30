#include <map>
#include <queue>
#include <string>
#include <mutex>

std::map<std::string, std::queue<std::string>> queues;
std::mutex mutex;

extern "C" {
    void enqueue(const char* queueName, const char* message) {
        std::lock_guard<std::mutex> lock(mutex);
        queues[queueName].push(std::string(message));
    }

    const char* dequeue(const char* queueName) {
        static std::string message;
        {
            std::lock_guard<std::mutex> lock(mutex);
            if (queues.find(queueName) != queues.end() && !queues[queueName].empty()) {
                message = queues[queueName].front();
                queues[queueName].pop();
            }
            else {
                message.clear();
            }
        }
        return message.empty() ? nullptr : message.c_str();
    }
}
