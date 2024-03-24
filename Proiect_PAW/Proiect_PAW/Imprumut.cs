﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proiect_PAW
{
    internal class Imprumut:IioFile
    {
        private string idImprumut;
        private Book book;
        private Reader reader;
        private Student stud;
        public Imprumut()
        {
           
            reader = new Reader();
            stud = new Student();   
        }

        public string IdImprumut { get => idImprumut; set => idImprumut = value; }
        public Book Book { get => book; set => book = value; }
        public Reader Reader { get => reader; set => reader = value; }
        public Student Stud { get => stud; set => stud = value; }

        public string writeStudent()
        {
            string rezultat = "Name:"+stud.Name+Environment.NewLine+"Id:"+stud.IdStudent+Environment.NewLine+
                              "CNP:"+stud.Id+Environment.NewLine+"Facultate:"+stud.University;
           
            return rezultat;
        }
        public string writeReader()
        {
            string rezultat = "Nume:" + reader.Name + Environment.NewLine + "CNP:" + reader.Id + Environment.NewLine;
            return rezultat;
        }

        public void writeTextFile()
        {
            StreamWriter write = new StreamWriter("Imprumuturi.txt");
            if(this.reader is Student)
            {
                write.WriteLine(this.writeStudent());
                for(int i=0;i<this.stud.Books.Count;i++)
                {
                    write.WriteLine(this.stud.Books[i].ToString());
                }
            }
            if (this.reader is  Reader)
            {
                write.WriteLine(this.writeReader());
                for (int i = 0; i < this.reader.Books.Count; i++)
                {
                    write.WriteLine(this.reader.Books[i].ToString());
                }

            }
            write.Close();
        }

        public void readTextFile()
        {
            throw new NotImplementedException();
        }

        public void writeBinary()
        {
            throw new NotImplementedException();
        }
    }
}
