Feature: CreateContact
	
@automated
Scenario: Create Contact
	Given user logs into dynamics 365 sales
	And navigates subarea Sales then Contacts
	And switches grid view to Active Contacts
	And clicks New button on the ribbon
	And enters firstname Chris and lastname Clark in fullname field of type fullname
	And enters test@contoso.com in emailaddress1 field of type string
	And enters 123-123-1234 in mobilephone field of type string
	And enters 11/01/1980 in birthdate field of type datetime
#	And enters Email in preferredcontactmethodcode field of type optionset
    When user clicks Save button on the ribbon awesome
	Then form should reload
	And user should see emailaddress1 field of type string is test@contoso.com
