using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCICIO_01___ORIENTACAO_A_OBJ{
    //----------------------START | OBJ RETANGULO------------------------//
    class Retangulo{//----> Atributos da classe
        public double Largura;
        public double Altura;
    //------------------------ MET. CLASS -------------------------------//
    public double Area(){ 
        return Largura * Altura;
    }
    public double Perimeto(){
        return 2 * (Largura * Altura);
    }
    public double Diagonal(){
        return Math.Sqrt(Largura * Largura + Altura * Altura);    
        }
    }
    //--------------------------- END --------------------------------//    
}
