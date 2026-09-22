#include "Raquet.h"
#include "Raquet_Studio.h"
#include <stdio.h>
#include <string.h>
#include <sys/stat.h>

Raquet_Event_Function RaquetStudio_GetEventFunction(int id) {
    return __Raquet_Event_Table[id];
}

void RaquetStudio_AnalyzeDataPack(const char* path) {
    FILE* stream = fopen(path, "r");
    if (stream == NULL) {
        printf("oops !\n");
        return; // ooouuuu shi
    }

    struct stat file_status;
    if (stat(path, &file_status) < 0) {
        return;
    }

    long filesize = file_status.st_size;
    char string[filesize];
    fgets(string, filesize, stream);

    /*printf("Successfully loaded Raquet Studio binary data!\n");
    printf("%s", string);
    printf("\n");*/

    if (filesize < 9) {
        return;
    }

    char header[9];
    strncpy(header, string, 9);

    if (strcmp(header, "RAQSTUDIO")) {
        printf("Bitch either your file is corrupted or this is NOT a raquet studio binary file.\n");
        return;
    }

    int bytecodeVersion = fgetc(stream);

    while (ftell(stream) < filsize) {
        char chunkID[3];
        fgets(chunkID, 3, stream);

        if (strcmp(chunkID, "ACT")) {
            
        }
    }

    fclose(stream);
}
