#include "pch.h"
#include <queue>
#include <string>
#include <mutex>

std::queue<std::string> queue;
std::mutex mutex;

extern "C" {
    __declspec(dllexport) void enqueue(const char* message) {
        std::lock_guard<std::mutex> lock(mutex);
        queue.push(std::string(message));
    }

    __declspec(dllexport) char* dequeue() {
        std::lock_guard<std::mutex> lock(mutex);
        if (!queue.empty()) {
            auto message = queue.front();
            queue.pop();
            char* cstr = new char[message.length() + 1];
            strcpy_s(cstr, message.length() + 1, message.c_str());
            return cstr;
        }
        return nullptr;
    }

    __declspec(dllexport) void free_memory(char* ptr) {
        delete[] ptr;
    }
}
