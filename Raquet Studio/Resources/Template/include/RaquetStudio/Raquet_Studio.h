#ifndef RAQUET_STUDIO
#define RAQUET_STUDIO

#include "Raquet_Studio_EventsAutogen.h"

Raquet_Event_Function RaquetStudio_GetEventFunction(int id);

int RaquetStudio_AnalyzeDataPack(const char* path);

/*typedef struct RaquetStudio_DynamicBuffer {
    char * content;
    size_t capacity;
} RaquetStudio_DynamicBuffer;

typedef struct RaquetStudio_SerializedActor {
    RaquetStudio_DynamicBuffer name;
    char * binaryData;
} RaquetStudio_SerializedActor;

void RaquetStudio_AllocateBuffer(RaquetStudio_DynamicBuffer * buffer, size_t size) {
    buffer->capacity = size;
    buffer->content = malloc(size * sizeof(buffer->content));
}

void RaquetStudio_ResizeBuffer(RaquetStudio_DynamicBuffer * buffer) {

}*/

#endif
