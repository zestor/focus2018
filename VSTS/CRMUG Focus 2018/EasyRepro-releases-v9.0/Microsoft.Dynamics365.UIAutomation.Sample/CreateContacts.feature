Feature: Create Contact

This is a test of creating contacts with Dynamics 365 for Sales.

@automated
Scenario: Create Contact 1
	Given user logs into dynamics 365 sales
	And navigates subarea Sales then Contacts
#	And switches grid view to Active Contacts
	And clicks New button on the ribbon
	And enters firstname Chris and lastname Clark in fullname field of type fullname
	And enters test@contoso.com in emailaddress1 field of type string
	And enters 123-123-1234 in mobilephone field of type string
	And enters 11/01/1980 in birthdate field of type datetime
	And enters Email in preferredcontactmethodcode field of type optionset
    When clicks Save button on the ribbon 
	Then form should reload
	And user should see emailaddress1 field of type string is test@contoso.com

@automated
Scenario: Create Contact 2
	Given user logs into dynamics 365 sales
	And navigates subarea Sales then Contacts
#	And switches grid view to Active Contacts
	And clicks New button on the ribbon
	And enters firstname Joe and lastname Smith in fullname field of type fullname
	And enters joe.smith@contoso.com in emailaddress1 field of type string
	And enters 222-222-2222 in mobilephone field of type string
	And enters 02/14/1971 in birthdate field of type datetime
	And enters Email in preferredcontactmethodcode field of type optionset
    When clicks Save button on the ribbon 
	Then form should reload
	And user should see emailaddress1 field of type string is joe.smith@contoso.com

@automated
Scenario: Create Contact 3
	Given user logs into dynamics 365 sales
#	And navigates subarea Sales then Accounts
	And navigates subarea Sales then Contacts
#	And switches grid view to Active Contacts
	And clicks New button on the ribbon
	And enters firstname Peter and lastname Pancake in fullname field of type fullname
	And enters peter.pancake@contoso.com in emailaddress1 field of type string
	And enters 333-333-3333 in mobilephone field of type string
	And enters 03/14/1971 in birthdate field of type datetime
	And enters Email in preferredcontactmethodcode field of type optionset
#	And enters Male in gendercode field of type optionset
#	And enters Single in familystatuscode field of type optionset
    When clicks Save button on the ribbon 
	Then form should reload
	And user should see emailaddress1 field of type string is peter.pancake@contoso.com

