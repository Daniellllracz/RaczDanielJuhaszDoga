using System.Globalization;

namespace RaczdanielOrszagok;

internal class Nagyvaros
{
    public string Varos { get; set; }
    public string Orszag { get; set; }
    public double Nepesseg { get; set; }

    public Nagyvaros(string varosSor)
    {
        var v = varosSor.Split(';');
        Varos = v[0];
        Orszag = v[1];
        Nepesseg = double.Parse(v[2]);
    }

    public override string ToString()
    {
        return $"{Varos}, {Orszag}, {Nepesseg:F2} millió fő";
    }
}
