public class GerenciamentoDeNuvens
{
    private Dictionary<string, AbstractNuvem> _nuvens = new Dictionary<string, AbstractNuvem>();

    public AbstractNuvem this[string key]
    {
        get { return _nuvens[key]; }
        set { _nuvens[key] = value; }
    }
}