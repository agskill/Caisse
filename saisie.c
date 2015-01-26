
#include <stdlib.h>
#include <stdio.h>
#include <SDL/SDL.h>
#include <SDL/SDL_ttf.h>
 

int main(int argc, char *argv[])

{
	int taille=40; // hauteur des boutons
	//initialisation SDL
	SDL_Init(SDL_INIT_VIDEO);
	TTF_Init();
	SDL_WM_SetCaption("Caisse",NULL);
	
	TTF_Font *police=NULL;
	
	police=
	
	SDL_Rect placepos, emporterpos,recettepos,quitterpos;
    SDL_Surface *ecran=NULL, *place=NULL, *emporter=NULL, *recette=NULL, *quitter=NULL;
	
	ecran=SDL_SetVideoMode(900,900,32,SDL_HWSURFACE|SDL_DOUBLEBUF);
	SDL_FillRect(ecran, NULL, SDL_MapRGB(ecran->format, 255, 255, 255));
	
	placepos.y=(900/2)-taille*2;
	emporterpos.y=(900/2)-taille;
	recettepos.y=900/2;
	quitterpos.y=(900/2)+taille;
	
    SDL_FillRect(place, NULL, SDL_MapRGB(ecran->format, 0, 0, 255));
	SDL_FillRect(emporter, NULL, SDL_MapRGB(ecran->format, 255, 255, 0));
	SDL_FillRect(recette, NULL, SDL_MapRGB(ecran->format, 255, 0, 0));
	SDL_FillRect(quitter, NULL, SDL_MapRGB(ecran->format, 255, 128, 0));
	
	SDL_BlitSurface(place, NULL, ecran, &placepos);
	SDL_BlitSurface(emporter, NULL, ecran, &emporterpos);
	SDL_BlitSurface(recette, NULL, ecran, &recettepos);
	SDL_BlitSurface(quitter, NULL, ecran, &quitterpos);
	
	
	
	
	
	SDL_Flip(ecran);
	
}