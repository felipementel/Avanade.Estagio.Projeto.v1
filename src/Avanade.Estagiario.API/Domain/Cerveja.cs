namespace Avanade.Estagiario.API.Domain
{
    /// <summary>
    /// Classe de cerveja
    /// </summary>
    /// 
    
    public class Cerveja
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Nome { get; set; }

        public bool Gelada { get; set; }

        public DateTime Compra { get; set; }

        public float TeorAlcoolico { get; set; }
    }
}

//TODO: alterar para set privado
//TODO: Utilizar construtor
