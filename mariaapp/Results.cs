using System.Collections.Specialized;
using System.Dynamic;

namespace mariaapp;

public class Results
{
    public int temp {get;set;}//feito
    public string description {get;set;}//feito
    public string condition_code {get;set;}//nao precisa
    public string img_id {get;set;}//nao precisa
    public string city {get;set;}//feito
    public double rain {get;set;}//feito
    public double cloudiness {get;set;}//nao precisa
    public int humidity {get;set;}//feito
    public string sunrise {get;set;}//feito
    public string sunset {get;set;}//feito
    public string whind_speedy {get;set;}//feito
    public int whind_direcion{get;set;}//feito
    public string whind_cardinal {get;set;}//feito
    public string moon_phase {get;set;}//feito
    public string curenty {get;set;}//nao precisa
}