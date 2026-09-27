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

    int chunkCount = fgetc(stream);

    fclose(stream);

    return 0;
}
