function [optSeamMask, seamEnergy, M] = findOptSeam(energy)
% Input: mảng 2 chiều là năng lượng của các điểm ảnh
% Output: Đường seam dọc tối ưu & năng lượng
% Mảng optSeamMask gồm 0/1, với 0 thể hiện điểm đó thuộc đường seam
% Để tìm đường seam ngang tối ưu, cho Input là ma trận chuyển vị
% Tính mảng quy hoạch động M cho các đường seam dọc
M = padarray(energy, [0 1],intmax('uint8')); %Tạo trước M là ma trận E với max padding 
sz = size(M);
for i = 2 : sz(1)
for j = 2 : (sz(2) - 1)
neighbors = [M(i - 1, j - 1) M(i - 1, j) M(i - 1, j + 1)];
M(i, j) = M(i, j) + min(neighbors);
end
end
% Tìm phần tử nhỏ nhất hàng cuối
[val, indJ] = min(M(sz(1), :));
seamEnergy = val;
optSeamMask = zeros(size(energy), 'uint8');
% Đi ngược lại và truy vết
for i = sz(1) : -1 : 2
% optSeam(i) = indJ - 1;
optSeamMask(i, indJ - 1) = 1; % -1 vì lúc đầu ta thêm một cột 0 vào bên trái
neighbors = [M(i - 1, indJ - 1) M(i - 1, indJ) M(i - 1, indJ + 1)];
[val, indIncr] = min(neighbors);
seamEnergy = seamEnergy + val;
indJ = indJ + (indIncr - 2); % (x - 2): [1,2]->[-1,1]]
end
optSeamMask(1, indJ - 1) = 1; % -1 vì lúc đầu ta thêm một cột 0 vào bên trái
optSeamMask = ~optSeamMask;
end