# Chương Trình Quảng lý kế hoạch

## Mô tả
 >  Phần mềm giúp bạn theo dỏi lịch trình và thống kê lịch trình của bạn.

## 1/Cơ sở dữ liệu
  1. Bảng công việc
    1. Mã công Việc(Khóa chính)
    2. Tên công việc
    3. Loại công Việc (Dài ngày, Hằng ngày, Ngắn ngày)
    4. Tính chất (Thư giản, việc chân tay, Việc Trí óc)
    5. Trạng thái (Đang ngóng, Đang làm, Hoàn thành, Drop)
    6. Ngày thực hiện cuối cùng
  2. Bảng kế hoạch
    - Id (Khóa chính)
    - Mã công việc (Kéo từ Khóa Mã Công việc của bảng 1)
    - Thời gian bắt đầu (Không thể NULL)
    - Thời gian kết thúc (Có thể NULL)
  3. Bảng thực trạng
    - Id (Khóa chính)
    - Mã công việc (Kéo từ Khóa mã công việc của bảng 1)
    - Thời gian bắt đầu (Không thể NULL)
    - Thời gian kết thúc(Có thể NULL)

## Các chức năng
- Thêm 1 công việc mới
- Tạo bảng kế hoạch
- Record thời gian làm 1 công việc để lưu vào bảng thực trạng.
- Đưa ra biểu đồ thống kê các việc làm dựa trên điểm tính chất của mỗi việc làm.
- Cho xem lịch trình hằng ngày.
- Xác định mục tiêu trong tháng dựa trên các công việc dài Ngày.
- Thông báo deadline và thời điểm bắt đầu trước vài ngày.
