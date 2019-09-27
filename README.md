# Phần mềm Planning App

## Mô tả
 > Thời buổi công nghệ tiên tiến, xã hội ngày càng phát triển, để bắt kịp nhịp
 > độ của cuộc sống mỗi ngày chúng ta phải học tập, làm việc, rèn luyện rất nhiều.
 > Do đó app ra đời đáp ứng nhu cầu của mỗi cá nhân. Lấy ý tưởng từ các trò chơi,
 > app được thiết kế để người dùng có thể trải nghiệm như một nhân vật trong game
 > RPG giúp tạo động lực cho người dùng để hoàn thành các mục tiêu trong học
 > tập, công việc và đời sống.

## Tính năng nổi bật
 > Thêm các thói quen, mục tiêu hằng này, mục việc cần làm
 > Tạo một nhân vật theo cách riêng của bạn
 > Thực hiện các công việc đề ra để thăng cấp nhân vật của bạn, mở khóa đặc tính như áo giáp
   thú nuôi, kỹ năng và thậm chí là nhiệm vụ
 > Kết nối với bạn bè để đánh quái vật, sử dụng vàng của bạn để nhận các phần
   thưởng trong game (như trang bị, các giải thưởng tùy chỉnh,vv...)

## 1/Cơ sở dữ liệu
  1. Bảng Công việc
    ..* Mã Công Việc(Khóa chính)
    ..* Tên Công việc
    ..* Loại Công Việc(Dài ngày, Hằng ngày, Làm một lần,vv..)
    ..* Tính chất(Thói quen, Học tập, Công việc, Việc nhà,vv..)
    ..* Trạng thái(Đang chờ, Đang làm, Hoàn thành, Drop)
    ..* Ngày thực hiện cuối cùng
  2. Bảng kế hoạch
    ..* Id(Khóa chính)
    ..* Mã Công việc(Kéo từ Khóa Mã Công việc của bảng 1)
    ..* Thời gian bắt đầu (Ko thể NULL)
    ..* Thời gian kết thúc(Có thể NULL)
  3. Bảng thực trạng
    ..* Id(Khóa chính)
    ..* Mã Công việc(Kéo từ Khóa Mã Công việc của bảng 1)
    ..* Thời gian bắt đầu (Ko thể NULL)
    ..* Thời gian kết thúc(Có thể NULL)

## Các chức năng
- Thêm 1 công việc mới
- Tăng điểm khi hoàn thành công việc, trừ điểm khi không hoàn thành
- Các việc đã hoàn thành sẽ được tích điểm vào các hạng mục thành tựu khác nhau
- Cho xem các công việc theo các hạng mục
- Lọc các công việc để hiển thị (theo loại, mức độ)
- Hiển thị deadline cho các công việc
