  class Pessoa {
  private string nome;
  private int idade;
  private double altura;


  // construtor com parametros 
  public Pessoa (string nome, int idade, double altura) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  // construtor sem parametros
  public Pessoa () {
    this.nome = "Não informado";
    this.idade = 0;
    this.altura = 0;
  }  

  // método GET / SET
  public string getNome (){
    return this.nome;
  }

  public void setNome (string n){
    nome = n;
  }

  public int getIdade (){
    return idade;
  }

  public void setIdade (int i){
    idade = i;
  }

  public double getAltura (){
    return altura;
  }

  public void setAltura (double a){
    altura = a;
  }

  public override string ToString () {
    return nome + " , " + idade + " , " + altura;
  }

  






}