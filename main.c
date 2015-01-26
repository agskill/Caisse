#include <stdlib.h>
#include "init.h"

#include <SDL/SDL.h>
#include <SDL/SDL_TTF.h>

SDL_Rect resolution;

enum e_menu
{
    quitter = 0,
    principal = 1,
};


int main (int argc, char** argv)
{

    // create a new window
    SDL_Surface* screen = NULL;

    TTF_Font **police = malloc(2 * sizeof(TTF_Font*));

    if (init_SDL(&screen, &resolution, police))
    {
        // load an image
        SDL_Surface* bmp = SDL_LoadBMP("cb.bmp");

        if (bmp == NULL)
        {
            printf("Unable to load bitmap: %s\n", SDL_GetError());
            return 1;
        }
        // centre the bitmap on screen
        SDL_Rect dstrect;
        dstrect.x = (screen->w - bmp->w) / 2;
        dstrect.y = (screen->h - bmp->h) / 2;

        enum e_menu menu = principal;
        while (menu != quitter)
        {
            // message processing loop
            SDL_Event event;
            while (SDL_PollEvent(&event))
            {
                // check for messages
                switch (event.type)
                {
                    // exit if the window is closed
                    case SDL_QUIT:
                        menu = quitter;
                        break;

                    // check for keypresses
                    case SDL_KEYDOWN:
                    {
                        // exit if ESCAPE is pressed
                        if (event.key.keysym.sym == SDLK_ESCAPE)
                            menu = quitter;
                        break;
                    }
                    case SDL_MOUSEBUTTONDOWN:
                        if (event.button.x < 1)
                            exit(1);
                        break;

                } // end switch
            } // end of message processing

            // DRAWING STARTS HERE

            // clear screen
            SDL_FillRect(screen, 0, SDL_MapRGB(screen->format, 0, 0, 0));

            // draw bitmap
            SDL_BlitSurface(bmp, 0, screen, &dstrect);

            // DRAWING ENDS HERE

            // finally, update the screen :)
            SDL_Flip(screen);
        }
        free(police);
        return 0;
    }
    else
    {
        free(police);
        return 1;
    }
}
