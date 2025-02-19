## Solution: a game where the player shoots a missile at ships passing across the screen.

## Requirements
1. The solution must support missiles launched by the user
  a. The solution must initiate a missile launch when the user clicks the right mouse button.
  b. The solution must initiate a missile launch when the user clicks the space bar.
  c. The solution must limit the number of active missiles on the screen to no more than five (5) at any given time. (an “active missile” is any missile currently being displayed on the screen)
  d. The solution must remove the missile from being active if it goes off the screen.
  e. The solution must maintain the same constant speed for all missiles
  f. The solution must launch missiles from the center of the bottom of the screen when a launch is initiated
  g. The solution must maintain the same constant direction for all missiles to be vertically straight up from the launched position.
  h. The solution must detect when a missile “hits” a ship
  i. The solution must display an explosion at the point where a missile “hits” a ship
  j. The solution must remove the missile and ship after the missile “hits” the ship
  k. The solution must keep a count of all “hits”
2. The solution must support ships launched by the solution
  a. The solution must initiate a ship launch when the system detects there are no active ships.
  b. The solution must support multiple types of ships based on a configurable value.
  c. The solution must display the appropriate image based on the type of ship when the ship is active
  d. The solution must randomly initiate a ship launch based on a configurable rate where the default is 30% of the time
  i. The solution must randomly choose from available ship types when a launch is initiated, giving all types equal chance of being launched.
    ii. The solution must limit the number of active ships on the screen to no more than ten (10) at any given time. (an “active ship ” is any ship currently being displayed on the screen)
    iii. The solution must randomly choose a location to launch a ship from when initiated
       1. The system must randomly choose to launch the ship from the left side of the screen or the right side of the screen
       2. The system must randomly choose a row in the top two-thirds of the screen to launch the ship from
       3. The system must assign the speed of the ship based on the type of the ship being initiated
       4. The system must assign the direction of the ship based on which side of the screen it is being launched from (if from the left, direction goes left to right; if from the right, direction goe right to left)
  e. The solution must remove the ship from being active if it goes off the screen.
3. The solution must end the game when the “hit” count has reached ten (10)
4. The solution must end the game when the user clicks the left mouse button
5. The solution must end the game when the user clicks the esc button
6. The solution must end the game if the user has not initiated a missile launch in the last 5 minutes.

## Test Cases

### User Missile Launch

1. Missile Launch via Right Mouse Button
    - Precondition: Game is active, and the user is on the game screen.
    - Action: User clicks the right mouse button.
    - Postcondition: A missile is launched from the center bottom of the screen, moving vertically upward at a constant rate.
2. Missile Launch via Space Bar
    - Precondition: Game is active, and the user is on the game screen.
    - Action: User presses the space bar.
    - Postcondition: A missile is launched from the center bottom of the screen, moving vertically upward at a constant rate.
3. Other Button Clicks
    - Precondition: Game is active, and the user is on the game screen.
    - Action: Click keys other than right click and space bar.
    - Postcondition: No missiles are launched.
4. Limit Active Missiles to Five
      - Precondition: Five missiles are currently active on the screen.
      - Action: User attempts to launch another missile.
      - Postcondition: No additional missile is launched, and active missile count remains at five.
5.	Remove Missile When Off-Screen
    - Precondition: Missile is active and has reached the top edge of the screen.
    - Action: Missile moves off-screen.
    - Postcondition: The missile is removed from the list of active missiles.
6.	Maintain Constant Missile Speed
    - Precondition: No missiles on the screen.
    - Action: Launch 2 missiles.
    - Postcondition: Distance between 2 missiles stays the same.
7.	Missile Launch from Center Bottom
    - Verified from tests 1,2,4.
8.	Vertical Missile Direction
    - Verified from tests 1,2,4.
9.	Missile Hits a Ship
    - Precondition: Active missile intersects with an active ship.
    - Action: Missile and ship collide.
    - Postcondition: An explosion is displayed at the collision point. The missile and the ship are removed, and the hit counter increases by one.

### Test Cases for Ships
10.	Launch a Ship When None are Active
    - Precondition: No active ships on the screen.
    - Action: System initiates a ship launch.
    - Postcondition: A ship appears on the screen and begins moving.
11.	Multiple Ship Types Based on Configurable Value
    - Precondition: Configurable value for ship types is set to two types.
    - Action: System initiates ship launch.
    - Postcondition: The game displays the two different images corresponding to the ship types.
12.	Random Ship Launch (30% Default Rate)
    - Precondition: Configurable launch rate is set to 0%.
    - Action: The game launches a ship.
    - Postcondition: Only one ship should be on the screen at a time.
13.	Limit Active Ships to Ten
    - Precondition: Ten ships are currently active on the screen.
    - Action: Launch rate is set to 100%. System attempts to launch another ship.
    - Postcondition: No additional ship is launched, and active ship count remains at ten.
14.	Random Launch Location
    - Precondition: Game is running.
    - Action: System launches multiple ships.
    - Postcondition: Ships launch from either the left or right side of the screen in a randomly chosen row in the top two-thirds of the screen.
15.	Ship Speed Based on Type
    - Precondition: Game is running with multiple types of ships configured to launch.
    - Action: System launches 2 ships of different types at the same time from the same side of the screen.
    - Postcondition: One ship reaches the other side of the screen before the other ship.
16.	Ship Direction Based on Launch Side
    - Verified from tests 11-15
17.	Remove Ship When Off-Screen
    - Precondition: Ship is active and reaches the edge of the screen.
    - Action: Ship moves off-screen.
    - Postcondition: The ship is removed from the list of active ships.

### Test Cases for Game End Conditions
18.	Game Ends When Hit Count Reaches Ten
    - Precondition: Hit count is nine.
    - Action: Missile hits a ship.
    - Postcondition: Game ends.
19.	Game Ends When Left Mouse Button Clicked
    - Precondition: Game is active.
    - Action: User clicks the left mouse button.
    - Postcondition: Game ends.
20.	Game Ends When Esc Button Pressed
    - Precondition: Game is active.
    - Action: User presses the esc button.
    - Postcondition: Game ends.
21.	Game Ends When No Missile Launched in Last 5 Minutes
    - Precondition: Game is active, and no missile has been launched for 5 minutes.
    - Action: Timer reaches 5 minutes of inactivity.
    - Postcondition: Game ends.
