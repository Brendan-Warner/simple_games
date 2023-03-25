using System;
using System.Collections.Generic;

//this is the general peice class, this is inherated by other peices so that all the peices can be kept in a general list to operate on.
public class peice
{
    //each peice has a color, type, id, the column and row, a list of moves they can take, and output for thier moves, and lastly actually doing those moves
    public string color {get;set;}
    public string type {get;set;}
    public int id {get;set;}
    public int column {get;set;}
    public int row{get;set;}
    
    public List<int> moves = new List<int>();
    
    public void add_moves(int move)
    {
        moves.Add(move);
    }
    
    public List<int> return_moves()
    {
        return moves;
    }
    
    public virtual void allowed_moves(int move, int direction){} 
    
    public virtual void output_moves(){} 
}

public class castle:peice
{
    public override void allowed_moves(int move, int direction)
    {
        if(move == 1)
        {
            row += direction;
        }
        else if(move ==2)
        {
            column += direction;
        }
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move horizontally.");
        Console.WriteLine("2.Move vertically");
    }
}

public class bishop:peice
{
    public override void allowed_moves(int move, int direction)
    {
        
        if(move ==3)
        {
            row += direction;
		    column += direction;
        }
        else if(move == 4)
        {
            row -= direction;
		    column += direction;
        }
    }
    
    public override void output_moves()
    {
        Console.WriteLine("3.Move diagnolly to the right and up or diagnolly to the left and down.");
        Console.WriteLine("4.move diagnolly to the right and down or diagnolly to the left and up");
        
    }
}

public class queen:peice
{
    public override void allowed_moves(int move, int direction)
    {
        if(move == 1)
        {
            row += direction;
        }
        else if(move ==2)
        {
            column += direction;
        }
        
        else if(move ==3)
        {
            row += direction;
		    column += direction;
        }
        else if(move == 4)
        {
            row -= direction;
		    column += direction;
        }
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move horizontally.");
        Console.WriteLine("2.Move vertically");
        Console.WriteLine("3.Move diagnolly to the right and up or diagnolly to the left and down.");
        Console.WriteLine("4.move diagnolly to the right and down or diagnolly to the left and up");
        
    }
}

public class king:peice
{
    public override void allowed_moves(int move, int direction)
    {
        if(move == 1)
        {
            row += direction;
        }
        else if(move ==2)
        {
            column += direction;
        }
        
        else if(move ==3)
        {
            row += direction;
		    column += direction;
        }
        else if(move == 4)
        {
            row -= direction;
		    column += direction;
        }
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move horizontally.");
        Console.WriteLine("2.Move vertically");
        Console.WriteLine("3.Move diagnolly to the right and up or diagnolly to the left and down.");
        Console.WriteLine("4.move diagnolly to the right and down or diagnolly to the left and up");
        
    }
}

public class knight:peice
{
    public override void allowed_moves(int move, int direction)
    {
        if(move == 5)
        {
            row += 3;
            column+= direction;
        }
        else if(move ==6)
        {
            row -=3;
            column += direction;
        }
        
        else if(move ==7)
        {
            column += 3;
		    row += direction;
        }
        else if(move == 8)
        {
            column -= 3;
		    row += direction;
        }
    }
    
    public override void output_moves()
    {
        Console.WriteLine("5.move 3 up ");
        Console.WriteLine("6.Move 3 down");
        Console.WriteLine("7.move 3 right");
        Console.WriteLine("8.move 3 left");
        Console.WriteLine("The direction decides the final move of the knight in ether a positive up/negativ down if left/right or");
        Console.WriteLine("psotive right/negative left if up/down");
        
    }
}

public class pawn:peice
{
    public override void allowed_moves(int move, int direction)
    {
        
        if(move ==1)
        {
		    row += direction;
        }
        else if(move == 3)
        {
            row += direction;
		    column += direction;
        }
        else if(move == 4)
        {
            row -= direction;
		    column += direction;
        }
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move horizontally.");
        Console.WriteLine("3.Move diagnolly to the right and up or diagnolly to the left and down if a peice of the opposite color is on that diagnonl.");
        Console.WriteLine("4.move diagnolly to the right and down or diagnolly to the left and up if a peice of the opposite color is on that diagnonl.");
        
    }
}

public class empty:peice
{
    public override void allowed_moves(int move, int direction)
    {
         
    }
    
    public override void output_moves()
    {
        
    }
}

class HelloWorld {
    static List<peice> board = new List<peice>();
    static bool game = true;
    
    public static castle create_castle(int id, string color, int row, int column)
    {
	    castle c = new castle();
	    c.type = "c";
	    c.color = color;
	    c.id = id;
	    c.row = row;
	    c.column = column;
	    c.add_moves(1);
	    c.add_moves(2);
	    return c;
    }

    public static knight create_knight(int id, string color, int row, int column)
    {
	    knight k = new knight();
	    k.type = "h";
	    k.color = color;
	    k.id = id;
	    k.row = row;
	    k.column = column;
	    k.add_moves(5);
	    k.add_moves(6);
	    k.add_moves(7);
	    k.add_moves(8);
	    return k;
    }

    public static bishop create_bishop(int id, string color, int row, int column)
    {
    	bishop b = new bishop();
    	b.type = "b";
    	b.color = color;
    	b.id = id;
    	b.row = row;
    	b.column = column;
    	b.add_moves(3);
    	b.add_moves(4);
    	return b;
    }

    public static queen create_queen(int id, string color, int row, int column)
    {
	    queen q = new queen();
	    q.type = "q";
	    q.color = color;
	    q.id = id;
	    q.row = row;
	    q.column = column;
	    q.add_moves(1);
	    q.add_moves(2);
	    q.add_moves(3);
	    q.add_moves(4);
	    return q;
    }

    public static king create_king(int id, string color, int row, int column)
    {
	    king k = new king();
	    k.type = "k";
	    k.color = color;
	    k.id = id;
	    k.row = row;
	    k.column = column;
    	k.add_moves(1);
        k.add_moves(2);
        k.add_moves(3);
        k.add_moves(4);
	    return k;
    }

    public static pawn create_pawn(int id, string color, int row, int column)
    {
	    pawn p = new pawn();
	    p.type = "p";
	    p.color = color;
	    p.id = id;
	    p.row = row;
	    p.column = column;
	    p.add_moves(1);
        p.add_moves(3);
        p.add_moves(4);
	   
	    return p;
    }

    public static empty create_empty(int id, string color, int row, int column)
    {
	    empty e = new empty();
	    e.type = " ";
	    e.color = color;
	    e.id = id;
	    e.row = row;
	    e.column = column;
	    return e;
    }
    
    
    //we create the board with this function that creates a set of peices on the top and bottom of the board, white is at the "top" and black at the "bottom";
    static void create_board()
    {
	    board.Add(create_castle(1, "b", 1, 1));
	    board.Add(create_knight(1, "b", 1, 2));
	    board.Add(create_bishop(1, "b", 1, 3));
	    board.Add(create_queen(1, "b", 1, 4));
	    board.Add(create_king(1, "b", 1, 5));
	    board.Add(create_bishop(2, "b", 1, 6));
	    board.Add(create_knight(2, "b", 1, 7));
	    board.Add(create_castle(2, "b", 1, 8));
	    for(int i = 1; i < 9; i++)
	    {
		    board.Add(create_pawn(i, "b", 2, i));
	    }
	    int j = 3;
	    for(int i = 1; i < 9; i++)
	    {
		    board.Add(create_empty(0, " ", j, i));
		    if(i == 8 && j <6)
		    {
			    i =0;
			    j++;
		    }
	    }
	    for(int i = 1; i < 9; i++)
	    {
		    board.Add(create_pawn(i, "w", 7, i));
	    }

	    board.Add(create_castle(1, "w", 8, 1));
	    board.Add(create_knight(1, "w", 8, 2));
	    board.Add(create_bishop(1, "w", 8, 3));
	    board.Add(create_king(1, "w", 8, 4));
	    board.Add(create_queen(1, "w", 8, 5));
	    board.Add(create_bishop(2, "w", 8, 6));
	    board.Add(create_knight(2, "w", 8, 7));
	    board.Add(create_castle(2, "w", 8, 8));
	

    }
    
    static void output_board()//outputs the board, peices are identified with thier color followed by type.
    {
	    Console.WriteLine("-------------------------");
	    Console.Write("|");
	    foreach(peice p in board)
	    {
		    Console.Write(p.color + p.type +"|");
		    if(p.column ==8)
		    {
			    Console.WriteLine(" ");
			    Console.WriteLine("-------------------------");
			    Console.Write("|");
		    }
	    }
	
    }
    
    static int findI(int row, int column)//used to find the index of a peice in the board by their row and column.
    {
        int index = 0;
        foreach(peice p in board)
        {
            if(p.row == row && p.column == column)
            {
                return index;
            }
            else
            {
                index++;
            }
        }
        
        return index;
    }
    
    static bool check_can_move(List<peice> p, int move, string color, int direction)//checks if the peice can move in a givin direction for a move, if not, then it returns false, else, the peice can move.
    {
	    bool can_move = false;
	
		if(move == 1)
		{
			if(p[0].type == "p" && color == "b" && direction < 0 )//we have a pawn trying to move in the wrong direction, so return false.
			{
				return can_move;
			}
			else if(p[0].type == "p" && color == "w" && direction > 0)
			{
				return can_move;
			}
            
            
			else
			{
			    if(p[0].row + direction >8 || p[0].row + direction <= 0 )//checks to make sure the peice moving won't go out of bounds
                {
                    return can_move;
                }
				int p1 = findI(p[0].row + direction, p[0].column);
				
				if(board[p1].color != color )
				{
					return can_move = true;
				}
			}
		}

		else if(move == 2)
		{
		    if(p[0].column + direction >8 || p[0].column + direction  <= 0 )
            {
                return can_move;
            }
            
			int p1 = findI(p[0].row , p[0].column + direction);
			
			if(board[p1].color != color)
			{
				return can_move = true;
			}
		}

		else if(move == 3)//left-right diagnol
		{
			if(p[0].type == "p" && color == "b" && direction < 0)
			{
				return can_move;
			}
			else if(p[0].type == "p" && color == "w" && direction > 0)
			{
				return can_move;
			}

			else
			{
			    if(p[0].row + direction >8 || p[0].column + direction >8  || p[0].column + direction <=0  || p[0].row + direction <= 0 )
                {
                    return can_move;
                }
                
				int p1 = findI(p[0].row + direction, p[0].column + direction);
				
				if(p[0].type == "p" && board[p1].color != color && board[p1].type == " ")
				{
				    return can_move;
				}
				
				else if(board[p1].color != color)
				{
					return can_move = true;
				}
			}
		}

		else if(move == 4)//right-left diagnol
		{
			if(p[0].type == "p" && color == "b" && direction > 0)
			{
				return can_move;
			}
			else if(p[0].type == "p" && color == "w" && direction < 0)
			{
				return can_move;
			}

			else
			{
			    if(p[0].row - direction > 8 || p[0].column + direction > 8  || p[0].column + direction <= 0  || p[0].row - direction <= 0 )
                {
                    return can_move;
                }
			    
				int p1 = findI(p[0].row - direction, p[0].column + direction);
				if(p[0].type == "p" && board[p1].color != color && board[p1].type == " ")
				{
				    return can_move;
				}
				
				if(board[p1].color != color)
				{
					return can_move = true;
				}
			}
		}

		else if(move==5)//knight move up
		{
		    if(p[0].row + 3 > 8 || p[0].column + direction >8  || p[0].column + direction < 0 )
            {
                return can_move;
            }
			int p1 = findI(p[0].row + 3, p[0].column + direction);
			
			if(board[p1].color != color)
			{
				return can_move = true;
			}

		}
		else if(move==6)//knight move down
		{
		    if(p[0].row - 3 >8 || p[0].column + direction >8  || p[0].column + direction <= 0)
            {
                return can_move;
            }
			int p1 =findI(p[0].row - 3, p[0].column + direction);
			
			if(board[p1].color != color)
			{
				return can_move = true;
			}

		}
		
		else if(move==7)//knight move right
		{
		    if(p[0].row + direction >8 || p[0].column + 3 >8 || p[0].row + direction <= 0 )
            {
                return can_move;
            }
		    
			int p1 = findI(p[0].row + direction, p[0].column + 3);
			if(board[p1].color != color)
			{
				return can_move = true;
			}

		}

		else if(move==8)//knight move left
		{
		    if(p[0].row + direction > 8 || p[0].column - 3 > 8 || p[0].row + direction <= 0 )
            {
                return can_move;
            }
            
			int p1 = findI(p[0].row + direction, p[0].column - 3);
			if(board[p1].color != color)
			{
				return can_move = true;
			}

		}

		return can_move;

    }
    
    static List<peice> getTypes(string selectType, string color)//gets the board peices based on type and color.
    {
        List<peice> p2 = new List<peice>();
        foreach(peice p in board)
        {
            if(p.color == color && p.type == selectType)
            {
                p2.Add(p);
            }
        }
        return p2;
    }
    
    static void output_peices(List<peice> p)//outputs relavent information about the peices.
    {
        foreach(peice p2 in p)
        {
            Console.Write(p2.type + ":row=" + p2.row + " column=" + p2.column + " Id=" + p2.id + ", ");
        }
        Console.WriteLine(" ");
        
    }

    static void get_type(string color)//get the type from the user, which then gets all of that users peices of that type.
    {
	    bool avalible = false;
	    string selectType;
	    while(!avalible)//grabs the type of peice
	    {
		    Console.WriteLine("Please enter the type of peice you would like to select.");
		    selectType = Console.ReadLine();
		    List<peice>p2 = getTypes(selectType, color);
		    
		    if(p2.Count == 0)
		    {
			    Console.WriteLine("You no longer control a peice of that type.");
		    }
		    else{
			    output_peices(p2);
			    if(get_id(p2, color))
			    {
				    avalible = true;
			    }
			    avalible = true;
			
		    }
	    }
    }
    
    static List<peice> getId(List<peice> p, int selectId)//get the correct peice from an id provided by the user
    {
        List<peice> p2 = new List<peice>();
        foreach(peice peice in p)
        {
            if(peice.id == selectId)
            {
                p2.Add(peice);
                return p2;
            }
        }
        return p2;
    }
    
    static bool get_id(List<peice> p, string color)
    {
	    int selectId;
	    string selectNew;
	    bool avalible = false;
	    while(!avalible)//grabs the id of peice
	    {
	        Console.WriteLine("Please enter the id of the peice you would like to move.");
		    selectId = Convert.ToInt32(Console.ReadLine());
		    List<peice>p2 = getId(p, selectId);
		    Console.WriteLine(p2[0].type);
		    if(p2.Count == 0)
		    {
			    Console.WriteLine("Not a valid id, please enter a new one.");
		    }
		    else{
		    	
		    	List<int> moves = p2[0].return_moves();//grab the moves of that peice
		    	bool can_move = false;
		    	bool can_move2 = false;
		    	foreach(int i in moves)
			    {
				    can_move = check_can_move(p2,i, color, 1);//check if the peice can move positivly
				    can_move2 = check_can_move(p2,i, color, -1);//check if the peice can move negativly
				    if(can_move || can_move2)
				    {
					    get_player_move(p2, moves, color);
					    return true;
				    }
			    }
			    Console.WriteLine("That peice cannot move, please select another one.");
			
		    }
		
		    //if the peice cannot move, the prompt the user if they would like a new type of peice.
		    Console.WriteLine("Would you like to select a differnt type of peice or select another of the current? Enter y to select a new type.");
		    selectNew = Console.ReadLine();
		    if(selectNew =="y")
		    {
			    avalible = true;
		    }
	    }
	    return false;
	
    }
    
    static void get_player_move(List<peice> p, List<int> moves, string color)//get the move for that peice
    {
	    int selectMove;
    	bool okay = false;
	    bool okay2 = false;
	    bool avalible = false;
	    while(!avalible)//grabs the valid move of the peice.
	    {
	        p[0].output_moves();
		    Console.WriteLine("Please select the move you would like to do with the peice.");
		    selectMove = Convert.ToInt32(Console.ReadLine());

		

		    if(moves.Contains(selectMove))//if that move exists, then continue
		    {
		        	//check if the peice can move in that direction, if so, then we continue.
			    okay = check_can_move(p, selectMove, color, 1);//check if the move type is blocked, if at least one move is avalible, then its true;
			    okay2 = check_can_move(p, selectMove, color, -1);
			    if(okay == true || okay2 == true)
			    {
			    	avalible = true;
			    	get_num_moves(p, selectMove, color);
			    }

			
		    }
		
	    }
		
    }
    
    static void get_num_moves(List<peice>p, int selectMove, string color)//get the number of times the player want to move said peice.
    {
		int selectNumber;
		bool avalible = false;
		Console.WriteLine("Please select number of times you would like to move the peice.");
		while(!avalible)
		{
			selectNumber = Convert.ToInt32(Console.ReadLine());
		
			if(selectNumber <=0 || selectNumber > 8)//if an invalid number, ask again.
			{
				avalible = false;
				Console.WriteLine("Invalid number, please enter a number between 1 and 8.");
			}
		
		    else if(p[0].type == "p" || p[0].type == "k" || p[0].type == "h")//if one of three peices, then can only move once.
		    {
			    selectNumber = 1;
			    avalible = true;
			    get_direction(p, selectMove, color, selectNumber);
		    }
		    else
		    {
		        avalible = true;
			    get_direction(p, selectMove, color, selectNumber);
		    }
        }
		
    }
    
    
    static void get_direction(List<peice> p, int selectMove, string color, int selectNumber)
    {
        
	    Console.WriteLine("Please direction of the peice you would like to move.");
	    Console.WriteLine("Movments to the right and down are considered psoitive.");
	    Console.WriteLine("For the knight, this only affects the final move, and for pawns, only postive moves are accepted.");
	    int selectDirection = Convert.ToInt32(Console.ReadLine());
		
	    if(selectDirection <=0)
	    {
		    selectDirection = -1;
	    }
	    else
	    {
		    selectDirection = 1;
	    }
	    
	    bool direction_check = check_can_move(p, selectMove, color, selectDirection);
	    
	    if(!direction_check)
	    {
	        selectDirection = selectDirection * -1;
	    }
	
	    finialize_move(p, selectMove, selectDirection, selectNumber, color);
	
    }
    
    
    static void finialize_move(List<peice> p, int selectMove, int direction, int selectNumber, string color)
    {
	bool cont = true;
	bool blocked = true;//can move returns true if the peice can move in that direction.
	for(int i = 0; i < selectNumber; i++)
	{
		blocked = check_can_move(p, selectMove, color, direction);
		Console.WriteLine(blocked);

		if(!blocked)
		{
			return;
		}

		if(selectMove== 1)//move up/down
		{
			int p1 =findI(p[0].row + direction, p[0].column);
			int p2 =findI(p[0].row, p[0].column);
			
			Console.WriteLine(p1 + " " + p2);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove, direction);
			
			if(p[0].type == "p" && p[0].row == 1 || p[0].row ==8)
			{
			    p[0].type = "q";
			    p[0].add_moves(2);
			}
			
			board[p1] = p[0];
			
			board[p2] = create_empty(0, " ", p[0].row - direction, p[0].column );
		}

		else if(selectMove== 2)//move left/right
		{
		
			int p1 = findI(p[0].row, p[0].column  + direction );
			int p2 = findI(p[0].row, p[0].column);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove,direction);
			board[p1] = p[0];
			board[p2] = create_empty(0, " ", p[0].row , p[0].column - direction);
		}

		else if(selectMove== 3)//move left right diagnol
		{
			int p1 = findI(p[0].row + direction, p[0].column + direction);
			int p2 = findI(p[0].row, p[0].column);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove, direction);
			if(p[0].type == "p" && p[0].row == 1 || p[0].row ==8)
			{
			    p[0].type = "q";
			    p[0].add_moves(2);
			}
			board[p1] = p[0];
			board[p2] = create_empty(0, " ", p[0].row - direction, p[0].column - direction);
		}

		else if(selectMove== 4)//move diagnol right left 
		{
			int p1 = findI(p[0].row - direction, p[0].column + direction);
			int p2 = findI(p[0].row,p[0].column);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove,direction);
			if(p[0].type == "p" && p[0].row == 1 || p[0].row ==8)
			{
			    p[0].type = "q";
			    p[0].add_moves(2);
			}
			board[p1] = p[0];
			board[p2] = create_empty(0, " ", p[0].row + direction, p[0].column - direction);
		}

		else if(selectMove== 5)//up knight
		{
			int p1 = findI( p[0].row + 3, p[0].column + direction);
			int p2 = findI(p[0].row, p[0].column);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove,direction);
			board[p1] = p[0];
			board[p2] = create_empty(0, " ", p[0].row - 3, p[0].column - direction);
		}

		else if(selectMove== 6)//down knight
		{
			int p1 = findI(p[0].row - 3, p[0].column + direction);
			int p2 = findI(p[0].row, p[0].column);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove,direction);
			board[p1] = p[0];
			board[p2] = create_empty(0, " ", p[0].row + 3, p[0].column - direction);
		}

		else if(selectMove== 7)//right knight
		{
			int p1 = findI(p[0].row +direction, p[0].column + 3);
			int p2 = findI(p[0].row, p[0].column);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove,direction);
			board[p1] = p[0];
			board[p2] = create_empty(0, " ", p[0].row - direction, p[0].column - 3);
		}
		
		else if(selectMove== 8)//left knight
		{
			int p1 = findI(p[0].row + direction, p[0].column - 3);
			int p2 = findI(p[0].row, p[0].column);
			if(board[p1].color != color && board[p1].type != " ")
			{
				cont = false;
			}
			p[0].allowed_moves(selectMove, direction);
			board[p1] = p[0];
			board[p2] = create_empty(0, " ", p[0].row - direction, p[0].column + 3);
		}
		
		

		if(!cont)
		{
			return;
		}

		
	}
	
}

static void game()
{
  create_board();
  string color = "w";
  bool has_king = true;
  while(game)
  {
    output_board();
    get_type(color);
    
    has_king = getTypes(color, "k")
    
    if(!has_king)
    {
      game = false;
    }
    if(color == "w")
    {
      color = "b";
    }
    
    else
    {
      color = "w";
    }
  }
  
}
    
  static void Main() {
      create_board();
      output_board();
      get_type("b");
      output_board();
      get_type("b");
      output_board();
      get_type("b");
      output_board();
      
      
      
      
   
  }
}
    

