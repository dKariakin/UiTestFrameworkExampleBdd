Feature: GoogleSearch
	Just an example how tests for a main google page could look like

Background:
	Given google main page is opened

Scenario: Search attempt with an empty query field
	Given query field is empty
	When user presses Google Search button
	Then google main page still opened

Scenario: Search attempt with non-empty query field
	Given user intends to find Specflow
	When user presses Google Search button
	Then search results are presented
	And each result relates to Specflow

Scenario: Search results relevance
	Given user intends to find Specflow
	When user presses Google Search button
	And opens first result
	Then specflow main page is opened

Scenario: I'm feeling lucky
	Given query field is empty
	When user presses I'm feeling lucky button
	Then doodles page is opened