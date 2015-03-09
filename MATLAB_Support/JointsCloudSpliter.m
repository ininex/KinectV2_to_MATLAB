function JointsCloudSpliter(clouds)
% Split clouds (nx3 matrix) into 24x3 chunks
i = 0;
j = 1;
k = i;
while k<=length(clouds)
        clf('reset');
        x = clouds([1+i*25:1+j*25],1);
        y = clouds([1+i*25:1+j*25],2);
        z = clouds([1+i*25:1+j*25],3);
        plot3([x(1) x(2)],[z(1) z(2)],[y(1) y(2)]);hold on
        plot3([x(3) x(4)],[z(3) z(4)],[y(3) y(4)]);hold on
        plot3([x(5) x(6)],[z(5) z(6)],[y(5) y(6)]);hold on
        plot3([x(7) x(8)],[z(7) z(8)],[y(7) y(8)]);hold on
        plot3([x(9) x(10)],[z(9) z(10)],[y(9) y(10)]);hold on
        plot3([x(11) x(12)],[z(11) z(12)],[y(11) y(12)]);hold on
        plot3([x(13) x(14)],[z(13) z(14)],[y(13) y(14)]);hold on
        plot3([x(15) x(16)],[z(15) z(16)],[y(15) y(16)]);hold on
        plot3([x(17) x(18)],[z(17) z(18)],[y(17) y(18)]);hold on
        plot3([x(19) x(20)],[z(19) z(20)],[y(19) y(20)]);hold on
%         plot3([x(21) x(22)],[z(21) z(22)],[y(21) y(22)]);hold on
%         plot3([x(23) x(24)],[z(23) z(24)],[y(23) y(24)]);hold on
%         plot3([x(25) x(26)],[z(25) z(26)],[y(25) y(26)]);hold on
        i=i+1;
        j=j+1;
        k=i*24;
        scatter3(x,z,y,'fill');axis([-3 3 -3 3 -2 2]);hold on
        pause(0.06);
end