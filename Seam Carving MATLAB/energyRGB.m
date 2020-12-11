function res = energyRGB(I)
% Input: Ảnh màu (3 kênh màu)
% Output: Một mảng 2 chiều thể hiện năng lượng của các điểm trong ảnh.
% e = |dI/dx| + |dI/dy|
% Vì ảnh có 3 kênh màu nên ta trả ra tổng năng lượng theo 3 kênh màu
res = energyGrey(I(:, :, 1))+energyGrey(I(:, :, 2))+energyGrey(I(:, :, 3));
end

