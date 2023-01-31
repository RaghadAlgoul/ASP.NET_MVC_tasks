using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31_1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        
        public ActionResult About()
        {
            return Content("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n<style>\r\nbody {\r\n  font-family: Arial, Helvetica, sans-serif;\r\n  margin: 0;\r\n}\r\n\r\nhtml {\r\n  box-sizing: border-box;\r\n}\r\n\r\n*, *:before, *:after {\r\n  box-sizing: inherit;\r\n}\r\n\r\n.column {\r\n  float: left;\r\n  width: 33.3%;\r\n  margin-bottom: 16px;\r\n  padding: 0 8px;\r\n}\r\n\r\n.card {\r\n  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);\r\n  margin: 8px;\r\n}\r\n\r\n.about-section {\r\n  padding: 50px;\r\n  text-align: center;\r\n  background-color: #474e5d;\r\n  color: white;\r\n}\r\n\r\n.container {\r\n  padding: 0 16px;\r\n}\r\n\r\n.container::after, .row::after {\r\n  content: \"\";\r\n  clear: both;\r\n  display: table;\r\n}\r\n\r\n.title {\r\n  color: grey;\r\n}\r\n\r\n.button {\r\n  border: none;\r\n  outline: 0;\r\n  display: inline-block;\r\n  padding: 8px;\r\n  color: white;\r\n  background-color: #000;\r\n  text-align: center;\r\n  cursor: pointer;\r\n  width: 100%;\r\n}\r\n\r\n.button:hover {\r\n  background-color: #555;\r\n}\r\n\r\n@media screen and (max-width: 650px) {\r\n  .column {\r\n    width: 100%;\r\n    display: block;\r\n  }\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<div class=\"about-section\">\r\n  <h1>About Us Page</h1>\r\n  <p>Some text about who we are and what we do.</p>\r\n  <p>Resize the browser window to see that this page is responsive by the way.</p>\r\n</div>\r\n\r\n<h2 style=\"text-align:center\">Our Team</h2>\r\n<div class=\"row\">\r\n<div class=\"container\">  <div class=\"column\">\r\n    <div class=\"card\">\r\n      <img src=\"/str.png\" alt=\"Jane\" style=\"width:100%\">\r\n      <div class=\"container\">\r\n        <h2>Jane Doe</h2>\r\n        <p class=\"title\">CEO & Founder</p>\r\n        <p>Some text that describes me lorem ipsum ipsum lorem.</p>\r\n        <p>jane@example.com</p>\r\n        <p><button class=\"button\">Contact</button></p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n\r\n  <div class=\"column\">\r\n    <div class=\"card\">\r\n      <img src=\"/str.png\" alt=\"Mike\" style=\"width:100%\">\r\n      <div class=\"container\">\r\n        <h2>Mike Ross</h2>\r\n        <p class=\"title\">Art Director</p>\r\n        <p>Some text that describes me lorem ipsum ipsum lorem.</p>\r\n        <p>mike@example.com</p>\r\n        <p><button class=\"button\">Contact</button></p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n  \r\n  <div class=\"column\">\r\n    <div class=\"card\">\r\n      <img src=\"/str.png\" alt=\"John\" style=\"width:100%\">\r\n      <div class=\"container\">\r\n        <h2>John Doe</h2>\r\n        <p class=\"title\">Designer</p>\r\n        <p>Some text that describes me lorem ipsum ipsum lorem.</p>\r\n        <p>john@example.com</p>\r\n        <p><button class=\"button\">Contact</button></p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n</div></body>\r\n</html>");
         }

        public ActionResult Contact()
        {
            
            return Content("<!DOCTYPE html>\r\n<html>\r\n<style>\r\ninput[type=text], select {\r\n  width: 100%;\r\n  padding: 12px 20px;\r\n  margin: 8px 0;\r\n  display: inline-block;\r\n  border: 1px solid #ccc;\r\n  border-radius: 4px;\r\n  box-sizing: border-box;\r\n}\r\n\r\ninput[type=submit] {\r\n  width: 100%;\r\n  background-color: #4CAF50;\r\n  color: white;\r\n  padding: 14px 20px;\r\n  margin: 8px 0;\r\n  border: none;\r\n  border-radius: 4px;\r\n  cursor: pointer;\r\n}\r\n\r\ninput[type=submit]:hover {\r\n  background-color: #45a049;\r\n}\r\n\r\ndiv {\r\n  border-radius: 5px;\r\n  background-color: #f2f2f2;\r\n  padding: 20px;\r\n}\r\n</style>\r\n<body>\r\n\r\n<h3> Contact Us</h3>\r\n\r\n<div>\r\n  <form action=\"/action_page.php\">\r\n    <label for=\"fname\">First Name</label>\r\n    <input type=\"text\" id=\"fname\" name=\"firstname\" placeholder=\"Your name..\">\r\n\r\n    <label for=\"lname\">Last Name</label>\r\n    <input type=\"text\" id=\"lname\" name=\"lastname\" placeholder=\"Your last name..\">\r\n\r\n    <label for=\"country\">Country</label>\r\n    <select id=\"country\" name=\"country\">\r\n      <option value=\"australia\">Australia</option>\r\n      <option value=\"canada\">Canada</option>\r\n      <option value=\"usa\">USA</option>\r\n    </select>\r\n  \r\n    <input type=\"submit\" value=\"Submit\">\r\n  </form>\r\n</div>\r\n\r\n</body>\r\n</html>\r\n\r\n");
        }
        public ActionResult Index()
        {
            return Content("<p>Click on the image to download it:<p>" +
                    "\r\n<a href=\"/str.png\" download>" +
                    "\r\n  <img src=\"/str.png\" alt=\"W3Schools\" " +
                    "width=\"104\" height=\"142\">\r\n</a>");

        }

        public ActionResult Color()
        {
            return Content("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ndiv {\r\n  width: 100px;\r\n  height: 100px;\r\n  background-color: red;\r\n  animation-name: example;\r\n  animation-duration: 4s;\r\n}\r\n\r\n@keyframes example {\r\n  0%   {background-color: red;}\r\n  25%  {background-color: yellow;}\r\n  50%  {background-color: blue;}\r\n  100% {background-color: green;}\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<h1>my favourit colors</h1>\r\n\r\n<div></div>\r\n\r\r\n\r\n</body>\r\n</html>");

        }
        public ActionResult info()
        {
            return Content(" <!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ndiv {\r\n  border: 1px solid gray;\r\n  padding: 8px;\r\n}\r\n\r\nh1 {\r\n  text-align: center;\r\n  text-transform: uppercase;\r\n  color: #4CAF50;\r\n}\r\n\r\np {\r\n  text-indent: 50px;\r\n  text-align: justify;\r\n  letter-spacing: 3px;\r\n}\r\n\r\na {\r\n  text-decoration: none;\r\n  color: #008CBA;\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<div>\r\n  <h1>Raghad Alghoul</h1>\r\n  <p style=\" text-align: justify;\">Full Stack Web Development Trainee at Coding academy by Orange</p>\r\n</div>\r\n\r\n</body>\r\n</html>");

        }
        public ActionResult Move()
        {
            return Content(" <!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style> \r\ndiv {\r\n  width: 100px;\r\n  height: 100px;\r\n  background-color: red;\r\n  position: relative;\r\n  animation-name: example;\r\n  animation-duration: 4s;\r\n}\r\n\r\n@keyframes example {\r\n  0%   {background-color:red; left:0px; top:0px;}\r\n  25%  {background-color:yellow; left:200px; top:0px;}\r\n  50%  {background-color:blue; left:200px; top:200px;}\r\n  75%  {background-color:green; left:0px; top:200px;}\r\n  100% {background-color:red; left:0px; top:0px;}\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<h1>CSS Animation</h1>\r\n\r\n<div></div>\r\n\r\n<p></p>\r\n\r\n</body>\r\n</html>\r\n");

        }
        public ActionResult Width()
        {
            return Content("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style> \r\ndiv {\r\n  width: 100px;\r\n  height: 100px;\r\n  background: red;\r\n  transition: width 2s, height 4s;\r\n}\r\n\r\ndiv:hover {\r\n  width: 300px;\r\n  height: 300px;\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<p>Hover over the div element below, to see the transition effect:</p>\r\n\r\n<div></div>\r\n\r\n</body>\r\n</html>\r\n");

        }
    }
}