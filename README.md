# PS5 - URC - Users and Roles 

Authors: Peter Forsling u0960779<br />
Date: October 12, 2020 <br />
Course: CS 4540, University of Utah, School of Computing <br />
Copyright: CS 4540, Peter Forsling - This work may not be copied for use in Academic Coursework. <br />

Deployed URL: TBD<br />
Github Page: https://github.com/uofu-cs4540-fall2020/ps4-urc-continued-pf_ps4 



## Assignment Specific Writeups

<h3>Assignment 1</h3>
<h4>UI/UX Decisions</h4>

For Opportunities, it was decided to try and replicate something similar to [Old Reddit's](https://www.reddit.com) post feed.
The post feed style contains a lot of data that will allow users in future versions
of this project to use functionalities like searching, filtering by keyword, and sorting 
by various custom criteria to find the research project they are interested in. This decision was made because the style of Reddit has been widely copied across many websites on the internet, and this should give our users an intuitive familiarity with the flow and organization of our website.

For Details, it was decided to try and replicate something similar to LinkedIn's Job page, specifically the middle section with the job details. This decision was made because it nicely categorizes information and actions like applying to the job or contacting the poster are visible and easy to do.

<h3>Assignment 2</h3>

Bootstrap improved the site with its reactive properties and modern style. The reactive properties make the website more dynamic in regards to things like screen sizes or device. It also streamlined the creation of
list or table-like properties on the website. 

Bootstrap Components used: NavBar, Jumbotron, Buttons, Rows and Columns, Text input forms, File input forms, various customizing classes (ex: bg-white).

The dropdown menu will pull users' attention to it by showing all of the visitable pages in a list form. The username dropdown with the logout button wasn't specified to be done this way, but it keeps everything user-related encapsulated into one convienient dropdown menu. 

<h3>Assignment 5</h3>
<h4>Observations on Authentication and Authorization</h4>

For some reason, Authorization needs to be loaded before authentication and I truly have no idea why. Interesting things I have done with the assignment is making sure that only authorized users had access to certain
webpages, and additionally updated the NavBar to make sure each role only has access to their respective pages, except for the TA dropdown menu. I did this by injecting the SignInManager into _Layout.cshtml. Unfortunately, I couldn't figure out where the automatically generated "Acess denied" page was, and ended up having to make my own custom one for professors trying to edit opportunities that aren't their own.

<h4>Above and Beyond paragraph</h4>

In the Roles Table section of the assignment, I utilized the SweetAlerts2 and DataTables JavaScript Libraries. (CDN Links in the Acknowledgements section) The DataTables library adds a significant amount of utility to the Roles Table. It includes being able to sort by username or roles, and allows you to show x of y entries (ex: 10 of 25 entries), and allows you to flip through "pages" of the table. <br />

When a role has been updated, the entire page refreshes to reflect the updated role in the Role Table. I am aware that this is not optimal, because not only could it be potentially slow if there were a lot of users in the table, but there is also a race condition where the database doesn't update in time for the refresh. For example, I change User X's role to Professor, this triggers the AJAX for the database to update, and forces the refresh immediately after. But it doesn't guarantee that the database had updated the role properly. I sort of work around this by delaying the refresh behind Sweet Alerts. It first does a sweet alert asking to confirm the role change. If this is confirmed, the database will update accordingly, then fire another Sweet Alert saying the data was successfully changed. Confirming that second Sweet Alert will then refresh the page. I still think this is a potential race condition if one is fast enough to click through all of the alerts, but I've done several trial runs and haven't been able to trigger the race condition at human-like speeds. You could probably use a ghost mouse program to successfully trigger the race condition, however. 

<h4>Improvements</h4>
N/A


## Acknowledgements

<h4>Image Sources</h4>

Dog: https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Sparkles_Cute.jpg/220px-Sparkles_Cute.jpg <br />
Pewdiepie: https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.RLo6Y6Z-y8iK2UrFl4bzkQHaHD%26pid%3DApi&f=1 <br />
Prof. Peter Alfeld: http://www.math.utah.edu/~pa/pa.jpg <br />
DFA: https://i.stack.imgur.com/b3nmn.png <br />
Lambda: https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Lambda_lc.svg/1200px-Lambda_lc.svg.png <br />
Ubuntu Logo: https://tr4.cbsistatic.com/hub/i/r/2016/04/20/d687cb6e-5c4e-4c41-acbf-d33f9c9f5880/thumbnail/770x578/0aecc2b46f59f52f4a7b05e3873f4b3e/ubuntuhero.jpg <br />
Intel Pentium Logo: https://www.intel.com/content/dam/www/global/badges/badge-pentium.png <br />
LLVM Logo: https://p1.ssl.qhmsg.com/dr/270_500_/t01207259916576bd36.jpg <br />
Generic Cola Can: http://www.savingadvice.com/wp-content/uploads/2012/04/generic.jpg <br />
OpenMP Logo: https://developers.redhat.com/blog/2016/03/22/what-is-new-in-openmp-4-5-3/ <br />
Green Checkmark: http://clipart-library.com/clipart/3897730.htm <br />
Red X: http://clipart-library.com/clipart/gie5B478T.htm

<h4>Referenced Code Snippet Sources</h4>

https://stackoverflow.com/questions/29207161/asp-net-add-text-after-html-displayfor <br />
https://alexcodetuts.com/2019/05/22/how-to-seed-users-and-roles-in-asp-net-core/ <br />

<h4>Peers consulted with</h4>
Jabrail Ahmed
Calvin Dam
Jon England
Misha Griego
Kaylee Martin


