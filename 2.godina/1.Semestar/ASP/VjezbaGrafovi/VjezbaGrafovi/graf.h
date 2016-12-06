#pragma once
#include <iostream>

using namespace std;

struct cvor  //cvor ili vrh grafa
{
	char *podatak;
	int status; //da li je vec obidjen
	struct veza *susjedi;  //pokazivac na listu susjedstva
	struct cvor *sljedeci; //pokazivac na sljedeci cvor
};

struct veza  //veza dva cvora, element liste susjednih cvorova
{
	struct cvor *susjed; //pokazivac na susjedni cvor
	struct veza *sljedeca; //pokazivac na sljedecu vezu
};

class graf
{
	cvor *start; //pokazivac na startni cvor u listi
	cvor *vrati_cvor(char *podatak) const; //vraca pokazivac na cvor od trazenog podatka
	void reinicijaliziraj(); //vrati statuse cvorova na 0
public:
	void dodaj_cvor(char *podatak); //dodavanje novog cvora
	void dodaj_vezu(char *podatak1, char *podatak2, int tip); //dodavanje nove veze (1-jedan smjer, 2-oba smjera)
	void bfs(); //Breadth First Search (BFS) obilazak
	void dfs(); //Deapth First Search (DFS) obilazak
	void dfs_r(); //pozivna funkcija za rekurzivni DFS obilazak
	void dfs_r_i(cvor *c); //rekurzivni DFS obilazak - interna
	void ispisi_graf() const; //ispis grafa
							  //konstruktor i destruktor
	graf(void);
	~graf(void);
};

