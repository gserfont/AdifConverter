using ADIFConverter.Model;


public class HendrikEnumeration
{

    public string _callSign { get; set; }

    public HendrikEnumeration()
    {
        _callSign = string.Empty;
    }

    public static void Main()
    {
        Console.WriteLine("Starting");

        /*List<antPath> antPathList = ADIFEnumerations.getAntPath();
        foreach (antPath a in antPathList)
        {
            Console.WriteLine(a._Abbreviation + "    " + a._Meaning);
        }

        List<dxccEntity> dxccEntities = ADIFEnumerations.getDXCCEntity();
        foreach (dxccEntity dxcc in dxccEntities.Where(a => a._Deleted.Equals(false)))
        {
            Console.WriteLine(dxcc._EntityCode + "  " + dxcc._EntityName);
        }

        List<subMode> submodes = ADIFEnumerations.getSubmodes();
        foreach (subMode a in submodes)
        {
            Console.WriteLine(a._Mode._Name + "   " + a._Name + "   " + a._Description);
        }

        Console.WriteLine("Entities not deleted: " + dxccEntities.Where(a => a._Deleted.Equals(false)).Count());
        Console.WriteLine("Entities deleted: " + dxccEntities.Where(a => a._Deleted.Equals(true)).Count());
        */

        //dxccEntity aCountry = ADIFEnumerations.getDxccEntity(462);

        //Console.WriteLine(aCountry._EntityName + "|" + aCountry._EntityCode + "|" + aCountry._Deleted);

        List<dxccEntity> CountryNames = ADIFEnumerations.getDxccEntity("bul");
        foreach (dxccEntity acountry in CountryNames)
        {
            Console.WriteLine(acountry._EntityCode +"|" + acountry._EntityName);
        }

    }

}