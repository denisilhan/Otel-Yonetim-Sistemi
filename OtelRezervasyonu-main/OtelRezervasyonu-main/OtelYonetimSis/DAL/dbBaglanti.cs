using MySql.Data.MySqlClient;

public class DbBaglanti
{
    public static MySqlConnection BaglantiGetir()
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132230027;User=25_132230027;Password=!nif.ogr27IL;");
        baglanti.Open();
        return baglanti;
    }
}