**SOLID**

**S(SRP)**
Single Responsiblity Principle (Princípio da responsabilidade única)</br>
Dos mais usados, a classe deve ter somente uma responsabilidade e uma razão para mudar.</br>

</br>Ex. Bad</br>
- A classe tem lógiga de negócio e salva dados no banco de dados;

</br>Ex. Good</br>
- Classes com divisões claras das responsabilidades(classes especializadas)
    - Classe GeradorRelatorios foca somente em gerar relatorios, eqto a classe de RelatoriosPersistencia foca na persistencia dos dados.

---

**O(OCP)</br>**
Open-Closed Principle (Princípio Aberto-Fechado)</br>
O OCP afirma que as classes dever estar "aberta para extensção" porém fechadas para modificação.

</br>Ex. Bad</br>
- Modificar uma classe diretamente para adicionar um novo comportamento.

</br>Ex. Good</br>
-  Facilidade de extenção: Novas funcionalidades podem ser adicionadas sem alterar o código existente.
-  Redução de Bugs: Minimiza o risco de introduzir erros em funcionalidades já implementadas.
    
---

**L(LSP)</br>**
L — Liskov Substitution Principle (Princípio da substituição de Liskov)</br>
O LSP afirma que objetos de uma classe derivada devem poder subistituir objetos de sua classe base sem alterar a funcionalidade do programa.</br>

</br>Ex. Bad</br>
- Classes derivadas que alterar ou invadam funcionalidades da classe base.

</br>Ex. Good</br>
- Classes derivadas devem manter o comportamento esperado da classe base.
- Polimorfismo Seguro: Permite que substituições sejam feitas sem quebrar o código.

</br>Pergunte-se</br>
- A classe derivada pode realmente substituir a classe base sem problemas?

---


I — Interface Segregation Principle (Princípio da Segregação da Interface)
D — Dependency Inversion Principle (Princípio da inversão da dependência)



----

Créditos 
Balta.io
