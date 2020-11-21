Feature: Map

@ui @map @scrollmap
Scenario: Scroll the map
	Given the our stores page is displayed
	When the shopper scroll the map "xdirection" by "xsteps" 
	And the shopper scrolls the map "ydirection" by "ysteps"
	Then the maps shows the correct location "reference"

Examples: Map
| xdirection | xsteps | ydirection | ysteps | reference |
| north      | 10     | east           |10     | image.png |