namespace SocieteListe
{
   public class Element : IDisposable
   {
    private object objet;
    private Element suivant;

    public Element(object objet) 
    {
        this.objet = objet;
        this.suivant = null;
    }

    public object Objet 
    {
        get { return this.objet; }
        set { this.objet = value; }
    }

    public Element Suivant 
    {
        get { return this.suivant; }
        set { this.suivant = value; }
    }

    public override string ToString()
    {
        return $"objet:{this.objet}";
    }

    public override void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    }
}