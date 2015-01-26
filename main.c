#ifdef __cplusplus
    #include <cstdlib>
#else
    #include <stdlib.h>
#endif

#include <SDL/SDL.h>

int screenW;
int screenH;

struct product
{
    double prix;
    SDL_Surface* picture;
};

enum e_menu
{
    quitter = 0,
    principal = 1
};

int init_SDL(SDL_Surface** screen)
{
    // initialize SDL video
    if ( SDL_Init( SDL_INIT_VIDEO ) < 0 )
    {
        printf( "Unable to init SDL: %s\n", SDL_GetError() );
        return 0;
    }

    // make sure SDL cleans up before exit
    atexit(SDL_Quit);

    const SDL_VideoInfo* info = SDL_GetVideoInfo();   //<-- calls SDL_GetVideoInfo();
    screenW = (info->current_w * 0.7);
    screenH = (info->current_h * 0.9);

    fprintf(stderr, "=> %d\n=> %d\n", screenW, screenH);

    *screen = SDL_SetVideoMode(screenW, screenH, 32,
                                           SDL_SWSURFACE|SDL_DOUBLEBUF);

    if (*screen == 0)
    {
        printf("Unable to set %dx%d video: %s\n", screenW, screenH, SDL_GetError());
        return 0;
    }
    return 1;
}

int main ( int argc, char** argv )
{

    // create a new window
    SDL_Surface* screen = NULL;

    if (init_SDL(&screen))
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
        printf("aaa");
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
        return 0;
    }
    else
        return 1;
}
