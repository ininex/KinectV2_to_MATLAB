# KinectV2_to_MATLAB
Import Kinect V2 (New Sensor) Skeleton Joints Points Cloud to MATLAB for Further Analysis

Want to explore more? Check my ChallengePost below:)
http://challengepost.com/ininex?ref_content=user-portfolio&ref_feature=portfolio&ref_medium=global-nav
# Steps to follow:
1. Download the KinectV2_to_MATLAB folder under KinectV2_to_MATLAB repository. MAKE SURE YOU HAVE VISUAL STUDIO 2013 TO COMPILE IT.
2. Before running the project, MODIFY THIS LINE OR IT WILL NOT RUN: String savepath = @"$MAKE SURE YOU ENTER YOUR DESIRED SAVING PATH HERE$\Joints_Locs.txt"; Just replace "$MAKE SURE YOU ENTER YOUR DESIRED SAVING PATH HERE$" with the output joint coordinate path you want. THEN EVERYTHING WILL WORK.
3. Plug in Kinect V2 for Windows, if all drivers have been installed, compile the project. It will detect the Kinect and present Color stream automatically. Make some gesture in front of the device and skeleton positions will be recorded.
4. Locate Joints_Locs.txt and import it using MATLAB built-in import feature. Import it as a numeric matrix. 
5. Download MATLAB_Support folder to your MATLAB default folder under your document folder.
6. Use JointsCloudSpliter.m function to view the imported points cloud.

# NOTE: 
1. This the first version, it will be improved with automatically importing feature when I have time. 
2. Now points cloud can only be imported manually by clicking the import button on the top of MATLAB menu. Then it is recommended to imported it as numberic matrix. Also, make sure you set up the rule of excluding the blank row.
3. Reference: http://pterneas.com/2014/02/20/kinect-for-windows-version-2-color-depth-and-infrared-streams/
