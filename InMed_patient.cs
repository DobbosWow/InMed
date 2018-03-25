using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InMed_ClassPatient
{

    //все заглушки метода закрыл через private, как сделаю - открою. 
    class Patient
    {
        private enum Gender { male, female };
        private string name;
        private string secondname;
        private string surname;
        private Gender patGender;
        private int age;
        private int patDesease; //указывает на ID болезни в таблице Desease в db InMed
        private string[] actCopmlaint;
        private string[] pasComplaint;

        //единственный конструктор, иначе мы определять пациентов не будем
        public Patient(string n, string sn, string sun, int g, int a, int d) 
        {
            name = n;
            secondname = sn;
            surname = sun;
            patGender = (Gender) g;
            age = a;
            patDesease = d;
        }

        private void SetComplaint() 
        {
            //заглушка метода, тут будем заполнять массивы активных и пассивных жалоб.
        }
        //проверяем, верно ли был студентом поствлен диагноз
        public bool DeseaseTrue(int enteredDes) 
        {
            if (enteredDes == patDesease) return true; else return false;  
        }

        private void SetAnalisys(int anID) //ID анализа в таблице Analisys в db InMed
        {
            //еще заглушка, не придумал реализацию, пока нет базы
        }

        private void SetDeag(int diagID)
        {
            //аналогично вышестоящему методу
        }
        public void print()  //временный метод для отладки, потом будет нахрен не нужен
        {
            Console.WriteLine(name);
            Console.WriteLine(secondname);
            Console.WriteLine(surname);
            Console.WriteLine(patGender);
            Console.WriteLine(patDesease);
            Console.WriteLine(age);
        }
              
    }
}