struct Goods
{
    public string name;
    public string date;
    public double mass;
    public double cost;
    public string vendor;
    public int save;
    //construct
    public Goods(string a, string b, double c, double d, string e, int f)
    {
        name = a;
        date = b;
        mass = c;
        cost = d;
        vendor = e;
        save = f;
    }
}