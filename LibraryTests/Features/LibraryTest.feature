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
	When delete book by <Author>
	#Then book is deleted

	Examples: 
	| Author       | Title       | Genre  | Info              | Button   |
	| 1 New Author | 1 New Title | Poetry | Interesting book! | Add Book |