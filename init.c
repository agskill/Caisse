#include <stdio.h>
#include <SDL/SDL.h>
#include <SDL/SDL_TTF.h>
#include "init.h"

int init_SDL(SDL_Surface** screen, SDL_Rect* resolution, TTF_Font **police)
{
    // Initialisation
    if (SDL_Init( SDL_INIT_VIDEO) < 0)
    {
        printf("Echec de l'initialisation de SDL: %s\n", SDL_GetError());
        return 0;
    }
    else if (TTF_Init() < 0)
    {
        SDL_Quit();
        printf("Echec de l'initialisation de SDL_TTF: %s\n", TTF_GetError());
        return 0;
    }
    else
    {
        atexit(SDL_Quit);
        atexit(TTF_Quit);
        SDL_WM_SetCaption("Caisse",NULL);
        //const SDL_VideoInfo* info = SDL_GetVideoInfo();   //<-- calls SDL_GetVideoInfo();
        resolution->x = 900;//(info->current_w * 0.7);
        resolution->y = 900;//(info->current_h * 0.9);

        *screen = SDL_SetVideoMode(resolution->x, resolution->y, 32,
                                               SDL_SWSURFACE|SDL_DOUBLEBUF);

        police[0] = TTF_OpenFont("micross.ttf", 20);
        police[1] = TTF_OpenFont("micross.ttf", 8);
        if (police[0] == NULL)
        {
            printf("Impossible d'ouvrir la police micross.ttf\n");
            SDL_Quit();
            TTF_Quit();
            return 0;
        }
        else if (*screen == 0)
        {
            printf("Unable to set %dx%d video: %s\n", resolution->x, resolution->y, SDL_GetError());
            SDL_Quit();
            TTF_Quit();
            return 0;
        }
        else
            return 1;
    }
}
