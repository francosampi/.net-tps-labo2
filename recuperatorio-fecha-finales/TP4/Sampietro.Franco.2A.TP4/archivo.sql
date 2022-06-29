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
('Santiago Arrascaeta', 8, 0, 0, 8, 0),
('Santiago de la Torre', 8, 8, 7, 0, 0),
('Juan Martin Traina', 9, 8, 0, 7, 10)

select * from notas