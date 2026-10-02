Câu 1 :Trình bày sự khác nhau giữa Value Types (Kiểu giá trị) và Reference Types (Kiểu tham chiếu) trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).
Value Types: Lưu trực tiếp giá trị trong vùng nhớ. Thường được lưu trên Stack khi là biến cục bộ.
Ví dụ: int, double, bool, struct, enum.
Khi gán biến này cho biến khác, giá trị được sao chép.

Reference Types: Biến lưu địa chỉ tham chiếu đến đối tượng được cấp phát trên Heap.
Ví dụ: class, string, array, object.
Khi gán biến này cho biến khác, tham chiếu được sao chép, hai biến có thể cùng trỏ đến một đối tượng.

Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính
có set thông thường? Nêu trường hợp sử dụng thực tế.
Trong C# 9/10, Init-only Properties (init) cho phép một thuộc tính chỉ được gán giá trị trong quá trình khởi tạo đối tượng và không thể thay đổi sau khi đối tượng đã được tạo. Khác với set, thuộc tính sử dụng set có thể được gán hoặc thay đổi bất kỳ lúc nào, còn init giúp dữ liệu của đối tượng được cố định sau khi khởi tạo

Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương
thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).
Trong tính đa hình (Polymorphism) của C#, virtual được khai báo ở lớp cha để cho phép phương thức được lớp con ghi đè, còn override được khai báo ở lớp con để thay thế cách triển khai của phương thức virtual từ lớp cha. Khi gọi phương thức, nếu đối tượng thực tế thuộc lớp con thì phương thức override của lớp con sẽ được thực thi. Như vậy, virtual có nhiệm vụ cho phép ghi đè, còn override thực hiện việc ghi đè và tạo ra hành vi đa hình.


Câu 4: Tại sao một thành phần được khai báo là static trong Lớp (Class) lại không thể
truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử new?
Trong C#, thành phần được khai báo static thuộc về lớp (Class) chứ không thuộc về một đối tượng (Object Instance) cụ thể. Khi sử dụng toán tử new, mỗi đối tượng được tạo ra có dữ liệu và trạng thái riêng, trong khi thành phần static chỉ tồn tại một bản duy nhất và được dùng chung cho tất cả các đối tượng của lớp. Vì vậy, static không thể truy xuất thông qua một đối tượng mà phải truy xuất thông qua tên lớp. 