#include <stdlib.h>
#include "init.h"
#include "structures.h"
#include <SDL/SDL.h>
#include <SDL/SDL_TTF.h>

#define TAILLE_BOUTON 40

SDL_Rect resolution;

int main (int argc, char** argv)
{

    // create a new window
    SDL_Surface* screen = NULL;

    TTF_Font **police = malloc(2 * sizeof(TTF_Font*));

    if (init_SDL(&screen, &resolution, police))
    {
        // load an image
        SDL_Rect placepos = { .x = 0, .y = (900 / 2) - TAILLE_BOUTON * 2, .w = resolution.x, .h = TAILLE_BOUTON };
        SDL_Rect emporterpos = { .x = 0, .y = (900 / 2) - TAILLE_BOUTON, .w = resolution.x, .h = TAILLE_BOUTON };
        SDL_Rect recettepos = { .x = 0, .y = 900 / 2, .w = resolution.x, .h = TAILLE_BOUTON };
        SDL_Rect quitterpos = { .x = 0, .y = (900 / 2) + TAILLE_BOUTON, .w = resolution.x, .h = TAILLE_BOUTON };
        SDL_Surface* bmp = SDL_LoadBMP("cb.bmp");
        SDL_Surface *surface_place = SDL_CreateRGBSurface(SDL_HWSURFACE, 900, TAILLE_BOUTON, 32, 0, 0, 0, 0);
        SDL_Surface *surface_emporter = SDL_CreateRGBSurface(SDL_HWSURFACE, 900, TAILLE_BOUTON, 32, 0, 0, 0, 0);
        SDL_Surface *surface_recette = SDL_CreateRGBSurface(SDL_HWSURFACE, 900, TAILLE_BOUTON, 32, 0, 0, 0, 0);
        SDL_Surface *surface_quitter = SDL_CreateRGBSurface(SDL_HWSURFACE, 900, TAILLE_BOUTON, 32, 0, 0, 0, 0);
        SDL_FillRect(surface_place, NULL, SDL_MapRGB(screen->format, 0, 0, 255));
        SDL_FillRect(surface_emporter, NULL, SDL_MapRGB(screen->format, 255, 255, 0));
        SDL_FillRect(surface_recette, NULL, SDL_MapRGB(screen->format, 255, 0, 0));
        SDL_FillRect(surface_quitter, NULL, SDL_MapRGB(screen->format, 255, 128, 0));


        if (bmp == NULL)
        {
            printf("Unable to load bitmap: %s\n", SDL_GetError());
            return 1;
        }
        // centre the bitmap on screen
        SDL_Rect dstrect;
        dstrect.x = (screen->w - bmp->w) / 2;
        dstrect.y = (screen->h - bmp->h) / 2;

        enum e_menu menu = m_principal;
        while (menu != m_quitter)
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
                        menu = m_quitter;
                        break;

                    // check for keypresses
                    case SDL_KEYDOWN:
                    {
                        // exit if ESCAPE is pressed
                        if (event.key.keysym.sym == SDLK_ESCAPE)
                            menu = m_quitter;
                        break;
                    }
                    case SDL_MOUSEBUTTONDOWN:
                        if (event.button.x >= quitterpos.x &&
                            event.button.x <= quitterpos.x + quitterpos.w &&
                            event.button.y >= quitterpos.y &&
                            event.button.y <= quitterpos.y + quitterpos.h)
                            menu = m_quitter;
                        if (event.button.x >= placepos.x &&
                            event.button.x <= placepos.x + placepos.w &&
                            event.button.y >= placepos.y &&
                            event.button.y <= placepos.y + placepos.h)
                            menu = m_produits;
                        break;

                } // end switch
            } // end of message processing

            // DRAWING STARTS HERE

            // clear screen
            SDL_FillRect(screen, 0, SDL_MapRGB(screen->format, 200, 200, 200));
            if (menu == m_principal)
            {
                SDL_BlitSurface(surface_place, NULL, screen, &placepos);
                SDL_BlitSurface(surface_emporter, NULL, screen, &emporterpos);
                SDL_BlitSurface(surface_recette, NULL, screen, &recettepos);
                SDL_BlitSurface(surface_quitter, NULL, screen, &quitterpos);
            }

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
