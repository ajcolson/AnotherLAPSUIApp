# AnotherLAPSUIApp
 A replacement GUI app for looking up Windows LAPS passwords.

# Notes
 This app is designed to leverage PowerShell to look up the "ms-Mcs-AdmPwd" property in Active Directory and with the idea that if you work in a multi-domain enivorment, you can run the built executable as a user from each respective domain.
 
 If you are actually wanting to build and deploy this in your own enviroment, be sure to update the list of DCs in Resources file for the project.

 Finally, I know the methods used to retrieve the password are not optimal or ideal. This project was built originally to aid users who _could_ run powershell on their workstation to lookup passwords, but _didn't want to_ run the powershell themselves. 
