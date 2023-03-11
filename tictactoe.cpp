#include <iostream>


using namespace std;
const int row = 3;
const int col = 3;

//assings the players character to the inputted baord spot, as well as checks if that is a winning move.
//this is done by checking the winnings move row, column, and if applicable, the diagnol. 
//when we find a winning move, then we stop checking. if can't find a winning move, then we return true,
//as that means the game is to continue.
bool game_move(bool game, int player_x, int player_y, string player, string (&arr)[row][col])
{
	arr[player_x][player_y] = player;//we know the move is valid at this point, so assign it.

	if(arr[0][player_y] == player && arr[1][player_y] == player && arr[2][player_y] == player)//check the column of the spot entered.
	{
		game = false;
		
	}

	else if(arr[player_x][0] == player && arr[player_x][1] == player && arr[player_x][2] == player)//check the row of the spot entered
	{
		game = false;
		
	}

	else if((player_x == 0 && player_y == 0) || (player_x == 2 && player_y == 2))//check if the spot is a specific diagnol
	{
		if(arr[0][0] == player && arr[1][1] == player && arr[2][2] == player)
		{
			game = false;
		}
		
	}

	else if((player_x == 0 && player_y == 2) || (player_x == 2 && player_y == 0))//check if the spot is the oposite diagnol
	{
		if(arr[0][2] == player && arr[1][1] == player && arr[2][0] == player)
		{
			game = false;
		}
		
	}

	else if(player_x == 1 && player_y == 1)//check if the spot is the center spot, as it has two diagnols to check.
	{
		if(arr[0][2] == player && arr[1][1] == player && arr[2][0] == player)
		{
			game = false;
		}

		else if(arr[0][0] == player && arr[1][1] == player && arr[2][2] == player)
		{
			game = false;
		}
	}

	

	return game;
	
} 

bool valid_move(int player_x, int player_y, string player, string (&arr)[row][col])
{
    if(player_x > 2 || player_x < 0 || player_y > 2 || player_y < 0)//the the numbers entered are not 0,1, or 2, then they are invalid.
    {
        cout << "Invalid cordinates, please enter again." << endl;
        return false;
    }
    string check = arr[player_x][player_y];
	if(isspace(check[0]))//if the spot is not whitespace, then the spot is occupied, else, its a valid move.
	{
		return true;
		
	}
	//inform the use the spot is taken.
	cout << "That move is not valid, that spot is occupied, please enter new values" << endl;
	return false;
}

void reset_board(string (&arr)[row][col])//reset the board, donw by setting everything to a space.
{
    int i = 0, j = 0;
    
    for(i = 0; i < 3; i++)
    {
        for(j = 0; j < 3; j++)
        {
            arr[i][j] = " ";
        }
    }
}

void directions()//directions for the players, made into a function so that the player can accesses them later is desired. 
{
    cout << "In this game of tic tac toe, you will be propmted to enter an x and y value for a board" << endl;
	cout << "x corrisbonds to the row, and y the column, both start at 0 and end at 2" << endl;
	cout << "when a player fills out a row, a column, or a diagnol of three with with their character, they win."<< endl;
	cout << "If at any point durning the selection of postitions you need a reminder of these directions, you can enter -1 for one or more postions." << endl;
	cout << "You will then be repromted for the postions." << endl;
	
	
    
}

int main()
{
    
    string option;//used for user input on starting and continueing the game
    
    //values for inputed positions on the tic tac toe board.
	int xpos = 0;
	int ypos = 0;
	
	
	//players scores this session.
	int player_1_score = 0;
	int player_2_score = 0;
	
	string player = "X";//used to define current turn player.
	
	
	


	string board[3][3] = {{" "," "," "},{" "," "," "},{" "," "," "}};//the board itself. filled with spaces to making checking for valid moves easier.
	

	bool game = false;//used to control if the game is to continue or not.
	bool valid = false;//used to for informing if a move is valid or not.
	
	directions();
	cout << "Is this understood? if so, enter y, else, enter any other character to exit." << endl;
	cin >> option;

	if(option == "y")
	{
		game = true;
	}	

	while(game == true)
	{
		cout<< board[0][0] << "|" << board[0][1] << "|" << board[0][2] << endl;
		cout << "------" << endl;
		cout<< board[1][0] << "|" << board[1][1] << "|" << board[1][2] << endl;
		cout << "------" << endl;
		cout<< board[2][0] << "|" << board[2][1] << "|" << board[2][2] << endl;

    
        
        

		while(valid == false)
		{
			cout << "Please enter a position for x player " << player << endl;
			cin >> xpos;
			cout << "Please enter a postiton for y player " << player << endl;
			cin >> ypos;
			
			if(xpos == -1 || ypos == -1)//if the user enter -1 at all here, then they want the directions. 
			{
			    directions();
			}
			else
			{
			    valid = valid_move(xpos, ypos, player, board);
			}
		}

		game = game_move(game,xpos, ypos, player, board);//used to see if someone has won, if so, then we need to reassign game, if no winners, then game remains true.

		if(game == false)//if we have game equals false, then someone has won.
		{
		    if(player == "X")
		    {
		        player_1_score++;
		    }
		    else
		    {
		        player_2_score++;
		    }
			cout << "player " << player << " has won!" << endl;
			cout << "Scores for this session are player 1:" << player_1_score << " player 2:" << player_2_score << endl;
			cout << "would you like to play again? Enter y for yes or any character to quit." << endl;
			cin >> option;
			if(option == "y")
			{
				game = true;
				reset_board(board);//reset the board for the next game.
				
			
			}
		}

		valid = false;//reset valid to false so we check if for the next go around.
		
		//we leave this outside of anything so that if a player wins, the loser gets to start the next game.
		if(player == "X")
		{
			player = "O";
		}
		else
		{
			player = "X";
		}

		
	}

    return 0;
}