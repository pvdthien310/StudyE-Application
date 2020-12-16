create table RoomList
(
RoomID nchar(20) not null,
HostID nchar(20) not null,
GuestId nchar(20) not null,
isClosed nchar(10),
isReady nchar(10)
)
ALTER TABLE RoomList
 ADD CONSTRAINT PK_RoomID PRIMARY KEY (RoomID); 

 create table RoomQuestions
 (
 RoomID nchar(10) not null,
 TypeQues nchar(100),
 Question nvarchar(1000),
 AnswerA nvarchar(1000),
 AnswerB nvarchar(1000),
 AnswerC nvarchar(1000),
 AnswerD nvarchar(1000),
 Correctindex nvarchar(100)
 )
 ALTER TABLE RoomQuestions
 ADD CONSTRAINT fk_Roomquestion
  FOREIGN KEY (RoomID)
  REFERENCES RoomList (RoomID);

  SELECT * FROM ROOMLIST
  INSERT INTO RoomList VALUES ('123','1','2','1','1')
    INSERT INTO RoomList VALUES ('1233','3','4','0','0')
	  INSERT INTO RoomList VALUES ('1243','5','6','1','0')
	    INSERT INTO RoomList VALUES ('1523','7','8','0','1')
		INSERT INTO RoomList VALUES ('4','7','8','0','0')
		INSERT INTO RoomList VALUES ('6','7','8','0','2')
		INSERT INTO RoomList VALUES ('8','7','8','0','2')
		INSERT INTO RoomList VALUES ('123','1','2','1','1')
		INSERT INTO RoomList VALUES ('9','3','4','0','0')
		INSERT INTO RoomList VALUES ('125','5','6','1','0')
	    INSERT INTO RoomList VALUES ('568','7','8','0','1')
		INSERT INTO RoomList VALUES ('999','7','8','0','0')
		INSERT INTO RoomList VALUES ('986','7','8','0','2')
		INSERT INTO RoomList VALUES ('865','7','8','0','2')
		INSERT INTO RoomList VALUES ('1251','5','6','1','0')
	    INSERT INTO RoomList VALUES ('5681','7','8','0','1')
		INSERT INTO RoomList VALUES ('9991','7','8','0','0')
		INSERT INTO RoomList VALUES ('9861','7','8','0','2')
		INSERT INTO RoomList VALUES ('8651','7','8','0','2')
		delete from roomlist
UPDATE ROOMLIST SET ISCLOSED = '1' WHERE ROOMID = '123'

	INSERT INTO RoomQuestions VALUES ('123','1','cau hoi ne ba?',' cau a ne','cau b ne','cau c ne','cau d ne','1')
	INSERT INTO RoomQuestions VALUES ('123','2','cau hoi loai 2 ne ba?',' cau a ne','cau b ne','cau c ne','cau d ne','1')