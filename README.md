# Chương Trình Quảng lý kế hoạch

## Mô tả
 >  Phần mềm giúp bạn theo dỏi lịch trình và thống kê lịch trình của bạn.

## 1/Cơ sở dữ liệu
  1. Bảng Công việc
    1. Mã Công Việc(Khóa chính)
    2. Tên Công việc
    3. Loại Công Việc(Dài ngày, Hằng ngày, Ngắn ngày)
    4. Tính chất(Thư giản, việc chân tay, Việc Trí óc)
    5. Trạng thái(Đang ngóng, Đang làm, Hoàn thành, Drop)
    6. Ngày thực hiện cuối cùng
  2. Bảng kế hoạch
    - Id(Khóa chính)
    - Mã Công việc(Kéo từ Khóa Mã Công việc của bảng 1)
    - Thời gian bắt đầu (Ko thể NULL)
    - Thời gian kết thúc(Có thể NULL)
  3. Bảng thực trạng
    - Id(Khóa chính)
    - Mã Công việc(Kéo từ Khóa Mã Công việc của bảng 1)
    - Thời gian bắt đầu (Ko thể NULL)
    - Thời gian kết thúc(Có thể NULL

## Các chức năng
- thêm 1 công việc mới
- tạo bảng kế hoạch
- record thời gian làm 1 công việc để lưu vào bảng thực trạng.
- đưa ra biểu đồ thống kê các việc làm dựa trên điểm tính chất của mỗi việc làm.
- cho xem lịch trình Hằng ngày,
- xác định mục tiêu trong tháng dựa trên các công việc Dài Ngày.
- Thông báo deadline và thời điểm bắt đầu trc vài ngày.
