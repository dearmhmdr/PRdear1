
alter table dosen alter column Nama_Dosen varchar(200)

select m.kode_mahasiswa, m.Nama_Mahasiswa, j.nama_jurusan, a.deskripsi as Agama
from mahasiswa m join jurusan j on m.kode_jurusan=j.kode_jurusan
join agama a on m.kode_agama = a.kode_agama where m.kode_mahasiswa='M001'

select * from mahasiswa m join jurusan j on  m.kode_jurusan=j.kode_jurusan
where j.Status_jurusan = 'Non Aktif'

select * from mahasiswa m join jurusan j on m.kode_jurusan=j.kode_jurusan
join  nilai n on m.kode_mahasiswa=n.kode_mahasiswa where  j.Status_jurusan = 'Aktif' and n.nilai>80

select * from jurusan where nama_jurusan like  '%sistem%'

select Nama_mahasiswa, count(*) from nilai n
join  mahasiswa m on n.kode_mahasiswa=m.kode_mahasiswa group by m.nama_mahasiswa having count(*)>1

select m.kode_mahasiswa, m.nama_Mahasiswa, j.Nama_Jurusan, a.deskripsi as Agama, d.Nama_Dosen,j.Status_Jurusan, t.Deskripsi
from mahasiswa m join jurusan j on m.kode_jurusan=j.kode_jurusan
join agama a on m.kode_agama = a.kode_agama left join dosen d on  j.kode_jurusan=d.kode_jurusan LEFT JOIN Type_Dosen t ON d.Kode_Type_Dosen = t.Kode_Type_Dosen 
WHERE Nama_Mahasiswa LIKE '%Budi%'

create view tampil as
select m.kode_mahasiswa, m.nama_Mahasiswa, j.Nama_Jurusan, a.deskripsi as Agama, d.Nama_Dosen,j.Status_Jurusan, t.Deskripsi
from mahasiswa m join jurusan j on m.kode_jurusan=j.kode_jurusan
join agama a on m.kode_agama = a.kode_agama left join dosen d on  j.kode_jurusan=d.kode_jurusan LEFT JOIN Type_Dosen t ON d.Kode_Type_Dosen = t.Kode_Type_Dosen 
WHERE Nama_Mahasiswa LIKE '%Budi%'

select *from tampil


select * from mahasiswa m
left join nilai n on m.kode_mahasiswa=n.kode_mahasiswa