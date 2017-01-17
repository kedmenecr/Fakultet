// AISP_Kompresija.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include <cstdlib>
#include <iostream>
#include <fstream>
#include <string>
#include <ctime>

using namespace std;

char p[1000000000];
int index=0;

int rand_gen(){ 
	int random_integer; 
	int lowest=1, highest=9; 
	int range=(highest-lowest)+1;
	random_integer = lowest+int(range*rand()/(RAND_MAX + 1.0));
	return random_integer;
}

//generiranje slova
void generiraj(){
	int broj, kol;
	char slovo;
	ofstream myfile;
	myfile.open("izvor.txt");
	cout<<"Koliko slova zelite generirati?"<<endl;
	cin>>kol;
	for(int i=0; i<kol; i++){
		broj=rand_gen();
		slovo=char(65+broj);
		p[index]=slovo;
		index++;
		myfile<<slovo;
	}
	myfile.close();
	cout<<endl;
}

void generiranje(){
	ofstream myfile("izvor.txt");
	int slovo_broj;
	int range=5;
	int broj_slova;
	cout<<endl<<"Unesite broj koliko zelite da se generira slova: ";
	cin>>broj_slova;
	for(int i=0; i<broj_slova; i++){
		slovo_broj = 1+int(range*rand()/(RAND_MAX + 1.0));
		int ponavljanje = 1+int(range*rand()/(RAND_MAX + 1.0));
		string slovo="";
		switch(slovo_broj){
			case 1:
				slovo="A";
				//myfile<<"A";
				break;
			case 2:
				slovo="B";
				//myfile<<"B";
				break;
			case 3:
				slovo="C";
				//myfile<<"C";
				break;
			case 4:
				slovo="D";
				//myfile<<"D";
				break;
			case 5:
				slovo="E";
				//myfile<<"E";
				break;
		}
		for(int x=0; x<ponavljanje; x++)
			myfile<<slovo;
	}
	myfile.close();
	cout<<endl<<"Slova su spremljena u datoteku 'izvor.txt'"<<endl<<endl;
	system("pause");
}
//kompresija
void kompresor(){
	int br=1;
	ofstream myfile;
	ifstream ulaz;
	string line="";
	myfile.open("komprimirana.txt");
	ulaz.open("izvor.txt");
	if (ulaz.is_open()){
		while(!ulaz.eof()){
			ulaz>>line;
		}
	}
	ulaz.close();
	for(int i=0; i<line.length(); i++){
		if(line[i]==line[i+1]){
			br++;
		}
		else if(line[i]!=line[i+1]){
			if(br==1){
				myfile<<line[i];
			}
			else if(br==2){
				myfile<<line[i]<<line[i];
			}
			else if (br==3){
				myfile<<line[i]<<line[i]<<line[i];
			}
			else if (br>3){
				myfile<<line[i]<<"!"<<br;
			}
			br=1;
		}
	}
	myfile.close();

	//funkcija za velièinu datoteke 
	size_t fileSize = 0;
	string path = "izvor.txt";
	ifstream infile(path.c_str());
	if(infile.is_open())
	{
		infile.seekg(0, ios::end ); // move to end of file
		fileSize = infile.tellg();
	}
	cout << "Velicina izvorne datoteke: " << fileSize <<" Bajtova." <<endl;

	size_t fileSize2 = 0;
	string path2 = "komprimirana.txt";
	ifstream infile2(path2.c_str());
	if(infile2.is_open())
	{
		infile2.seekg(0, ios::end ); // move to end of file
		fileSize2 = infile2.tellg();
	}
	cout << "Velicina komprimirane datoteke: " << fileSize2<<" Bajtova." <<endl;
	cout << "Komprimiranjem se dobilo: "<<(fileSize)-(fileSize2)<<" bytova."<<endl;
	if(fileSize-fileSize2>1024)
		cout << "Komprimiranjem se dobilo: "<<(fileSize/1024)-(fileSize2/1024)<<" kB."<<endl;
	cout<<endl;
}

void dekompresor(){
	ifstream myfile;
	ofstream myfile2;
	string line, line2, pomoc,pomoc2;
	int br;
	myfile.open("komprimirana.txt");
	myfile2.open("source.txt");
	if (myfile.is_open()){
		while(!myfile.eof()){
			myfile>>line;
		}
	}
	int i=0;
	while(i<(int)line.length()){
		if(line.at(i)=='!'){
			pomoc=line.at(i+1);
			pomoc2=line.at(i-1);
			br=atoi(pomoc.c_str());
			for(int j=1; j<br;j++){
				myfile2<<pomoc2;
			}
			i++;
			pomoc2.clear();
		}
		else{
			pomoc2=line.at(i);
			myfile2<<pomoc2;
			pomoc2.clear();
		}
		i++;
	}
	myfile.close();
}

//prikaz
void prikaz(){
	string line;
	ifstream myfile;
	myfile.open("komprimirana.txt");
	if (myfile.is_open()){
		cout<<"Sadrzaj komprimirane datoteke:"<<endl;
		while(!myfile.eof()){
			myfile>>line;
		}
		cout<<line;
	}
	else
		cout<<"Greska kod otvaranja datoteke."<<endl;
	myfile.close();
	cout<<"\n\n";
}

//meni
void meni(){
	char izbor;
	do{
		cout<<"MENI"<<endl;
		cout<<"G - generiranje"<<endl;
		cout<<"C - komprimiranje"<<endl;
		cout<<"P - pregled komprimirane datoteke"<<endl;
		cout<<"D - dekompresija"<<endl;
		cout<<"K - kraj rada programa"<<endl;
		cout<<"Unesi izbor: ";
		cin>>izbor;
		cout<<endl;
		switch(izbor){
						  case 'g':
							  system("cls");
							  generiranje();
							  break;
						  case 'c':
							  system("cls");
							  kompresor();
							  break;
						  case 'p':
							  system("cls");
							  prikaz();
							  break;
						  case 'd':
							  system("cls");
							  dekompresor();
							  break;
						  case 'k':
							  cout<<"Kraj rada programa!"<<endl;
							  break;
						  default:
							  cout<<"Unijeli ste krivo!"<<endl;
		}
	}while(izbor!='k');
}

int main(int argc, char *argv[])
{
	//ofstream myfile ("izvor.txt", ios_base::trunc);
	//ofstream myfile ("komprimirana.txt", ios_base::trunc);
	srand( time( NULL ) );
	meni();
	system("PAUSE");
	return EXIT_SUCCESS;
}