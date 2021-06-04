# Jogo Xadrez em Console
 O jogo foi feito inteiramente em C# funcionando via console. </br>
 Esse projeto foi desenvolvido junto com o instrutor Nelio Alves em seu curso C# COMPLETO Programação Orientada a Objetos + Projetos.</br>
 Link do curso: https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/
 
 # Requisitos: 
 - .Net (https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet);
 - Visual Studio Community 2018^ (https://visualstudio.microsoft.com/pt-br/vs/community/){
   Configuraçoes do VSC 2018^:{
     - Desenvolvimento com a Plataforma Universal do Windows
     - Desenvolvimento para Desktop com .NET
     - ASP.NET e desenvolvimento Web
     - Desenvolvimento de multiplataforma com .NET Core
 }
 
# O Jogo

8  T C B D R B C T </br>
7  P P P P P P P P </br>
6  - - - - - - - - </br>
5  - - - - - - - - </br>
4  - - - - - - - - </br>
3  - - - - - - - - </br>
2  P P P P P P P P </br>
1  T C B D R B C T </br>
   a b c d e f g h </br>

Peças capturadas: </br>
Brancas: [] </br>
Pretas: [] </br>

Turno: 1 </br>
Aguardando jogada: Branca </br>

Origem: < </br>


Em origem é indicado qual peça deseja mexer (Exe: a2); </br>
 -------------------------------------------------------------------------------------------------------------------------------------------- </br>

8 T C B D R B C T </br>
7 P P P P P P P P </br>
6 - - - - - - - - </br>
5 - - - - - - - - </br>
4 - - - - - - - - </br>
3 - - - - - - - - </br>
2 P P P P P P P P </br>
1 T C B D R B C T </br>
  a b c d e f g h </br>

Destino: < </br>

Em destino é indicado para onde a peça deve ir (Exe: a4); </br>

--------------------------------------------------------------------------------------------------------------------------------------------</br>
8 T C B D R B C T </br>
7 P P P P P P P P </br>
6 - - - - - - - - </br>
5 - - - - - - - - </br>
4 P - - - - - - - </br>
3 - - - - - - - - </br>
2 - P P P P P P P </br>
1 T C B D R B C T v
  a b c d e f g h </br>

Peças capturadas: </br>
Brancas: [] </br>
Pretas: [] </br>

Turno: 2 </br>
Aguardando jogada: Preta </br>

Origem: < </br>

Assim movendo a peça e passando a vez para o outro jogador. </br>
