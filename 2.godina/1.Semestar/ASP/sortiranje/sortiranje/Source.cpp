#include <iostream>
#include "sortiranja.h"

int main()
{
	const int n = 75000;
	clock_t pocetak_rand, pocetak_az, pocetak_za, kraj_rand, kraj_az, kraj_za;
	//int p[n]; alociramo dinamicki novo polje
	int *p = new int[n];
	cout << "Sortiram" << n << "brojeva u random, a-z i z-a nizu..." << endl << endl;

	//slucajni niz
	napuni_polje_rand(p, n);
	pocetak_rand = clock();
	bubble_sort(p, n);
	kraj_rand = clock();
	//ispisi_polje(p, n);

	//a-z niz -vec imamo sortirani niz
	napuni_polje_az(p, n);
	pocetak_az = clock();
	bubble_sort(p, n);
	kraj_az = clock();
	//ispisi_polje(p, n);

	//z-a niz
	napuni_polje_za(p, n);
	pocetak_za = clock();
	bubble_sort(p, n);
	kraj_za = clock();
	//ispisi_polje(p, n);

	cout << "sortiranje slucajnih brojeva obavljeno za \t" << diffclock(kraj_rand, pocetak_rand) << "ms" << endl;
	cout << "sortiranje 1..n brojeva obavljeno za \t\t" << diffclock(kraj_az, pocetak_az) << "ms" << endl;
	cout << "sortiranje n..1 brojeva obavljeno za \t" << diffclock(kraj_za, pocetak_za) << "ms" << endl;
	
	system("pause");
	return 0;

}