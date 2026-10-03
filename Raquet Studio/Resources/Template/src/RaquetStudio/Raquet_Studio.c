#include "Raquet.h"
#include "Raquet_Studio.h"
#include <stdio.h>
#include <string.h>
#include <sys/types.h>
#include <sys/stat.h>

Raquet_Event_Function RaquetStudio_GetEventFunction(int id) {
    return __Raquet_Event_Table[id];
}

int RaquetStudio_AnalyzeDataPack(const char* path) {
    FILE* stream = fopen(path, "r");
    if (stream == NULL) {
        printf("oops !\n");
        fclose(stream);
        return -1; // ooouuuu shi
    }

    struct _stat file_status;
    if (_stat(path, &file_status) < 0) {
        fclose(stream);
        return -1;
    }

    long filesize = file_status.st_size;
    char header[10];
    const char* actualHeader = "RAQSTUDIO";
    fgets(header, 10, stream);

    for (int i = 0; i < 10; i++) {
        char a = header[i];
        char b = actualHeader[i];

        if (a != b) {
            printf("%c does not match %c lowkey lowkey\n", a, b);
            fclose(stream);
            return -1;
        }
    }

    int bytecodeVersion = fgetc(stream);

    printf("%s", header);
    printf("\n");
    printf("Bytecode version is %d", bytecodeVersion);
    printf("\n");

    int actorCount = fgetc(stream);
    int actorIndex = 0;
    while (actorIndex < actorCount) {
        
        //yes this code is just BinaryReader.Read7BitEncodedInt from .NET
        int earlyExit = 0;
        int finalInteger = 0;
        unsigned int result = 0;
        int8_t byteReadJustNow;
        const int MaxBytesWithoutOverflow = 4; 
        for (int shift = 0; shift < MaxBytesWithoutOverflow * 7; shift += 7) {
            byteReadJustNow = fgetc(stream);
            result |= (byteReadJustNow & 0x7Fu) << shift;

            if ((unsigned int)byteReadJustNow <= 0x7Fu) {
                earlyExit = 1;
                finalInteger = (int)result;
            }
        }
        if (earlyExit == 0) {
            byteReadJustNow = fgetc(stream);
            if (byteReadJustNow > 0b1111u) {
                printf("hey your fucking raquet studio binary file is corrupted as shit LMAOOO sucks to be you");
                fclose(stream);
                return -1;
            }
            result |= (unsigned int)byteReadJustNow << (MaxBytesWithoutOverflow * 7);
            finalInteger = (int)result;
        }

        char actorName[finalInteger];
        fgets(actorName, finalInteger, stream);

        printf("%s", actorName);

        actorIndex++;
    }
    fclose(stream);

    return 0;
}