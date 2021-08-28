using System;

namespace estrutura_pilha
{
    public class Pilha
    {
        // obj pos
        class Posicao{
            public Posicao next;
            public object item;
            public Posicao(Posicao next, object item){
                this.next = next;
                this.item = item;
            }
        }

        Posicao primeiro;
        public void Empilhar(object item){
            primeiro = new Posicao(primeiro,item);
        }
        
        public object Desempilhar(){
            
            if(primeiro ==null){
                Console.WriteLine("obj null");   
            }

            object result = primeiro.item;
            primeiro = primeiro.next;

            return result;
        }
            
    }
}