The game is provided with 6 forms.

Form 1: start.cs

	-contains a start button over an opaque background supplying the game with a good-looking
	 beginning
	-opens the next form ( login.cs )

Form 2: login.cs
	-includes 2 textboxes ( username, password ) and 3 buttons ( login, register, exit game)
	-pressing the login button, the code checks if the username and password exist in the 		 database and opens game.cs if so. Otherwise, a MessageBox will pop up telling the user
	 to try again 
	-there is a show-password switch
	-pressing the register button, this form closes and register.cs shows up
	-exit game button closes the game

Form 3: register.cs
	-the game requests various personal data in order to complete the registration which is
	 loaded to a SQL dabatase ( login1.mdf )
	-there are error checks such as password match, existing e-mail
	-pressing the confirm button, the user completes registration

Form 4: game.cs
	-it contains a currentScore label, a highScore label uploaded from the database and 6 
	 buttons to push in order to guess the color of next card
	-the last 3 cards are displayed in 3 pictureBoxes and updated for every step you take
	-includes a helpButton which opens help.cs( reveals the instructions of the game )
	-there s an exit button to return to login.cs. Pressing this button, the highscore is saved
	 into the database

Form 5: roundButton.cs
	-Visual Studio has a predetermined function for a rectangular button, so I created this
	 file in order to create round buttons for a good-looking layout

OPEN WindowsFormsApp1.sln to test the game
