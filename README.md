<<<<<<< HEAD
# Phần mềm Planning App

## Mô tả
 > Thời buổi công nghệ tiên tiến, xã hội ngày càng phát triển, để bắt kịp nhịp
 > độ của cuộc sống mỗi ngày chúng ta phải học tập, làm việc, rèn luyện rất nhiều.
 > Do đó app ra đời đáp ứng nhu cầu của mỗi cá nhân. Lấy ý tưởng từ các trò chơi,
 > app được thiết kế để người dùng có thể trải nghiệm như một nhân vật trong game
 > RPG giúp tạo động lực cho người dùng để hoàn thành các mục tiêu trong học
 > tập, công việc và đời sống.

## Tính năng nổi bật
 - Thêm các thói quen, mục tiêu hằng này, mục việc cần làm
 - Tạo một nhân vật theo cách riêng của bạn
 - Thực hiện các công việc đề ra để thăng cấp nhân vật của bạn, mở khóa nhiệm vụ
 - Làm quest để nhận các phần thưởng

## Cơ sở dữ liệu
1. Bảng Công việc
- Mã Công Việc(Khóa chính)
- Tên Công việc
- Loại Công Việc(Dài ngày, Hằng ngày, Làm một lần,vv..)
- Tính chất(Thói quen, Học tập, Công việc, Việc nhà,vv..)
- Trạng thái(Đang chờ, Đang làm, Hoàn thành, Drop)
- Ngày thực hiện cuối cùng

2. Bảng kế hoạch
- Id(Khóa chính)
- Mã Công việc(Kéo từ Khóa Mã Công việc của bảng 1)
- Thời gian bắt đầu (Ko thể NULL)
- Thời gian kết thúc(Có thể NULL)
3. Bảng thực trạng

- Id(Khóa chính)
- Mã Công việc(Kéo từ Khóa Mã Công việc của bảng 1)
- Thời gian bắt đầu (Ko thể NULL)
- Thời gian kết thúc(Có thể NULL)

## Các chức năng
- Thêm 1 công việc mới
<<<<<<< HEAD
- Tạo bảng kế hoạch
- Ghi nhận thời gian làm 1 công việc để lưu vào bảng thực trạng.
- Đưa ra biểu đồ thống kê các việc làm dựa trên điểm tính chất của mỗi việc làm.
- Cho xem lịch trình hằng ngày.
- Xác định mục tiêu trong tháng dựa trên các công việc dài Ngày.
- Thông báo deadline và thời điểm bắt đầu trước vài ngày.
## Các thành viên nhóm:
- Trần Hữu Anh Khoa
> MSSV: 18520937.
> Khoa: Khoa học máy tính.
> Email:
- Trần Nguyễn Thanh Nguyên
> MSSV: 18521168.
> Khoa: Khoa học máy tính.
> Email:
- Lê Đại Dương 
> MSSV: 18520028
> Khoa : công nghệ phần mềm
> Email: 
=======
- Tăng điểm khi hoàn thành công việc, trừ điểm khi không hoàn thành
- Các việc đã hoàn thành sẽ được tích điểm vào các hạng mục thành tựu khác nhau
- Cho xem các công việc theo các hạng mục
- Lọc các công việc để hiển thị (theo loại, mức độ)
- Hiển thị deadline cho các công việc
## ROADMAP:

 ![alt text](https://github.com/bichu136/Planning-App/raw/master/UI/Road_map.png "Road map")
>>>>>>> 136b7cab4915d2143cd345d06dc2e0e53f0d7859

## Dependency:
- DevExpress: https://go.devexpress.com/DevexpressDownload_UniversalTrial.aspx (Download link)
=======
# Project-Mau
nhung bai tap tu dat ra
>>>>>>> 8e515b00fcda2cc65eb51f10fb373f873f8e2dba
