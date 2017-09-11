Feature: SpecFlowFeatureTransavia
  This feature file contains some manual and automated regression test scenario's.
  Manual tests: 2 test cases, both happy flow. (BTW: the can be run automated as well.)
  Automated tests: 2 test cases, 1 happy flow, 1 unhappy flow.

@Manual
Scenario: 1A User wants to book a flight with blue miles
  Given I am a user who wants to book a flight at "https://www.transavia.com/en-NL/home/"
  And I have entered departure airport "Amsterdam (Schiphol), Nederland" and destination "Alicante, Spanje"
  And I have entered departure date "15-09-2017" and return date "16-09-2017"
  And I have entered number of travellers 1 adults, 0 kids, 0 babies and including blue miles "yes"
  When I press the search button
  Then I will see a list of possible flights on page "Outbound flight"

@Manual
Scenario: 1B User wants to book a flight (same as 1A) but without blue miles. Afterwards, results can be compared (manually). 
  Given I am a user who wants to book a flight at "https://www.transavia.com/en-NL/home/"
  And I have entered departure airport "Amsterdam (Schiphol), Netherlands" and destination "Alicante, Spain"
  And I have entered departure date "15-09-2017" and return date "16-09-2017"
  And I have entered number of travellers 1 adults, 0 kids, 0 babies and including blue miles "no"
  When I press the search button
  Then I will see a list of possible flights on page "Outbound flight"

@Automated
@TestInitialize
Scenario: 2 User wants to book a flight for his/her family
  Given I am a user who wants to book a flight at "https://www.transavia.com/en-NL/home/"
  And I have entered departure airport "Amsterdam (Schiphol), Netherlands" and destination "Alicante, Spain"
  And I have entered departure date "13-10-2017" and return date "20-10-2017"
  And I have entered number of travellers 2 adults, 1 kids, 1 babies and including blue miles "yes"
  When I press the search button
  Then I will see a list of possible flights on page "Outbound flight"

@Automated
Scenario: 3 User wants to book a flight with return on same day, which is not possible for the destination (FAILED test)
  Given I am a user who wants to book a flight at "https://www.transavia.com/en-NL/home/"
  And I have entered departure airport "Amsterdam (Schiphol), Netherlands" and destination "Vienna, Austria"
  And I have entered departure date "13-10-2017" and return date "13-10-2017"
  And I have entered number of travellers 1 adults, 0 kids, 0 babies and including blue miles "no"
  When I press the search button
  Then I will see a list of possible flights on page "Outbound flight"
