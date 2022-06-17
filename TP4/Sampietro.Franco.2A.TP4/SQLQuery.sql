create database SistemaNotas
GO
use SistemaNotas
GO

create table notas(
id int IDENTITY(1,1) PRIMARY KEY,
alumno varchar(20) not null,
programaciondevideojuegos int,
dibujodecomics int,
disenoblender int,
programacionweb int,
promedio int,
)

select * from notas