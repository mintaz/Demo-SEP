using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DicBLL
    {
        public string defaultPass()
        {
            return "vanlang";
        }
        public string sysllabusobj(string mes)
        {
            switch (mes)
            {
                case "success":
                    return "Thêm mục tiêu môn học thành công.";
                case "del":
                    return "Xóa mục tiêu môn học thành công.";
                case "edit":
                    return "Chỉnh sửa mục tiêu môn học thành công.";
                case "missingcontent":
                    return "Nội dung mục tiêu bị trống.";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string sysllabusout(string mes)
        {
            switch (mes)
            {
                case "success":
                    return "Thêm chuẩn đầu ra môn học thành công.";
                case "del":
                    return "Xóa chuẩn đầu ra môn học thành công.";
                case "edit":
                    return "Chỉnh sửa chuẩn đầu ra môn học thành công.";
                case "missingcontent":
                    return "Nội dung chuẩn đầu ra bị trống.";
                case "missingno":
                    return "Ký hiệu chuẩn đầu ra bị trống.";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string syllabusinfo(string mes)
        {
            switch (mes)
            {
                case "success":
                    return "Cập nhập thông tin môn học thành công.";
                case "level":
                    return "Trình độ đào tạo còn trống.";
                case "time":
                    return "Phân bổ thời gian còn trống.";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string successcreatsyllabus(string sc)
        {
            switch (sc)
            {
                case "success":
                    return "Tạo môn học thành công.";
                case "edit":
                    return "Chỉnh sửa môn học thành công.";
                case "name":
                    return "Tên Môn Học còn trống.";
                case "code":
                    return "Mã Môn Học còn trống.";
                case "TC":
                    return "Thông tin số tín chỉ còn trống.";
                case "LT":
                    return "Số giờ lý thuyết còn trống.";
                case "content":
                    return "Thông tin nội dung môn học còn trống.";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string successupdateprogram(string sc)
        {
            switch (sc)
            {
                case "success":
                    return "Cập nhập thông tin chương trình đào tạo thành công.";
                case "level":
                    return "Thông tin Trình Độ Đào Tạo còn trống.";
                case "branch":
                    return "Thông tin Ngành Đào Tạo còn trống.";
                case "type":
                    return "Thông tin Loại Hình Đào Tạo còn trống.";
                case "time":
                    return "Thông tin Thời Gian Đào Tạo còn trống.";
                case "vol":
                    return "Thông tin Khối Lượng Kiến Thức còn trống.";
                case "actor":
                    return "Thông tin Đối Tượng Đào Tạo còn trống.";
                case "process":
                    return "Thông tin Quy Trình Đào Tạo, Điều Kiện Tốt Nghiệp còn trống.";
                case "10":
                    return "Thông tin Thanh Điểm bị sai định dạng hoặc bỏ trống.";
                case "sem":
                    return "Thông tin Học Kỳ bị sai định dạng hoặc bỏ trống.";
                case "tc":
                    return "Thông tin Tín Chỉ Toàn Khóa bị sai định dạng hoặc bỏ trống.";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string errorloginMessage(string error)
        {
            switch (error)
            {
                case "chua active":
                    return "Tài khoản của bạn chưa được kích hoạt. \n Vui lòng liên hệ người quản trị để kích hoạt";
                case "sai pass":
                    return "Bạn đã nhập sai mật khẩu. \n Vui lòng kiểm tra lại.";
                case "sai user":
                    return "Bạn đã nhập sai tên đăng nhập hoặc tài khoản của bạn không tồn tại trong hệ thống. \n Vui lòng kiểm tra lại";
                case "sai email":
                    return "Bạn đã nhập sai tên đăng nhập. \n Vui lòng kiểm tra lại";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string successResetMessage()
        {
            return "Đặt lại mật khẩu thành công.\n Mật khẩu mặc định là vanlang";
        }
        public string errorResetMessage(string error)
        {
            switch (error)
            {
                case "sai user":
                    return "Bạn đã nhập sai tên đăng nhập hoặc tài khoản của bạn không tồn tại trong hệ thống. \n Vui lòng kiểm tra lại";
                case "sai email":
                    return "Bạn đã nhập sai tên đăng nhập. \n Vui lòng kiểm tra lại";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string errorAccountMessage(string error)
        {
            switch (error)
            {
                case "sai email":
                    return "Email không hợp lệ. \n Vui lòng kiểm tra lại";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }

        public string successAccountMessage(string sc)
        {
            switch (sc)
            {
                case "add":
                    return "Thêm tài khoản thành công.";
                case "edit":
                    return "Sửa tài khoản thành công.";
                case "delete":
                    return "Xóa tài khoản thành công.";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";

            }
        }

        public string errorChangeMessage(string er)
        {
            switch (er)
            {
                case "samepass":
                    return "Mật khẩu mới phải khác mật khẩu cũ.\n Vui lòng kiểm tra lại.";
                case "samename":
                    return "Họ và tên không thay đổi.";
                case "confirm":
                    return "Mật khẩu mới và Mật khẩu xác nhận không khớp.\n Vui lòng kiểm tra lại";
                case "wrongpass":
                    return "Mật khẩu cũ không đúng. \n Vui lòng kiểm tra lại.";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string successChangeMessage(string sc)
        {
            switch (sc)
            {
                case "changepass":
                    return "Thay đổi mật khẩu thành công";
                case "changename":
                    return "Thay đổi tên thành công";
                case "changeinfo":
                    return "Thay đổi thông tin cá nhân thành công";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string errorCreateProgram(string er)
        {
            switch (er)
            {
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string successCreateProgram(string sc)
        {
            switch (sc)
            {
                case "editprogram":
                    return "Chỉnh sửa chương trình đào tạo thành công";
                case "createprogram":
                    return "Tạo chương trình đào tạo mới thành công";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string successProgramOut(string sc)
        {
            switch (sc)
            {
                case "addprogramoutcome":
                    return "Thêm chuẩn đầu ra thành công";
                case "editprogramoutcome":
                    return "Chỉnh sửa chuẩn đầu ra thành công";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string errorProOut(string er)
        {
            switch (er)
            {
                case "sameno":
                    return "Trùng số chuẩn đầu ra.\nVui lòng kiểm tra lại";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
    }
}
