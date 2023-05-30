﻿using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioEmMemoriaBase<Contato>
    {
        public RepositorioContato(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }
    }
}
