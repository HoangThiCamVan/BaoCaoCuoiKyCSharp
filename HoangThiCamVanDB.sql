create database HoangThiCamVanDB
use HoangThiCamVanDB

create table UserAccount
(
	ID int identity(1,1) primary key,
	UserName nvarchar(100),
	Password varchar(50),
	Status nvarchar(100)
)
insert into UserAccount(UserName,Password,Status)
values
('van','van','Activated'),
('camvan','camvan','Activated'),
('cvan','cvan','Blocked'),
('htcv','htcv','Blocked'),
('admin','admin','Activated'),
('hcv','hcv','Activated'),
('mai','mai','Activated'),
('lien','lien','Activated')
drop table Category
create table Category
(
	ID int identity(1,1) primary key,
	Name nvarchar(100),
	Description nvarchar(100)
)
insert into Category(Name,Description)
values
(N'Phấn mắt',N'Bảng phấn,Hộp phấn'),
(N'Bút kẻ mắt',N'Kẻ mắt chống trôi,Kẻ mắt nước'),
(N'Kem che khuyết điểm',N'Kem,Bút'),
(N'Mascara',N'Chống trôi'),
(N'Chì kẻ mày',N'Đầu nhọn,Đầu tròn'),
(N'Sữa tắm',N'Trắng da,Trị lỗ chân lông'),
(N'Kem đánh răng',N'Trắng răng,Viêm nướu'),
(N'Chăm sóc tóc',N'Tóc uốn,Tóc thẳng'),
(N'Nước hoa',N'Body'),
(N'Kem chống nắng',N'Kem chống nắng,Xịt chống nắng'),
(N'Kem dưỡng',N'Ban ngày,Ban đêm'),
(N'Trị mụn',N'Mụn trứng cá,Mụn đầu đen,Mụn viêm')
drop table Product
create table Product
(
	ID int identity(1,1) primary key,
	Name nvarchar(100),
	UnitCost decimal(18,0),
	Quantity int,
	Image nvarchar(300),
	Description nvarchar(300),
	Status nvarchar(100),
	ID_Category int foreign key references Category(ID)
)

insert into Product(Name,UnitCost,Quantity,Image,Description,Status,ID_Category)
values
(N'Phấn Mắt Etude House',275000,30,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/etude-house-play-color-eyes-rose-crush-all-colors-eye-swatch-review-00002.jpg?v=1617181216927',N'Bảng gồm 6 màu lì và 3 màu nhũ nên nàng cứ thoải mái mà mix với nhau để cho ra nhiều kiểu make up. ','Top Hot',1),
(N'Bảng Mắt Clio Prism',310000,40,'https://bizweb.dktcdn.net/100/348/157/products/138597213-2131878346947244-6435636684886654501-n.jpg?v=1615601468167',N'Siêu xịn xò từ chất phấn, bao bì, độ bám màu và các gam màu lại vô cùng dễ phối.','Top Hot',1),
(N'Bảng Mắt Etude House',310000,20,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/164822613-919862028768466-6858394320390947066-n.jpg?v=1617181354173',N'Chất phấn lên mịn, có thể điều chỉnh độ đậm nhạt của phấn khá dễ dàng, các màu nhũ có hạt nhũ mịn.','Tophot',1),
(N'Bảng Mắt Makeup Revolution',185000,25,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/kk.jpg?v=1601474218770',N'Phấn mắt có độ bám khoảng 8 – 10 tiếng, độ bền màu cao kể cả khi không sử dụng thêm sản phẩm kem lót trước khi trang điểm cho vùng mắt.','Best Sellers',1),
(N'Bút kẻ mắt chống trôi Merzy',100000,30,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/f382a24d52cde0c2635a92e09c578861.jpg?v=1617680071307',N'Mực ra đều, không bị vón cục giúp bạn dễ dàng tạo đường kẻ mắt hoàn hảo ngay từ lần kẻ đầu tiên.','Top Hot',2),
(N'Kẻ Mắt Karadium Waterproof',100000,40,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/untitled-1.jpg?v=1623036693373',N'Kẻ mắt Karadium Waterproof không lem,không trôi,đầu bút được thiết kế mang chất liệu dạ sáng tạo, ngòi bút thanh và gọn.','Top Hot',2),
(N'Bút kẻ mắt nước Kiss Me Heroine',130000,40,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/ke-mat-kissme.jpg?v=1608907582790',N'Đầu bút mềm, dễ kẻ, nét bút đen và đậm, đặc biệt cực lâu trôi. Sản phẩm này phù hợp đi ngoài trời, dù trời mưa hay nắng vẫn không làm mất đi vẻ đẹp trên khuôn mặt của bạn.','Best Sellers',2),
(N'Kem Che Khuyết Điểm The Saem',150000,50,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/ckd-the-saem.jpg?v=1584202447117',N'Bé này có dạng kem hơi sệt, nhưng lại dễ tán đều lên da, độ bám cao, che phủ vô cùng tốt.','Best Sellers',3),
(N'Bút che khuyết điểm Maybelline',200000,35,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/1q-e19c5594-82bc-4f0d-9cfb-4e05376477e0.jpg?v=1603629210837',N' Đầu lông mềm mượt thiết kế dạng xoay dễ dàng kiểm soát được lượng kem mỗi lần sử dụng, rất tiện lợi và không sợ hao phí.','Top Hot',3),
(N'Kem Che Khuyết Điểm Fit Me',239000,25,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/concealer-maybelline.jpg?v=1590591494570',N'Kết cấu dạng kem rất dễ “blend” trên da, vừa giúp ngụy trang các khuyết điểm một cách khéo léo vừa giữ được độ đẹp lung linh suốt cả ngày dài.','Best Sellers',3),
(N'Mascara Kiss me Heroine make',210000,30,'https://bizweb.dktcdn.net/100/348/157/products/mh.jpg?v=1576297267943',N'Với khả năng phù phép hàng mi của bạn trở lên cong vút và quyến rũ như mọi ước mơ của các cô gái, lại cực lâu trôi, chống nước, không lem, không dính, không vón cục.','Top Hot',4),
(N'Mascara Maybelline Lash Sensational',210000,31,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/mascara-maybelline-lash-sensational-7.jpg?v=1589526018447',N'Đầu cọ với thiết kế hình quạt mới nhất với 10 lớp răng cưa mang lại hiệu ứng cánh quạt cho hàng mi dài, cong vút cực tự nhiên.','Top Hot',4),
(N'Mascara Maybeline the Colossal Volum',150000,40,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/untitled-2-fb834cce-fab8-4a53-b154-5e5da519fdda.jpg?v=1621399479717',N'Đầu cọ được thiết kế mới mẻ hơn, với đầu lông cấu tạo bởi những sợi hóa học nhỏ li ti dày và được dàn trải khắp đầu cọ.','Best Sellers',4),
(N'Kem đánh răng Crest 3D White',79000,45,'https://bizweb.dktcdn.net/thumb/grande/100/348/157/products/f0367339f79ef931feeae1e256f4812b.jpg?v=1617440780247',N'Cơ chế làm trắng răng của Crest 3D White Radiant Mint là tạo lớp bọt dày bao phủ hàm răng trong quá trình đánh răng.','Top Hot',7),
(N'Kem đánh răng Median Dental',60000,42,'https://bizweb.dktcdn.net/100/348/157/products/trang.jpg?v=1606526482563',N'Kem đánh răng Median là loại kem tốt nhất thế giới được bác sỹ khuyên dùng. Đồng thời, chất kem rất đặc nên dùng tiết kiệm vô cùng luôn.','Top Hot',7)



