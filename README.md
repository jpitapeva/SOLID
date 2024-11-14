SOLID

S(SRP)
Single Responsiblity Principle (Princípio da responsabilidade única)</br>
Dos mais usados, a classe deve ter somente uma responsabilidade e uma razão para mudar.</br>
</br>Ex. Bad</br>
- A classe tem lógiga de negocio e salva dados no banco;

</br>Ex. Good</br>
- Classes com divisões claras das responsabilidades(classes especializadas)
    - Classe GeradorRelatorios foca somente em gerar relatorios, eqto a classe de RelatoriosPersistencia foca na persistencia dos dados.

---

O(OCP)</br>
Open-Closed Principle (Princípio Aberto-Fechado)</br>
