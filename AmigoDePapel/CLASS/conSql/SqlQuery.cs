namespace AmigoDePapel.CLASS.conSql
{
    class SqlQuery
    {
        //public sql querys

        //STK_ITEM_LIVRO
        public string sql_create_stk_item_livro = @"CREATE TABLE STK_ITEM_LIVRO (
	                                                ISDELETED BIT DEFAULT '0' NOT NULL,
	                                                ID INTEGER NOT NULL IDENTITY,
	                                                TITULO NVARCHAR(200),
	                                                SUBTITULO NVARCHAR(200),
	                                                ISBN NVARCHAR(200),
	                                                EDITORA NVARCHAR(200),
	                                                VERSAO NVARCHAR(50),
	                                                ANO INTEGER,
	                                                AUTOR NVARCHAR(200),
	                                                TEMA NVARCHAR(200),
	                                                SUBTEMA NVARCHAR(200),
	                                                PAGINAS INTEGER,
	                                                OBSERVACAO NVARCHAR(900),
	                                                CONSTRAINT ITEM_LIVRO_PK_0001 PRIMARY KEY (ID))";

        public string sql_create_unique_stk_item_livro = "CREATE UNIQUE INDEX STK_ITEM_LIVRO_ID_UNIQUE_001 ON STK_ITEM_LIVRO(ID)";

        //crm_cliente
        public string sql_create_crm_cliente = @"CREATE TABLE CRM_CLIENTE (
	                                                ISDELETED BIT DEFAULT '0' NOT NULL,
	                                                ID INTEGER NOT NULL IDENTITY,
	                                                NOME NVARCHAR(200),
	                                                NASCIMENTO DATE,
	                                                ENDERECO NVARCHAR(900),
	                                                DOCUMENTO NVARCHAR(200),
	                                                OBSERVACAO NVARCHAR(900),
	                                                CONSTRAINT CLIENTE_PK_0001 PRIMARY KEY (ID))";

        public string sql_create_unique_crm_cliente = "CREATE UNIQUE INDEX CRM_CLIENTE_ID_UNIQUE_001 ON STK_ITEM_LIVRO(ID)";

        //emprestimos

        public string sql_create_pvd_emprestimos = @"CREATE TABLE PVD_EMPRESTIMOS (
	                                                ISDELETED BIT DEFAULT '0' NOT NULL,
	                                                ID INTEGER NOT NULL IDENTITY,
	                                                ID_ITEM_LIVRO INTEGER NOT NULL,
	                                                ID_CLIENTE INTEGER NOT NULL,
	                                                DATE_INICIO DATETIME NOT NULL,
	                                                DATE_FIM DATETIME NOT NULL,
	                                                STATUS NVARCHAR(100),
	                                                STATUS NVARCHAR(100)
	                                                CONSTRAINT EMPRESTIMOS_PK_0001 PRIMARY KEY (ID))";
    }

}
