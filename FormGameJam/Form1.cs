using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

//This is my entry into the GameJolt.io WinForm game jam.
//If anyone ever reads this code, be gentle. I wrote the 
//entire program off the cuff with no planning at all.
//I didn't even know what kind of game I was making till
//it was skeletoned out. I'll try to document as best I 
//can. :)

namespace FormGameJam
{
    public partial class Form1 : Form
    {
        int score = 0; //Score of the player
        int bestScore = 0; //highscore variable
        int health = 100; //Player health
        int timeAlive = 0; //Time the player has been alive in milliseconds
        int tickSec = 0; //Keeps track of the frames since the last "Second" tick
        int asteroidSpeed = 8; //Base speed, gets faster over time.
        int asteroidVariance = 0; //Random to add to the asteroid speed so they aren't all moving at the same speed but I didn't set it up all the way so its disabled
        int timeSinceDamaged = 0; //Amount of time its been since the player was damaged
        int damageCooldown = 5; //Time in seconds from getting damaged till you can be damaged again.
        int scoreSinceChime = 0; //Lets reward the player for every 1000 points they get with a chime! and faster things!
        bool damagable = true; //Tells the game if the player can be damaged.

        SoundPlayer playMusic = new SoundPlayer(Properties.Resources.PlayMusic); //Handles some music
        SoundPlayer idleMusic = new SoundPlayer(Properties.Resources.IdleMusic); //Handles more music 
        SoundPlayer startGame = new SoundPlayer(Properties.Resources.StartSound); //sound for starting the game
        SoundPlayer perKScore = new SoundPlayer(Properties.Resources._1kSound); //Every time the player gets 1000 points
        SoundPlayer explosion = new SoundPlayer(Properties.Resources.Explosion); //In all its torue fasion
        SoundPlayer impactHit = new SoundPlayer(Properties.Resources.ImpactHit); //Impact sound from hitting a thingy
        PictureBox[] rocks; //Stores all the rocks
        Point[] rockStarts; //Where all the rocks are at the start
        Point PlayerStart; //Where the player starts


        public Form1()
        {
            InitializeComponent();
        }

        //=========================================================================
        //The "Frame" controller, it ticks physics, and basically every other event
        //in other words, the entire game is run in here for the most part.
        //=========================================================================
        private void tick_Tick(object sender, EventArgs e)
        {
            Physics(); //Runs the physics update, moving objects etc
            Respawn(); //Spawns everything back to the top instead of spawning new ones to keep track of
            MovePlayer();//Handles moving the player across the screen
            CollisionDetection(); //After everything is done moving, we see if it will blow up

            OnGUI(); //Runs all the GUI functions below
            timeAlive += 30;

            tickSec++; //Counts the frames

            if (tickSec >= 30) //Stuff that happens every second (not every frame)
            {                 //Use this timer, and not another to keep it in sync
                FixedUpdate();
            }

            Heartbeat(); //Checks to see if the player died this frame
        }

        //Builds the initial level and gets the game ready for play.
        private void Form1_Load(object sender, EventArgs e)
        {
            rocks = new PictureBox[5] { rock01, rock02, rock03, rock04, rock05 };
            idleMusic.PlayLooping();
            CaptureStartingPoints();
        }

        //Starts the game by hiding itself, then activating the tick object
        private void start_Click(object sender, EventArgs e)
        {
            tick.Start(); //Starts the magic 

            //Cleanup
            score = 0;
            asteroidVariance = 3;
            
            //Hides the UI elements that need to go away
            start.Enabled = false;
            start.Visible = false;
            start.SendToBack();
            tutText.Enabled = false;
            tutText.Visible = false;

            //Handles the sounds and the music on these lines.
            startGame.Play();
            idleMusic.Stop();
            playMusic.PlayLooping();
        }

        //Fixed update gets called every ~1 second. Its for things that need to be called, just not every frame
        private void FixedUpdate()
        {
            score += 20; //Gives ya 20 points w00t
            scoreSinceChime += 20; //adds 20 to internal chime counter

            ChimeTest(); //Checks to see if the player has gotten a thousand points or nah. Also makes it harder

            //This if block and everything inside it is for resetting the damage timer and 
            //handling the damage cooldown
            if (damagable == false)
            {
                timeSinceDamaged++;

                if (timeSinceDamaged > damageCooldown)
                {
                    damagable = true;
                }
            }

            tickSec = 0; //Resets the tick second so that we can wait till we get a new second WOOT
        }
        
        //Chimes every 1000 points and makes the game harder
        private void ChimeTest()
        {
            //Makes the game harder
            if(scoreSinceChime >= 1000)
            {
                perKScore.Play(); //Plays the thousand chime
                scoreSinceChime = 0; //score gained since the last chime

                asteroidSpeed += 5; //Used asteroid speed instead of the variance because of stutter.
            }
        }

        //Checks the players health every frame
        private void Heartbeat()
        {
            if(health <= 0)
            {
                Death();
            }
        }

        //Called when the player dies
        private void Death()
        {
            tick.Stop(); //Stops the game

            //Brings everything forward again (Next few lines)
            start.Enabled = true;
            start.Visible = true;
            start.BringToFront();

            //Takes care of the sounds and the music
            playMusic.Stop();
            idleMusic.PlayLooping();
            explosion.Play();

            //Restores the objeccts to their starting position
            RestoreStartingPoints();

            //Resets Health
            health = 100;
        }

        //The following two methods are for capturing and restoring the starting points of all objects.
        //So that at the end of the game, you don't get shafted in the second game.
        private void RestoreStartingPoints()
        {
            int curRest = 0;

            foreach(PictureBox s in rocks)
            {
                s.Location = rockStarts[curRest];
                curRest++;
            }

            player.Location = PlayerStart;

            curRest = 0;
        }

        private void CaptureStartingPoints()
        {
            int curCap = 0;

            rockStarts = new Point[5];

            foreach(PictureBox s in rocks)
            {
                rockStarts[curCap] = s.Location;
                curCap++;
            }

            PlayerStart = player.Location;

            curCap = 0;
        }

        //Called when you pickup health so that it can give it to the player.
        //This functionality is in the game but will likely not get used
        private void HPickup(int heals)
        {
            health += heals;

            if(health > 100)
            {
                health = 100;
            }
        }

        //Any GUI Updates that need to take place, including sending the UI to the 
        //front on every frame to ensure its drawing correctly. That way its independent
        //of anything that happened during the frame
        private void OnGUI()
        {
            //Updates the value on all the UI elements
            scoreLabel.Text = "Score: " + score.ToString();
            healthLabel.Text = "Health: " + health.ToString();

            if(score > bestScore)
            {
                bestScore = score;
                highScore.Text = "Best: " + bestScore.ToString();
            }

            //Send all the UI elements to the front
            healthLabel.BringToFront();
            healthLabel.BringToFront();
        }

        //Processes ALL movement
        private void Physics()
        {
            //Loops through every rock in the game and sends it down a certain amount
            foreach(PictureBox s in rocks)
            {
                s.Location = new Point(s.Location.X, s.Location.Y + Movement());
            }
        }

        //Handles the respawns, basically when the stones get to the bottom, it will put them back at the top
        //Simple, Elegant and easy to keep track of.
        private void Respawn()
        {
            Random r = new Random(); //stores the random seed and stuff.

            //Loops through every single rock and checks where it is, if its lower than it should be it gets
            //sent back to the top.
            foreach(PictureBox s in rocks)
            {
                if(s.Location.Y > 500)
                {
                    s.Location = new Point(r.Next(0, 640), -150);
                }
            }
        }

        //Sets the amount of movement for the asteroids on each frame.
        private int Movement()
        {
            Random r = new Random(); //Creates a new random generator "r"     
            int speed = 0;

            speed = asteroidSpeed + r.Next(0, asteroidVariance); //Grabs the base asteroid speed and adds randomness to it

            return speed;
        }

        //Handles the movement of the player, used mouse based cause I wasn't sure how easy it would be to do movement
        //based on keypresses. I've never tried to cature a "Player is holding down X key for x time" in regular .NET
        //before.
        private void MovePlayer()
        {
            Point mouseLocation = Form.ActiveForm.PointToClient(Cursor.Position);//Finds the point relative to the app.

            //The line below edits the position of the ship based on the cursor's location. It corrects for the width of the ship with as well.
            player.Location = new Point(mouseLocation.X - (player.Width / 2) ,player.Location.Y);


            //Follwing code makes sure it doesnt go off the screen. That would be awkward...
            if(player.Location.X > 572)
            {
                player.Location = new Point(572, player.Location.Y);
            }

            if (player.Location.X < 0)
            {
                player.Location = new Point(0, player.Location.Y);
            }
        }

        //Figures out (With only a semi amount of accuracy) if anything is colliding with the ship.
        private void CollisionDetection()
        {
            foreach(PictureBox s in rocks)
            {
                //These tell the difference between, I'm not sure if this is all correct, its just what I came up with.
                int Xdifference = (s.Location.X + (s.Width / 2)) - (player.Location.X + (player.Width / 2));
                int Ydifference = (s.Location.Y + (s.Height/ 2)) - (player.Location.Y + (player.Height/ 2));

                //get the actual distance apart
                double dist = Math.Sqrt((Xdifference * Xdifference) + (Ydifference * Ydifference));

                //And finally, does the real comparison
                if(dist < ((s.Width / 2) + (player.Width / 2)) && damagable)
                {
                    health -= 10;
                    damagable = false;
                    impactHit.Play();
                }
            }
        }
    }
}