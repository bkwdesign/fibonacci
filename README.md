# fibonacci
Fibonacci Number Calculator


This ASP.NET MVC 4 Solution file contains three projects:

 > bkwdesign.math		A dedicated library for doing math operations 
 
 > bkwdesign.web.math		A web app featuring two controller classes:
 
 	> FibonacciController is an MVC controller (number can be acheived via direct URL route, or via form post)
 	
 	> ResponseLogController is a WebAPI demonstration. Used to retieve last 10 log entries
 	
 > bkwdesign.web.math.tests	Features unit tests mostly for the core fibonacci logic and add'l test for the ResponseLog logic
 
 
CSS Contributions

 > Google Fonts: Lobster font face
 
 > Lovely round corners and dropshadows initially generated here: http://cssround.com/
 
 
This project was based off a 'Basic' MVC template

 > Elmah.MVC NuGet package was added
 
 > JQuery unobtrusive validation script bundle added to the shared layout razor (responsible for client side message when you fat-finger data into input)
 
Warnings:

 > A lot of boilerplate bloat is still probably resident in the initial commit.
 
 > Fairly new to Git, and did not properly use .gitignore to perform a clean commit.. probably committed every silly .dll from my development efforts.
 
One Failed Unit Test:

 > Per the instructions, I was expecting the 78th fibocanni to be 8944394323791463 - and I've left the unit test in place with this expectation. However, I think this was clearly a test to see if I would catch this.