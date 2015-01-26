#include <stdio.h>
#include <SDL/SDL.h>
#include <SDL/SDL_TTF.h>
#include "init.h"

int init_SDL(SDL_Surface** screen, SDL_Rect* resolution)
{
    // initialize SDL video
    if (SDL_Init( SDL_INIT_VIDEO) < 0 )
    {
        printf( "Unable to init SDL: %s\n", SDL_GetError() );
        return 0;
    }
    if(TTF_Init() < 0)
    {
        printf("Erreur d'initialisation de TTF_Init : %s\n", TTF_GetError());
        return 0;
    }

    // make sure SDL cleans up before exit
    atexit(SDL_Quit);

    const SDL_VideoInfo* info = SDL_GetVideoInfo();   //<-- calls SDL_GetVideoInfo();
    resolution->x = (info->current_w * 0.7);
    resolution->y = (info->current_h * 0.9);

    printf("=> %d\n=> %d\n", resolution->x, resolution->y);

    *screen = SDL_SetVideoMode(resolution->x, resolution->y, 32,
                                           SDL_SWSURFACE|SDL_DOUBLEBUF);

    if (*screen == 0)
    {
        printf("Unable to set %dx%d video: %s\n", resolution->x, resolution->y, SDL_GetError());
        SDL_Quit();
        return 0;
    }
    return 1;
}
