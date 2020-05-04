Feature: HR Ops User logs in and triggers resignation process

After the HR Ops user logs in, the user is directed to the landing page and after 
clicking on all employees, user is then directed to the HR Ops dashboard. User then
searches for employees and confirms their details and triggers off process and sends
member an email.

Background: 
	Given <HR Ops user> logs in
	     |Email|Password|URL|
       	 |32d812dab6@emailtown.club|Testing@1|https://qa.digital.alexanderforbes.co.za|
	And  Lands on the <landing page>
		 |Home Page Alexander Forbes Digital Experience|
	When User clicks on Active resignees
	Then User is directed to the HR ops dashboard

Scenario: Viewing all employees on HR Ops dashboard
	Given A valid HR Ops user