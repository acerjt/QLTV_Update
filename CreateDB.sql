

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTV]
GO

USE [QLTV]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [int] NOT NULL,
	[tenloaidocgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblDocGia](
	[madocgia] [int] NOT NULL,
	[hovaten] [nvarchar](50) NOT NULL,
	[maloaidocgia] [int] NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylap] [datetime2](7) NOT NULL,
	[ngayhethan] [datetime2](7)Not NULL,
	
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblTheLoaiSach](
	[MaTheLoaiSach] [int] NOT NULL,
	[TenTheLoaiSach] [nvarchar](50) NOT NULL,
	
 CONSTRAINT [PK_tblTheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaTheLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblTacGia](
	[MaTacGia] [int] NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
	
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblSach](
	[MaSach] [int] NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[MaTheLoaiSach] [int] NOT NULL,
	[MaTacGia] [int] NOT NULL,
	[NamXuatBan] [nvarchar](4) NOT NULL,
	[NhaXuatBan] [nvarchar](50) NOT NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
	[TriGia] [money] NOT NULL,
	[TinhTrang] [nvarchar](50),

 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



USE [QLTV]
GO



USE [QLTV]
GO

INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(1,N'X')
GO
INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(2,N'Y')
GO


USE [QLTV]
GO


INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(1,N'Phan Minh Toàn',2,convert(datetime,'2/10/1998 00:00:00'),N'Bắc Bình, Bình Thuận',N'16521261@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(2,N'Nguyễn Ngọc Dung',1,convert(datetime,'12/26/1997 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(3,N'Nguyen Thành Đạt',2,convert(datetime,'10/20/1998 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2018 00:00:00',101),convert(datetime,'12/11/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(4,N'Nguyễn Đức Tuấn',2,convert(datetime,'3/24/1998 00:00:00'),N' Bảo Lộc, Lâm Đồng',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2018 00:00:00',101),convert(datetime,'12/11/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(5,N'Võ Huỳnh Việt',2,convert(datetime,'6/20/1998 00:00:00'),N'Nha Trang, Khánh Hòa',N'16521344@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(6,N'Nguyễn Bá Tùng',2,convert(datetime,'4/18/1998 00:00:00'),N'Cần Giuộc,Long An',N'16521395@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(7,N'Ngô Thị Huyền',1,convert(datetime,'9/14/1998 00:00:00'),N'Krong Bong, Gia Lai',N'16520543@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(8,N'Nguyễn Thị Tú Uyên',1,convert(datetime,'2/24/1998 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'165215761@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(9,N'Phạm Thu Liên',1,convert(datetime,'1/4/1998 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(10,N'Vi Chí Thiện',2,convert(datetime,'6/6/1998 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'1652157@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(11,N'Nguyễn Thị Tâm',1,convert(datetime,'12/26/1997 00:00:00'),N'Hải Hậu,Nam Định',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(12,N'Nguyễn Trần Hoàng Thanh',1,convert(datetime,'12/29/1997 00:00:00'),N'Mỹ Xuyên, Sóc Trăng',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(13,N'Cáp Hữu Trần Sang',2,convert(datetime,'1/19/1997 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(14,N'Nguyễn Doãn Bảo Châu',2,convert(datetime,'4/6/1997 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(15,N'Trần Ngọc Phương Duyên',1,convert(datetime,'6/4/1997 00:00:00'),N'Vĩnh Hưng, Long An',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(16,N'Huỳnh Thị Sán',1,convert(datetime,'2/3/1995 00:00:00'),N'Nha Trang,Khánh Hoa',N'16521577@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(17,N'Huỳnh Quốc Đạt',2,convert(datetime,'20/5/1996 00:00:00'),N'Bình Định',N'16521586@gm.uit.edu.vn',convert(datetime,'12/05/2018 00:00:00',101),convert(datetime,'12/11/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(18,N'Nguyễn Khá Bá',2,convert(datetime,'12/3/1998 00:00:00'),N'Vĩnh Hưng, Long An',N'16521579@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(19,N'Trần Thi Hồng Trang',1,convert(datetime,'27/8/1997 00:00:00'),N'Cẩm Mỹ,Đồng Nai',N'16521580@gm.uit.edu.vn',convert(datetime,'12/05/2018 00:00:00',101),convert(datetime,'12/11/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(20,N'Lê Lúc Đạt',1,convert(datetime,'5/6/1997 00:00:00'),N'Bảo Lộc,Lâm Đồng',N'16521581@gm.uit.edu.vn',convert(datetime,'12/05/2018 00:00:00',101),convert(datetime,'12/11/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(21,N'Võ Hoàng Minh Châu',1,convert(datetime,'1/12/2000 00:00:00'),N'Đống Đa,Hà Nội',N'16521582@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(22,N'Trần Tí Tị',1,convert(datetime,'14/10/1999 00:00:00'),N'Thủ Đức,tp.HCM',N'16521583@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(23,N'Võ Tiêu Dao',1,convert(datetime,'12/12/1998 00:00:00'),N'Quận 9, tp.HCM',N'16521584@gm.uit.edu.vn',convert(datetime,'12/05/2019 00:00:00',101),convert(datetime,'12/11/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(24,N'Nguyễn Xuân Lực',2,convert(datetime,'5/5/1996 00:00:00'),N'Đà Lạt',N'16521585@gm.uit.edu.vn',convert(datetime,'12/05/2018 00:00:00',101),convert(datetime,'12/11/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(25,N'Trần Khánh Chi',2,convert(datetime,'7/9/1997 00:00:00'),N'Vĩnh Hưng, Long An',N'16521576@gm.uit.edu.vn',convert(datetime,'12/05/2018 00:00:00',101),convert(datetime,'12/11/2018 00:00:00',101))
GO



USE [QLTV]
GO


USE [QLTV]
GO

INSERT INTO[dbo].[tblTheLoaiSach]([MaTheLoaiSach],[TenTheLoaiSach]) VALUES(1,N'A')
GO
INSERT INTO[dbo].[tblTheLoaiSach]([MaTheLoaiSach],[TenTheLoaiSach]) VALUES(2,N'B')
GO
INSERT INTO[dbo].[tblTheLoaiSach]([MaTheLoaiSach],[TenTheLoaiSach]) VALUES(3,N'C')
GO

USE [QLTV]
GO

INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(1,N'Nguyễn Nhật Ánh')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(2,N'Nguyễn Thi')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(3,N'Halmet Trương')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(4,N'Nguyễn Minh Châu')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(5,N'Huy Cận')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(6,N'Nguyễn Công Hoan')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(7,N'Nguyễn Trung Thành')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(8,N'Nguyễn Tuân')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(9,N'Hoàng Phủ Ngọc Tường')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(10,N'Tố Hữu')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(11,N'Rachel Vincent')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(12,N'PGS.TS. Phạm Ngọc Bùng')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(13,N'Jack Canfield & DD.Watkins')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(14,N'Napoleon Hill')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(15,N'Geshe Michael Roach')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(16,N'Trác Nhã')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(17,N'Vãn Tình')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(18,N'Dale Carnegie')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(19,N'Marci Shimoff , Carol Kline')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(20,N'Paulo Coelho')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(21,N'Higashino Keigo')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(22,N'Shinkai Makoto')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(23,N'Rui Kodemari')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(24,N'Harper Lee')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(25,N'Nguyễn Bảo Trung')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(26,N'Dan Strutzel')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(27,N'John Brooks')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(28,N'Phan Văn Trường')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(29,N'Nguyễn Ngọc Long')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(30,N'Sheryl Sandberg')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(31,N'Thích Nhất Hạnh')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(32,N'Robin Sharma')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(33,N'Minh Niệm')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(34,N'Shibamoto Hidenori')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(35,N'Lewis Howes')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(36,N'Uyên Bùi')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(37,N'Lương Chí Thành')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(38,N'Aki Wakamatsu')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(39,N'Silvana Quattrocchi Montanaro')
Go
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(40,N'Masato Takeuchi')
Go

USE [QLTV]
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(1,N'Hôm Nay Tôi Buồn',2,3,N'2012',N'NXB Kim Đồng',convert(datetime,'11/05/2018 00:00:00'),20000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(2,N'Nữ Thần Báo Tử',3,11,N'2012',N'NXB Thế Giới',convert(datetime,'05/23/2018 00:00:00'),70000,' ')
Go
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(3,N'Việt Bắc',1,10,N'2014',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(4,N' Ai đã đặt tên cho dòng sông ?',1,9,N'2014',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(5,N'Người lái đò sông Đà',2,8,N'2015',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(6,N'Chiếc thuyền ngoài xa',3,4,N'2016',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(7,N' Những đứa con trong gia đình',1,2,N'2017',N'NXB Văn Học ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(8,N'Đôi Bạn',1,2,N'2017',N'NXB Văn Học ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(9,N'Người Mẹ Cầm Súng',1,2,N'2017',N'NXB Văn Học ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(10,N'Mẹ Vắng Nhà',1,2,N'2017',N'NXB Văn Học ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(11,N'Rừng xà nu',2,7,N'2018',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(12,N'Hóa Lý Dược',3,12,N'2013',N'NXB Y Học ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(13,N'Hóa Hữu Cơ',1,12,N'2014',N'NXB Y Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(14,N'Ngôi sao trên đỉnh Phu Văn Lâu',1,9,N'2014',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(15,N'Hoa trái quanh tôi',1,9,N'2014',N'NXB Nghệ Thuật',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(16,N'Người trong đau khổ vẫn cười',2,3,N'2012',N'NXB Văn Học',convert(datetime,'11/05/2018 00:00:00'),20000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(17,N'Yêu một người khó lắm',2,3,N'2012',N'NXB Văn Học',convert(datetime,'11/05/2018 00:00:00'),20000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(18,N'Never to Sleep',1,11,N'2012',N'NXB Thế Giới',convert(datetime,'05/23/2018 00:00:00'),70000,' ')
Go
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(19,N'If I Die',2,11,N'2012',N'NXB Thế Giới',convert(datetime,'05/23/2018 00:00:00'),70000,' ')
Go
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(20,N'Gió Lộng',1,10,N'2014',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(21,N'Ra Trận',1,10,N'2014',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(22,N'Một triếng đờn',3,10,N'2014',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(23,N'Ta với ta',2,10,N'2014',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(24,N'Tùy bút ',2,2,N'2017',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(25,N'Ký Cô Tô',3,2,N'2017',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(27,N'Tôi thấy hoa vàng trên cỏ xanh',1,1,N'2017',N'NXB Nghệ Thuật',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(28,N'Cô gái đến từ hôm qua ',2,1,N'2017',N'NXB Giáo Dục',convert(datetime,'11/07/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(29,N'Cho tôi xin một vé đi tuổi thơ ',3,1,N'2017',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(30,N' Đất nở hoa',1,5,N'2017',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(31,N'C Ngôi nhà giữa nắng',3,5,N'2017',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(32,N' Hạt lại gieo',2,5,N'2017',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(33,N' 13 nguyên tắc nghĩ giàu làm giàu',2,13,N'2018',N'NXB Lao Động Xã Hội',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(34,N' Nghĩ giàu và làm giàu',3,14,N'2016',N'NXB Tổng Hợp TPHCM',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(35,N' Năng đoạn kim cương',3,15,N'2018',N'NXB Tri Thức',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(36,N' Khéo ăn nói sẽ có được thiên hạ',3,16,N'2018',N'NXB Văn Học ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(37,N' Bạn đắt giá bao nhiêu',1,17,N'2018',N'NXB Thế Giới',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(38,N' Đắc nhân tâm',3,18,N'2016',N'NXB Tổng Hợp TPHCM',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(39,N' Khi mọi điểm tựa đều mất',2,19,N'2016',N'NXB Tổng Hợp TPHCM',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(40,N' Nhà giả kim',1,20,N'2017',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(41,N' Tên của trò chơi là bắt cóc',1,21,N'2019',N'NXB Phụ Nữ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(42,N'Your name',1,22,N'2017',N'NXB Văn Học',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(43,N'Hoa Trái Quanh Tôi',2,9,N'2014',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(44,N'Phù Đổng Thiên Vương',1,5,N'2015',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(45,N'Hành Tinh Hạn Phúc',1,3,N'2015',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(46,N'Mùa Chia Tay',1,3,N'2015',N'NXB Giáo Dục',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(47,N'Ăn chay trong Yoga',3,16,N'2015',N'NXB Phụ Nữ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(48,N'Bạn Thân',3,15,N'2015',N'NXB Phụ Nữ',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(49,N'Suy Tưởng',3,15,N'2015',N'NXB Tri Thức',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(43,N' Sự cứu rỗi của thánh nữ',1,21,N'2019',N'NXB Hội Nhà văn ',convert(datetime,'26/05/2019 00:00:00'),108800,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(44,N' Nơi bầu trời và đại dương gặp gỡ',2,23,N'2019',N'NXB Văn Học ',convert(datetime,'26/05/2019 00:00:00'),62000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(45,N' Giết con chim nhạn',1,24,N'2019',N'NXB Văn Học ',convert(datetime,'26/05/2019 00:00:00'),93000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(46,N' Mắc biếc',1,1,N'2018',N'NXB Trẻ ',convert(datetime,'26/05/2019 00:00:00'),53000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(47,N' Vô thường',1,25,N'2018',N'NXB Lao động ',convert(datetime,'26/05/2019 00:00:00'),67000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(48,N' Nghệ thuật quản lý tài chính cá nhân',3,26,N'2018',N'NXB Lao Động ',convert(datetime,'26/05/2019 00:00:00'),94100,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(49,N' Những cuộc phiêu lưu trong kinh doanh',2,27,N'2017',N'NXB Văn Học ',convert(datetime,'26/05/2019 00:00:00'),82500,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(50,N' Một đời quan trị',3,28,N'2017',N'NXB Trẻ ',convert(datetime,'26/05/2019 00:00:00'),108000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(51,N' Làm chủ quán cà phê',1,29,N'2018',N'Hồng Đức ',convert(datetime,'26/05/2019 00:00:00'),112000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(52,N'Dấn thân',2,30,N'2014',N'NXB trẻ ',convert(datetime,'26/05/2019 00:00:00'),736000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(53,N' Giận',1,31,N'2019',N'NXB Hồng Đức ',convert(datetime,'26/05/2019 00:00:00'),72000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(54,N' 3 người thầy vĩ đại',1,32,N'2018',N'NXB Lao động ',convert(datetime,'26/05/2019 00:00:00'),64000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(55,N'Hiểu về trái tim',1,33,N'2016',N'NXB Văn Học ',convert(datetime,'26/05/2019 00:00:00'),102000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(56,N'Kỹ năng tư duy logic',1,34,N'2018',N'NXB Văn Học ',convert(datetime,'26/05/2019 00:00:00'),80000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(57,N'Mặt nạ nam tính',1,35,N'2019',N'NXB Thế giới ',convert(datetime,'26/05/2019 00:00:00'),68000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(58,N'Để con được om',3,36,N'2018',N'NXB Văn Học ',convert(datetime,'26/05/2019  00:00:00'),78000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(59,N' Dạy con tư duy',1,37,N'2018',N'NXB Văn Học ',convert(datetime,'26/05/2019 00:00:00'),65000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(60,N'Dạy con theo cá tính của con',1,38,N'2018',N'NXB lao động ',convert(datetime,'26/05/2019 00:00:00'),48000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(61,N'Sự thật về 3 năm đầu đời của trẻ',2,39,N'2017',N'NXB thế giới ',convert(datetime,'26/05/2019 00:00:00'),74000,' ')
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(62,N'Lần đầu làm mẹ',1,40,N'2018',N'NXB Lao động ',convert(datetime,'26/05/2019 00:00:00'),158000,' ')
GO


USE [QLTV]
GO
CREATE TABLE [dbo].[tblquydinh](
	[id] [int] NOT NULL,
	[tuoitoithieu] [int] NOT NULL,
	[tuoitoida] [int] NOT NULL,
	[thoigiansudung] [int] NOT NULL,
	[sotheloaisachtoida] [int] NOT NULL,
	[sotacgiatoida] [int] NOT NULL,
	[khoangcachnamxuatban] [int] NOT NULL,
	[soluongsachmuontoida] [int] NOT NULL,
	[songaymuontoida] [int] not null

CONSTRAINT [PK_tblquydinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO
USE QLTV
INSERT INTO [dbo].[tblQuyDinh]([id],[tuoitoithieu],[tuoitoida],[thoigiansudung],[sotheloaisachtoida],[sotacgiatoida],[khoangcachnamxuatban],[soluongsachmuontoida],[songaymuontoida]) VALUES (1, 18,55,6,3,100,8,5,4)
GO


USE [QLTV]
GO
CREATE TABLE [dbo].[tblPhieuMuonSach](
	[maphieumuonsach] [int] NOT NULL,
	[madocgia] [int] NOT NULL,
	[ngaymuon] [datetime2](7) NOT NULL,
	[ngaydukientra] [datetime2](7) NOT NULL,
	[manhanvien] [int] NOT NULL,
CONSTRAINT [PK_tblPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]
GO
--USE QLTV
--INSERT INTO [dbo].[tblPhieuMuonSach]([maphieumuonsach],[madocgia],[ngaymuon],[ngaydukientra]) VALUES (N'1', N'2',convert(datetime,'05/11/2018'),convert(datetime,'05/15/2018'), 1)
--GO


USE [QLTV]
GO
CREATE TABLE [dbo].[tblChiTietPhieuMuonSach](
	[maphieumuonsach] [int] NOT NULL,
	[masach] [int],
	[TinhTrang] [nvarchar](50),
CONSTRAINT [PK_tblChiTietPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach], [masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]


USE [QLTV]
go
CREATE TABLE [dbo].[tblPhieuTraSach](
	[maphieutrasach] [int] NOT NULL,
	[madocgia] [int] NOT NULL,
	[ngaytra] [datetime2](7) NOT NULL,
	[manhanvien] [int] NOT NULL,
CONSTRAINT [PK_tblPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieutrasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

go
CREATE TABLE [dbo].[tblChiTietPhieuTraSach](
	[maphieutrasach] [int] NOT NULL,
	[masach] [int] NOT NULL,
	[TinhTrang] [nvarchar](20),
	[MaPhieuMuonSach] [int] Not null,
CONSTRAINT [PK_tblChiTietPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieutrasach], [masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

USE [QLTV]
go
CREATE TABLE [dbo].[tblBaoCaoThongKeMuonSachTheoTheLoai](
	[MaBaoCaoThongKeMuonSachTheoTheLoai] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[TongSoLuotMuon] [int] NOT NULL,
	[NgayLap] [datetime2](7) not null,
CONSTRAINT [PK_tblBaoCaoThongKeMuonSachTheoTheLoai] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoThongKeMuonSachTheoTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

go


CREATE TABLE [dbo].[tblChiTietBaoCaoThongKeMuonSachTheoTheLoai](
	[MaBaoCaoThongKeMuonSachTheoTheLoai] [int] NOT NULL,
	[MaTheLoaiSach] [int] NOT NULL,
	[SoLuotMuon] [int] NOT NULL,
	[TyLe] [float] NOT NULL,
CONSTRAINT [PK_tblChiTietBaoCaoThongKeMuonSachTheoTheLoai] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoThongKeMuonSachTheoTheLoai], [MaTheLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]


USE [QLTV]
go
CREATE TABLE [dbo].[tblBaoCaoThongKeSachTraTre](
	[MaBaoCaoThongKeSachTraTre] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[NgayLap] [datetime2](7) NOT NULL,
CONSTRAINT [PK_tblBaoCaoThongKeSachTraTre] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoThongKeSachTraTre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

go


CREATE TABLE [dbo].[tblChiTietBaoCaoThongKeSachTraTre](
	[MaBaoCaoThongKeSachTraTre] [int] NOT NULL,
	[tensach] [nvarchar](50) NOT NULL,
	[ngaymuon] [datetime2](7) NOT NULL,
	[songaytratre] [int] NOT NULL,
CONSTRAINT [PK_tblChiTietBaoCaoThongKeSachTraTre] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoThongKeSachTraTre], [TenSach],[ngaymuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]


select [TenTheLoaiSach],count([TenTheLoaiSach]) as [SoLuotMuon], count([TenTheLoaiSach])*1.0 / (select count([masach]) from [tblChiTietPhieuMuonSach])*100 as [TyLe], (select count([masach]) from [tblChiTietPhieuMuonSach]) as [TongSoLuotMuon]
from [tblChiTietPhieuMuonSach],[tblSach],[tblTheLoaiSach],[tblPhieuMuonSach]
 where [tblChiTietPhieuMuonSach].[masach] = [tblSach].[MaSach]
And [tblSach].[MaTheLoaiSach]=[tblTheLoaiSach].[MaTheLoaiSach]
And [tblChiTietPhieuMuonSach].[maphieumuonsach]=[tblPhieuMuonSach].[maphieumuonsach]
--And [tblsach].[MaTheLoaiSach] =2
And MONTH([ngaymuon])=5
--And year([ngaymuon]) =2018
group by [TenTheLoaiSach]
select [tensach],[ngaymuon],DATEDIFF ( day , [ngaydukientra] , [ngaytra] ) as Songaytratre
from [tblChiTietPhieuTraSach],[tblPhieuTraSach],[tblSach],[tblPhieuMuonSach]
where [tblChiTietPhieuTraSach].[maphieutrasach]=[tblPhieuTraSach].[maphieutrasach]
and [tblSach].[MaSach]=[tblChiTietPhieuTraSach].[masach]
and [tblChiTietPhieuTraSach].[MaPhieuMuonSach]=[tblPhieuMuonSach].[maphieumuonsach]


USE [QLTV]
go
CREATE TABLE [dbo].[tblLogin](
	[username] [nvarchar] (15) NOT NULL,
	[password] [nvarchar](20) NOT NULL,
	[manhanvien] [int] NOT NULL,

CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED 
(
	[username]  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

USE [QLTV]
go

CREATE TABLE [dbo].[tblNhanVien](
	[manhanvien] [int] NOT NULL,
	[hovaten] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylap] [datetime2](7) NOT NULL,
	
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLTV]
GO
INSERT INTO[dbo].[tblLogin] ([username],[password],[manhanvien]) VALUES(N'DungNgoc',N'26121997',1)

USE [QLTV]
GO
INSERT INTO[dbo].[tblLogin] ([username],[password],[manhanvien]) VALUES(N'HuynhViet',N'20061998',3)

USE [QLTV]
go
INSERT INTO[dbo].[tblLogIn]([Username],[PassWord],[manhanvien]) VALUES(N'Ton',N'02101998',2)
Go

INSERT INTO [dbo].[tblNhanVien]([manhanvien],[hovaten],[ngaysinh], [diachi], [email], [ngaylap]) VALUES(1,N'Nguyễn Ngọc Dung',convert(datetime,'12/26/1997 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'05/05/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblNhanVien]([manhanvien],[hovaten],[ngaysinh], [diachi], [email], [ngaylap]) VALUES(2,N'Phan Minh Toàn',convert(datetime,'10/02/1998 00:00:00'),N'Bắc Bình, Bình Thuận',N'16521261@gm.uit.edu.vn',convert(datetime,'05/05/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblNhanVien]([manhanvien],[hovaten],[ngaysinh], [diachi], [email], [ngaylap]) VALUES(3,N'Võ Huỳnh Việt',convert(datetime,'06/20/1998 00:00:00'),N'Nha Trang, Khánh Hòa',N'16521436@gm.uit.edu.vn',convert(datetime,'05/05/2019 00:00:00',101))
GO


--USE [QLTV]
--go
--ALTER TABLE tblDocGia ADD CONSTRAINT fk_1 FOREIGN KEY(MaLoaiDocGia) REFERENCES TblLoaiDocGia(MaLoaiDocGia)
--ALTER TABLE tblSach ADD CONSTRAINT fk_2 FOREIGN KEY(MaTheLoaiSach) REFERENCES TblTheLoaiSach(MaTheLoaiSach)
--ALTER TABLE tblSach add constraint fk_3 foreign key (matacgia) references tblTacGia(matacgia)
--ALTER TABLE tblSach ADD CONSTRAINT fk_3 FOREIGN KEY(MaTacGia) REFERENCES TblTacGia(MaTacGia)
--ALTER TABLE tblPhieuMuonSach ADD CONSTRAINT fk_4 FOREIGN KEY(MaDocGia) REFERENCES TblDocGia(MaDocGia)
--ALTER TABLE tblChitietPhieuMuonSach ADD CONSTRAINT fk_5 FOREIGN KEY(MaPhieuMuonSach) REFERENCES TblPhieuMuonSach(MaPhieuMuonSach)
--ALTER TABLE tblChiTietPhieuMuonSach ADD CONSTRAINT fk_6 FOREIGN KEY(MaSach) REFERENCES TblSach(MaSach)
--ALTER TABLE tblPhieuTraSach ADD CONSTRAINT fk_7 FOREIGN KEY(MaDocGia) REFERENCES TblDocGia(MaDocGa)
--ALTER TABLE tblChiTietPhieuTraSach ADD CONSTRAINT fk_8 FOREIGN KEY(MaPhieuTraSach) REFERENCES TblPhieuTraSach(MaPhieuTraSach)
--ALTER TABLE tblChiTietPhieuTraSach ADD CONSTRAINT fk_9 FOREIGN KEY(MaPhieuMuonSach) REFERENCES TblPhieuMuonSach(MaPhieuMuonSach)
--ALTER TABLE tblChiTietPhieuTraSach ADD CONSTRAINT fk_10 FOREIGN KEY(MaSach) REFERENCES TblSach(MaSach)
--ALTER TABLE tblPhieuMuonSach ADD CONSTRAINT fk_4 FOREIGN KEY(MaDocGia) REFERENCES TblDocGia(MaDocGa)
--ALTER TABLE tblPhieuMuonSach ADD CONSTRAINT fk_4 FOREIGN KEY(MaDocGia) REFERENCES TblDocGia(MaDocGa)

--ALTER TABLE tblPhieuMuonSach ADD CONSTRAINT fk_4 FOREIGN KEY(MaDocGia) REFERENCES TblDocGia(MaDocGa)
--ALTER TABLE tblPhieuMuonSach ADD CONSTRAINT fk_4 FOREIGN KEY(MaDocGia) REFERENCES TblDocGia(MaDocGa)
