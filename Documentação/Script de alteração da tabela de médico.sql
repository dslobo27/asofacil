select * from medicos;


alter table medicos add usuarioId uniqueidentifier not null;

insert into medicos(id, nome, CRM, usuarioId) values('c4b12e61-99fb-4469-9cb2-b90fb68bbe30', 'Alan Ardison', 'CRM123456', 'BFDEE224-17D7-4F04-8589-A5A47B749E14');