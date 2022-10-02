Feature: Footer
	In order to use service information
	As a user
	I want to be able to work with footer links

@mytag
Scenario: User can open links under Information section
	When user clicks on '<information link>' option
	Then correct '<page>' is displayed
Examples:
	| information link           | page						  |
	| Specials		             | Price drop				  |
    | New products               | New products		          |
	| Best sellers               | Best sellers				  |
	| Our stores                 | Our store(s)!			  |
	| Contact us	             | Contact	                  |
	| Terms and conditions of use| Terms and conditions of use|
	| About us					 | About us					  |
	| Sitemap					 | Sitemap					  |