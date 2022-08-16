using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    public enum Tela
    {
        Inserir,
        Alterar,
        Exibir,
        Aluno,
        Professor,
        Secretariado, 
        TurmaAluno, 
        DisciplinaAluno
    }
    public enum Consulta
    {
        Codigo,
        Nome,
        Matricula,
        CPF        
    }

    public enum Classe
    {
        TurmaPeriodoDisciplina,
        PeriodoDisciplina
    }
     
}
