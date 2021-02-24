drop table batch;
drop table trainers;
drop table associates;
CREATE TABLE associates
(
    id INT IDENTITY PRIMARY KEY,
    associateName NVARCHAR(100) NOT NULL,
    associateLocale VARCHAR(2) NOT NULL,
    revaPoints int NOT NULL
);
CREATE TABLE trainers
(
    id int IDENTITY PRIMARY KEY,
    trainerName varchar(20) not null,
    campus VARCHAR(3) not null,
    caffeineLevel int not null,
);
create table batch
(
    id int IDENTITY PRIMARY KEY,
    associateID int REFERENCES associates(id),
    trainerID int REFERENCES trainers(id)
);
insert into associates (associateName, associateLocale, revaPoints) values 
('Joaquin', 'PA', -10), ('Madeline', 'WA', 10), ('Jacob', 'FL', 0), ('Michael', 'AZ', 20), ('Janel', 'AZ', 50), ('Angeleen', 'TX', 30), ('Warren', 'NH', 40);
insert into trainers (trainerName, campus, caffeineLevel) values
('Marielle', 'USF', 5), ('Pushpinder', 'UTA', 50), ('Nick', 'UTA', 75), ('Mark', 'WVU', 16), ('Fred', 'UTA', 25);
insert into batch (associateID, trainerID) values
(3,3), (1,1), (2,1), (4,1), (6,1), (7,1);

--get associates in certain state
SELECT * from associates  where associateLocale = 'AZ';
--get number of associates in certain states
SELECT associateLocale, COUNT(*) from associates group by associateLocale order by associateLocale asc;
SELECT associateLocale, COUNT(*) from associates group by associateLocale order by COUNT(*) desc;
--get trainers without associates
SELECT trainers.id, trainerName, campus, caffeineLevel from trainers left outer join batch on trainers.id = trainerID where trainerID is null;
--get all associates mapped to a trainer
SELECT associateName from associates inner join batch on batch.associateID = associates.id where batch.trainerID = 1;
SELECT associateName from associates left outer join batch on associates.id = associateID where associateID is null;
--get all associates without a trainer
(SELECT id from associates) EXCEPT (select associateID from batch);