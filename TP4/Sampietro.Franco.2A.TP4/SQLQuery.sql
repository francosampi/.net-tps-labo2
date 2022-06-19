create database SistemaNotas
GO
use SistemaNotas
GO

create table notas(
id int IDENTITY(1,1) PRIMARY KEY,
alumno varchar(20) not null,
programaciondevideojuegos int,
dibujodecomics int,
disenografico int,
disenoblender int,
programacionweb int,
)

insert into notas values
('Franco Sampietro', 7, 0, 0, 0, 9),
('Santiago Arrascaeta', 8, 0, 0, 10, 7)

UPDATE notas
SET
alumno = 'Josecito',
programaciondevideojuegos = '2',
dibujodecomics = '2',
disenografico = '2',
disenoblender = '2',
programacionweb = '2'
WHERE id in (23)

delete from notas where id in (19)