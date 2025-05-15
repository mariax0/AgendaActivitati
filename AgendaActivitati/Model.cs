using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

[Serializable]
public class Domeniu
{
    public int Id { get; set; }
    public string Nume { get; set; }
    public string Descriere { get; set; }
    public BindingList<Proiect> Proiecte { get; set; } = new BindingList<Proiect>();
}

[Serializable]
public class Proiect
{
    public int Id { get; set; }
    public string Nume { get; set; }
    public DateTime DataInceput { get; set; }
    public DateTime DataSfarsit { get; set; }
    public BindingList<Activitate> Activitati { get; set; } = new BindingList<Activitate>();
}

[Serializable]
public class Activitate
{
    public int Id { get; set; }
    public string Nume { get; set; }
    public string Descriere { get; set; }
    public DateTime Data { get; set; }
    public bool Finalizata { get; set; }
}

[Serializable]
public class Agenda
{
    public BindingList<Domeniu> Domenii { get; set; } = new BindingList<Domeniu>();
}