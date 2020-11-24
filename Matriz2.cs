using  System ;

namespace  Matriz2
{
     programa de aula
    {
        static  void  Main ( string [] args )
        {
            Console . WriteLine ( " Informe a quantidade de linhas: " );
            int  linha  =  int . Parse ( Console . ReadLine ());

            Console . WriteLine ( " Informe a quantidade de colunas: " );
            int  col  =  int . Parse ( Console . ReadLine ());

            double [,] mat  =  new  double [ linha , col ];

            para ( int  x  =  0 ; x  <  linha ; x ++ )
            {
                para ( int  y  =  0 ; y  <  col ; y ++ )
                {
                    Console . WriteLine ( " Entre com a posição X: "  +  x . ToString () +  " x Y: "  +  y . ToString ());
                    mat [ x , y ] =  int . Parse ( Console . ReadLine ());
                }
            }

            Console . WriteLine ( " Matriz: "  +  linha  +  " , "  +  col );

            para ( int  x  =  0 ; x  <  linha ; x ++ )
            {
                para ( int  y  =  0 ; y  <  col ; y ++ )
                {
                    Console . Escreva ( mat [ x , y ] +  "   " );
                }
               
            }

            Console . WriteLine ( " Digite um número que tenha na Matriz: " );
            int  valor  =  int . Parse ( Console . ReadLine ());

             contagem  interna =  0 ;

            Console . WriteLine ( " Diagonal Principal: " );

            para ( int  x  =  0 ; x  <  linha ; x ++ )
            {
                para ( int  y  =  0 ; y  <  col ; y ++ )
                {
                    if ( x  ==  y )
                    {
                        Console . Escreva ( mat [ x , y ] +  "  " );
                    }
                    if ( mat [ x , y ] <  0 )
                    {
                        contagem ++ ;
                    }

                }
            }
           
            Console . WriteLine ( " Números negativos: " );
            Console . WriteLine ( contagem );
        }
    
    }
    }

