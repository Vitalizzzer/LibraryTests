Feature: LibraryTest
	Verify Library UI functionlity

@mytag
Scenario Outline: Add new book
	Given author name <Author>
	And book title <Title>
	And choose book genre <Genre>
	And choose date
	And enter info <Info>
	When click <Button> button
	Then the book appears in the db

	Examples: 
	| Author     | Title     | Genre  | Info              | Button   |
	| New Author | New Title | Poetry | Interesting book! | Add Book |