using System;

namespace ElevatorSim
{
	public class Elevator
	{
		// Data members
		private int currentFloor;       // Holds the floor that the elevator is currently on
		private int maxFloor;           // The highest floor that the elevator can travel to
		private bool[] requestedFloors; // A collection of flags, one for each floor, that defines requested stops
		private DateTime[] requestedTime;	// Parallel array with requestedFloors, shows how long waiting
		private bool doorOpen;          // The state of the door being open or closed
		private int doorTime;           // Length of time door can be open before it will close, in seconds
		private int travelTime;         // Length of time elevator travels up or down one floor, in seconds
		private bool isMoving;          // State for if elevator is moving or not.
		private int direction;			// State for the intended direction of the elevator

		// Event handler
		delegate void ElevatorEventHandler();

		// Constants
		private const int UP = 1;
		private const int DOWN = 0;

		// Properties
		public int CurrentFloor
		{
			get { return currentFloor; }
			set { currentFloor = value; }
		}

		public int MaxFloor
		{
			get { return maxFloor; }
			set { maxFloor = value; }
		}

		public bool DoorOpen
		{
			get { return doorOpen; }
			set { doorOpen = value; }
		}

		public bool IsMoving
		{
			get { return isMoving; }
			set { isMoving = value; }
		}

		public int Direction
		{
			get { return direction; }
			set { direction = value; }
		}

		// Constructors
		public Elevator()
		{
			currentFloor = 1;
			maxFloor = 3;
			requestedFloors = new bool[maxFloor + 1];
			requestedTime = new DateTime[maxFloor + 1];
			doorOpen = false;
			doorTime = 5;
			travelTime = 10;
			isMoving = false;
			direction = UP;

			ElevatorEventHandler handler = new ElevatorEventHandler(ControlLoop);
		}

		// Methods
		public void Request(int floor)
		{
			// Flags the elevator to move to the given floor
			// This can be accomplished from either the control panel in the elevator or external controls

			// If the requested floor is the same as the current floor, open the door
			if (floor == currentFloor)
			{
				OpenDoor();
			}

			// Otherwise, set the flag in the request array
			else
			{
				requestedFloors[floor] = true;
				requestedTime[floor] = DateTime.Now;
			}
		}

		public void Move()
		{
			// Determines where the elevator will move based on the requested floors
			// Don't do anything if the elevator is already moving.
			if (isMoving)
				return;
			else
			{
				// Compare floor position to the requested floor to determine the direction to go

			}
		}

		public void OpenDoor()
		{
			// Opens the elevator door to allow passengers to enter

		}

		public void CloseDoor()
		{
			// Shuts the door if it is open
			if (doorOpen)
			{
				// DO IT!
				doorOpen = false;
			}
		}

		public void ControlLoop()
		{
			// Regulates the funtionality of the elevator, handling the events.
		}
	}
}
