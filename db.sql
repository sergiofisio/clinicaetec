CREATE DATABASE IF NOT EXISTS dbclinica;

use dbclinica;

show databases;
show tables;

CREATE TABLE IF NOT EXISTS tb_paciente (
cod_paciente int AUTO_INCREMENT PRIMARY KEY,
nome_paciente varchar(100) not null,
cpf_paciente char(11) not null unique,
celular_paciente char(11) not null
);

CREATE TABLE IF NOT EXISTS tb_especialidade(
cod_espec int AUTO_INCREMENT PRIMARY KEY,
descricao varchar(40) not null unique
);

CREATE TABLE IF NOT EXISTS tb_medico (
    crm_medico INT PRIMARY KEY,
    nome_medico VARCHAR(100) NOT NULL,
    cpf_medico CHAR(11) NOT NULL UNIQUE,
    celular_medico CHAR(11) NOT NULL,
    cod_espec INT not null,
    FOREIGN KEY (cod_espec) REFERENCES tb_especialidade(cod_espec)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS tb_prod_medic(
cod_prod int auto_increment primary key,
descricao_prod varchar(50) not null unique,
valor decimal(4,2) not null,
validade timestamp not null,
quantidade int not null default(0)
);

CREATE TABLE IF NOT EXISTS tb_atendimento(
nr_atendimento INT auto_increment PRIMARY KEY,
cod_paciente int not null,
data_atendimento timestamp not null,
crm_medico INT NOT NULL,
FOREIGN KEY (cod_paciente) REFERENCES tb_paciente(cod_paciente)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
FOREIGN KEY (crm_medico) REFERENCES tb_medico(crm_medico)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE IF NOT exists tb_itens_atendimento(
id int auto_increment primary key,
nr_atendimento int not null,
cod_prod int not null,
quantidade int not null,
FOREIGN KEY (nr_atendimento) REFERENCES tb_atendimento(nr_atendimento)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
FOREIGN KEY (cod_prod) REFERENCES tb_prod_medic(cod_prod)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

-- Insere dados na tabela tb_paciente
INSERT INTO tb_paciente (nome_paciente, cpf_paciente, celular_paciente) VALUES
('Ana Silva', '12345678901', '11999999999'),
('Carlos Oliveira', '23456789012', '11988888888'),
('Maria Souza', '34567890123', '11977777777');

-- Insere dados na tabela tb_especialidade
INSERT INTO tb_especialidade (descricao) VALUES
('Cardiologia'),
('Ortopedia'),
('Pediatria');

-- Insere dados na tabela tb_medico
INSERT INTO tb_medico (crm_medico, nome_medico, cpf_medico, celular_medico, cod_espec) VALUES
(101, 'Dr. João Pereira', '45678901234', '11966666666', 1),
(102, 'Dra. Fernanda Lima', '56789012345', '11955555555', 2),
(103, 'Dr. Ricardo Santos', '67890123456', '11944444444', 3);

-- Insere dados na tabela tb_prod_medic
INSERT INTO tb_prod_medic (descricao_prod, valor, validade, quantidade) VALUES
('Dipirona', 5.50, '2025-12-31 00:00:00', 5),
('Paracetamol', 6.00, '2024-06-30 00:00:00',3),
('Ibuprofeno', 8.00, '2025-01-15 00:00:00',9);

-- Insere dados na tabela tb_atendimento
INSERT INTO tb_atendimento (cod_paciente, data_atendimento, crm_medico) VALUES
(1, '2024-11-20 14:00:00', 101),
(2, '2024-11-21 10:00:00', 102),
(3, '2024-11-22 16:00:00', 103);

-- Insere dados na tabela tb_itens_atendimento
INSERT INTO tb_itens_atendimento (nr_atendimento, cod_prod, quantidade) VALUES
(1, 1, 2), -- Atendimento 1, Dipirona
(1, 2, 1), -- Atendimento 1, Paracetamol
(2, 3, 3), -- Atendimento 2, Ibuprofeno
(3, 1, 1), -- Atendimento 3, Dipirona
(3, 2, 2); -- Atendimento 3, Paracetamol

select cod_paciente as CODIGO from tb_paciente;

select * from tb_paciente;
select * from tb_especialidade;
select * from tb_medico;
select * from tb_prod_medic;
select * from tb_atendimento;
select * from tb_itens_atendimento;

SELECT 
    tb_atendimento.nr_atendimento,
    tb_paciente.nome_paciente,
    tb_paciente.cpf_paciente,
    tb_medico.nome_medico,
    tb_medico.crm_medico
FROM 
    tb_atendimento
INNER JOIN 
    tb_paciente 
ON 
    tb_atendimento.cod_paciente = tb_paciente.cod_paciente
INNER JOIN 
    tb_medico 
ON 
    tb_atendimento.crm_medico = tb_medico.crm_medico;
    
SELECT 
    tb_atendimento.nr_atendimento,
    tb_paciente.nome_paciente,
    tb_medico.nome_medico,
    SUM(tb_itens_atendimento.quantidade) AS total_itens,
    SUM(tb_prod_medic.valor * tb_itens_atendimento.quantidade) AS valor_total,
    tb_atendimento.data_atendimento
FROM 
    tb_atendimento
INNER JOIN 
    tb_paciente 
ON 
    tb_atendimento.cod_paciente = tb_paciente.cod_paciente
INNER JOIN 
    tb_medico 
ON 
    tb_atendimento.crm_medico = tb_medico.crm_medico
INNER JOIN 
    tb_itens_atendimento 
ON 
    tb_atendimento.nr_atendimento = tb_itens_atendimento.nr_atendimento
INNER JOIN 
    tb_prod_medic 
ON 
    tb_itens_atendimento.cod_prod = tb_prod_medic.cod_prod
GROUP BY 
    tb_atendimento.nr_atendimento, 
    tb_paciente.nome_paciente, 
    tb_medico.nome_medico, 
    tb_atendimento.data_atendimento;
    
SELECT 
    tb_atendimento.nr_atendimento,
    tb_paciente.nome_paciente,
    tb_medico.nome_medico,
    tb_prod_medic.descricao_prod,
    tb_prod_medic.valor,
    tb_itens_atendimento.quantidade,
    (tb_prod_medic.valor * tb_itens_atendimento.quantidade) AS valor_total_item,
    tb_atendimento.data_atendimento
FROM 
    tb_atendimento
INNER JOIN 
    tb_paciente 
ON 
    tb_atendimento.cod_paciente = tb_paciente.cod_paciente
INNER JOIN 
    tb_medico 
ON 
    tb_atendimento.crm_medico = tb_medico.crm_medico
INNER JOIN 
    tb_itens_atendimento 
ON 
    tb_atendimento.nr_atendimento = tb_itens_atendimento.nr_atendimento
INNER JOIN 
    tb_prod_medic 
ON 
    tb_itens_atendimento.cod_prod = tb_prod_medic.cod_prod
ORDER BY 
    tb_atendimento.nr_atendimento, tb_prod_medic.descricao_prod;
