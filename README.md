# KinectV2_to_MATLAB
Import Kinect V2 (New Sensor) Skeleton Joints Points Cloud to MATLAB for Further Analysis
# Steps to follow:
1. Download the KinectV2_to_MATLAB folder under KinectV2_to_MATLAB repository. MAKE SURE YOU HAVE VISUAL STUDIO 2013 TO COMPILE IT.
2. Plug in Kinect V2 for Windows, if all drivers have been installed, compile the project. It will detect the Kinect and present Color stream automatically. Make some gesture in front of the device and skeleton positions will be recorded.
3. Go to this folder: "C:\Users\$YOUR USER NAME$\Documents\MATLAB\KINECT V2 TEST\Joints_Locs.txt" to find the joints coordinates Joints_Locs.txt file to import to MATLAB, if it is not existed then the program will automatically create a new folder.
4. Download MATLAB_Support folder to your MATLAB default folder under your document folder.
5. Use JointsCloudSpliter.m function to view the imported points cloud.

# NOTE: 
1. This the first version, it will be improved with automatically importing feature when I have time. 
2. Now points cloud can only be imported manually by clicking the import button on the top of MATLAB menu. Then it is recommended to imported it as numberic matrix. Also, make sure you set up the rule of excluding the blank row.
3. Reference: http://pterneas.com/2014/02/20/kinect-for-windows-version-2-color-depth-and-infrared-streams/
