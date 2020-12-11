function res = energyGrey(I)
% Input: Ảnh đen trắng
% Output: Một mảng 2 chiều thể hiện năng lượng của các điểm trong ảnh.
% e = |dI/dx| + |dI/dy|
res = abs(imfilter(I, [-1,0,1],'replicate')) + abs(imfilter(I, [-1;0;1],'replicate'));
end