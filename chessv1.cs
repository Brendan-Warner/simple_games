using System;
using System.Collections.Generic;

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
    
    public bool contains_move(int move)
    {
        return moves.Contains(move);
    }
    
    public virtual int allowed_moves(int move){ return 1;} 
    
    public virtual void output_moves(){} 
    
    
}

public class castle:peice
{
    public override int allowed_moves(int move)
    {
        
        if(move == 1)//up
        {
            return 8;
	    
        }
        else if(move == 2)//down
        {
            return - 8;
        }
        else if(move == 3)//right
        {
            return 1;
        }
        else if(move ==4)//left
        {
            return -1;
        }
        
        return 0;
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move the peice up the file.");
        Console.WriteLine("2.Move the peice down the file");
        Console.WriteLine("3.Move the peice to the right.");
        Console.WriteLine("4.Move move the peice to the left.");
    }
}

public class bishop:peice
{
    public override int allowed_moves(int move)
    {
        
        if(move ==5)//move to the up and right.
        {
            return 9;
        }
        else if(move == 6)//move the the down and left
        {
            return -9;
        }
        if(move ==7)//move to the down  and right.
        {
		return -7;
        }
        else if(move == 8)//move to the up and left
        {
            return 7;
        }
        return 0;
    }
    
    public override void output_moves()
    {
        Console.WriteLine("5.Move diagnolly to the up and right.");
        Console.WriteLine("6.move diagnolly to the down and left.");
        Console.WriteLine("7.Move diagnolly to the down and right.");
        Console.WriteLine("8.move diagnolly to the up and left.");
        
    }
}

public class queen:peice
{
    public override int allowed_moves(int move)
    {
        if(move == 1)//up
        {
            return 8;
        }
        else if(move == 2)//down
        {
            return -8;
        }
        else if(move == 3)//right
        {
            return 1;
        }
        else if(move ==4)//left
        {
            return -1;
        }
        
        if(move ==5)//move to the up and right.
        {
            return 9;
        }
        else if(move == 6)//move the the down and left
        {
            return -9;
	
        }
        if(move ==7)//move to the down  and right.
        {
            return -7;
        }
        else if(move == 8)//move to the up and left
        {
            return 7;
        }
        return 0;
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move the peice up the file.");
        Console.WriteLine("2.Move the peice down the file");
        Console.WriteLine("3.Move the peice to the right.");
        Console.WriteLine("4.Move move the peice to the left.");
        Console.WriteLine("5.Move diagnolly to the up and right.");
        Console.WriteLine("6.move diagnolly to the down and left.");
        Console.WriteLine("7.Move diagnolly to the down and right.");
        Console.WriteLine("8.move diagnolly to the up and left.");
        
    }
}

public class king:peice
{
    public override int allowed_moves(int move)
    {
        if(move == 1)//up
        {
            return 8;
        }
        else if(move == 2)//down
        {
            return -8;
        }
        else if(move == 3)//right
        {
            return 1;
        }
        else if(move ==4)//left
        {
            return -1;
        }
        
        if(move ==5)//move to the up and right.
        {
            return 9;
        }
        else if(move == 6)//move the the down and left
        {
            return -9;
	
        }
        if(move ==7)//move to the down  and right.
        {
            return -7;
        }
        else if(move == 8)//move to the up and left
        {
            return 7;
        }
        return 0;
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move the peice up the file.");
        Console.WriteLine("2.Move the peice down the file");
        Console.WriteLine("3.Move the peice to the right.");
        Console.WriteLine("4.Move move the peice to the left.");
        Console.WriteLine("5.Move diagnolly to the up and right.");
        Console.WriteLine("6.move diagnolly to the down and left.");
        Console.WriteLine("7.Move diagnolly to the down and right.");
        Console.WriteLine("8.move diagnolly to the up and left.");
        
    }
}

public class knight:peice
{
    public override int allowed_moves(int move)
    {
        
        if(move == 9 || move ==21)//up two to the right 1 && right 1 up 2
        {
            return 15;
        }
        else if(move ==10 || move == 23)//up  two to the left 1 and left 1 up two
        {
            return 17;
        }
        
        else if(move ==11 || move == 22)//down two to the right 1 and right 1 down 2
        {
            return -15;
        }
        else if(move == 12 || move == 24)//down two the the left 1 and left 1 down 2
        {
            return -17;
        }
        
        else if(move == 13 || move == 17)//right two up 1 up one right two
        {
            return 10;
        }
        else if(move ==14 || move == 19)//right two down 1 down 1 right two
        {
            return -6;
        }
        
        else if(move ==15 || move == 18)//left 2 up 1 up one left two
        {
            return 6;
        }
        else if(move == 16 || move == 20)//left2 down 1 down one left two
        {
            return -10;
        }
        
        return 0;
    }
    //maybe keep the peices having a direction input, but if its negative, it undoes the move rather then moivng it forward.
    public override void output_moves()
    {
        Console.WriteLine("9.move up 2 and right 1.");
        Console.WriteLine("10. move up 2 and left 1.");
        Console.WriteLine("11. move down 2 and right 1.");
        Console.WriteLine("12. move down 2 and left 1.");
        Console.WriteLine("13. move right 2 and up 1.");
        Console.WriteLine("14. move right 2 and down 1.");
        Console.WriteLine("15. move left 2 and up 1");
        Console.WriteLine("16. move left 2 and down 1.");
        Console.WriteLine("17. move up 1 and right 2. ");
        Console.WriteLine("18. move up 1 and left 2.");
        Console.WriteLine("19. move down 1 and right 2.");
        Console.WriteLine("20. move down 1 and left 2.");
        Console.WriteLine("21. move right 1 and up 2.");
        Console.WriteLine("22. move right 1 and down 2.");
        Console.WriteLine("23. move left 1 and up 2.");
        Console.WriteLine("24. move left 1 and down 2.");
        
        
    }
}

public class pawn:peice
{
    public override int allowed_moves(int move)
    {
        
        if(move == 1)//up
        {
            return 8;
        }
        else if(move == 2)//down
        {
            return -8;
        }
        
        if(move ==5)//move to the up and right.
        {
            return 9;
        }
        else if(move == 6)//move the the down and left
        {
            return -9;
	
        }
        if(move ==7)//move to the down  and right.
        {
            return -7;
        }
        else if(move == 8)//move to the up and left
        {
            return 7;
        }
        return 0;
    }
    
    public override void output_moves()
    {
        Console.WriteLine("1.Move the peice up the file if your the commanding black");
        Console.WriteLine("2.Move the peice down the file if your commanding white.");
        Console.WriteLine("5.Move diagnolly to the up and right. if your commanding black");
        Console.WriteLine("6.move diagnolly to the down and left if your commanding white.");
        Console.WriteLine("7.Move diagnolly to the down and right if your commanding white.");
        Console.WriteLine("8.move diagnolly to the up and left if your commanding black.");
        
    }
}

public class empty:peice
{
    public override int allowed_moves(int move)
    {
         return 1;
    }
    
    public override void output_moves()
    {
        
    }
}     
  
class HelloWorld
{
     static List<peice> board = new List<peice>();
     static string inCheck = " ";
     static empty tempEmpty = new empty();
     
     static List<peice> tempHolder = new List<peice>();
    

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
	    c.add_moves(3);
	    c.add_moves(4);
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
	    k.add_moves(9);
	    k.add_moves(10);
	    k.add_moves(11);
	    k.add_moves(12);
	    k.add_moves(13);
	    k.add_moves(14);
	    k.add_moves(15);
	    k.add_moves(16);
	    k.add_moves(17);
	    k.add_moves(18);
	    k.add_moves(19);
	    k.add_moves(20);
	    k.add_moves(21);
	    k.add_moves(22);
	    k.add_moves(23);
	    k.add_moves(24);
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
    	b.add_moves(5);
    	b.add_moves(6);
    	b.add_moves(7);
    	b.add_moves(8);
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
	    q.add_moves(5);
    	    q.add_moves(6);
    	    q.add_moves(7);
    	    q.add_moves(8);
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
            k.add_moves(5);
    	    k.add_moves(6);
    	    k.add_moves(7);
    	    k.add_moves(8);
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
	    
	    if(color == "w")
	    {
	        p.add_moves(2);
	        p.add_moves(6);
    	        p.add_moves(7);
	    }
	    
	    else{
	        p.add_moves(1);
	        p.add_moves(5);
    	        p.add_moves(8);
	    }
	   
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
    
    static void test_board_draw()//update this for testing checkmate. then for putting in to check.
    {
        int i = 0;
        int j = 1;
        for(i = 1; i < 9; i++)
        {
            if(i==2 && j == 2 || i==4 && j == 1)
            {
                board.Add(create_castle(1, "w", j, i));
            }
            else if(i == 1 && j== 7)
            {
               board.Add(create_castle(1, "w", j, i)); 
            }
            
            else if(i==2 && j == 1)
            {
                board.Add(create_pawn(1, "b", j, i));
            }
            else if(i == 3 && j == 8)
            {
                board.Add(create_king(1, "b", j, i));
            }
            else{
                board.Add(create_empty(0, " ", j, i));
            }
            
		    if(i == 8 && j < 8)
		    {
			    i =0;
			    j++;
		    }
        }
    }
    static void output_board()//outputs the board, peices are identified with thier color followed by type.
    {
	    Console.WriteLine("-------------------------");
	    Console.Write("|");
	    int count = 1;
	    foreach(peice p in board)
	    {
		    Console.Write(p.color + p.type +"|");
		    if(count==8)
		    {
			    Console.WriteLine(" ");
			    Console.WriteLine("-------------------------");
			    Console.Write("|");
			    count = 0;
		    }
		    count++;
	    }
	
    }
    
    static void update_board(List<peice> p, int p1, int p2, int p3, int p4)
    {
        board[p1] = p[0];
			
    	board[p2] = create_empty(0, " ", p3, p4);
    }
    
    static void output_peices(string color)//outputs relavent information about the peices.
    {
        foreach(peice p in board)
        {
	    if(p.color == color)
	    {
            	Console.Write(p.type + ":row=" + p.row + " column=" + p.column + " Id=" + p.id + ", ");
	    }
        }
        Console.WriteLine(" ");
        
    }
    
    //////////////////////////////////////////////////
    ///start of getting peices of the board/checks////
    /////////////////////////////////////////////////
    
    static int findKing(string color)
    {
        int index = 0;
        foreach(peice p in board)
        {
            if(p.color == color && p.type == "k")
            {
                return index;
            }
            index++;
        }
        return index;
    }
    
    static List<peice> get_all_peices(string color)///returns all the peices of a color
    {
	List<peice> peices = new List<peice>();
	foreach(peice p in board)
	{
		if(p.color == color)
		{
			peices.Add(p);
		}
	}
	return peices;
    }
    
    static int findI(List<peice> p)
    {
        return board.FindIndex(a=> a == p[0]);
    }
    
    static bool check_check_mate(string color)//is called when in check, grabs all the peices and tests if they remove a check.
    {
	List<peice> peices = new List<peice>();
	List<peice> p = new List<peice>();

	
	
	peices = get_all_peices(color);
	if(p.Count == 1)
	{
		return true;
	}
	p.Add(peices[0]);
	List<int> moves = new List<int>();
	foreach(peice p1 in peices)
	{
	    p[0] = p1;
		moves = p[0].return_moves();
		foreach(int move in moves)
		{
			if(!check_check_mate_moves(p, move, 8, color))
			{
				return false;
			}
		}
	}
	return true;
    }

    ///this is for check that at least one peice can move, only called when not in check at the start of a turn.
    static bool draw(string color)
    {
	List<peice> peices = new List<peice>();
	peices = get_all_peices(color);
	List<int> moves = new List<int>();
	List<peice> p = new List<peice>();
	
	Console.WriteLine(peices.Count);
	p.Add(peices[0]);
	foreach(peice p1 in peices)
	{
	    p[0] = p1;
		moves = p[0].return_moves();
		foreach(int i in moves)
		{
			if(!check_can_move(p,i,color))
			{
				continue;
			}
			if(put_in_check(p, i, color))
			{
				continue;
			}
			return false;
			
		}
	}
	return true;
    }

     static bool check_for_check(string color)
     {
		int p = findKing(color);
		Console.WriteLine(p);
		int p2 = p;
		int count = 1;
		List<int> moves = board[p].return_moves();//1,2,3,4,5,6,7,8// this problem here with this is that moving the king through our normal systems doesn't work, as it would have the wrong type of movment
		//may need a new function entierly for checking when we move the king.
		//may be able to simply this for each with the new function created below.
		foreach(int move in moves)
		{
			p2 += board[p].allowed_moves(move);
			while(p2 > 0 && p2 < 64)
			{
				
				if(board[p2].color == board[p].color)
				{
					break;
				}
				if(board[p2].color != color && board[p2].contains_move(move) && board[p2].type != " ")
				{
					if(board[p2].type == "k" ||( board[p2].type == "k"&& (count > 1 || move == 1 || move == 2)))
					{
						break;
					}
					return true;
				}
				p2 += board[p].allowed_moves(move);
				count++;
				
			}
			p2 = p;
			count = 1;
		}
	
		int[] knightPos = {6, 10, 15, 17};
		int i = 0;
		for(i = 0; i < 4; i++)
		{
			p2 = p + knightPos[i];
			if(p2 > 63)
			{
				break;
			}
			else if(board[p2].type == "h" && board[p2].color != color)
			{
				return true;
			}
		}

		for(i = 0; i < 4; i++)
		{
			p2 = p - knightPos[i];
			if(p2 < 1)
			{
				break;
			}
			else if(board[p2].type == "h" && board[p2].color != color)
			{
				return true;
			}
		}
		
		return false;
     }

    static bool put_in_check(List<peice> p, int move, string color)
    {
	bool putInCheck = false;
	int place = findI(p);
	int update = p[0].allowed_moves(move);
	
	tempHolder[0] = board[place+update];
	
	board[place +update] = board[place];
	board[place] = tempEmpty;

	putInCheck = check_for_check(color);

	board[place] = board[place+update];
	board[place+update] = tempHolder[0];
	

	return putInCheck;
	

    }

    static bool still_in_check(List<peice> p, int place1, int place2, string color)
    {
	bool putInCheck = false;
	
	
	string nextType = board[place2].type;
	string nextColor = board[place2].color;

	board[place2].color = color;
	board[place2].type = board[place1].type;
	board[place1].color = " ";
	board[place1].type = " ";

	putInCheck = check_for_check(color);

	board[place1].color = color;
	board[place1].type = board[place2].type;
	board[place2].color = nextColor;
	board[place2].type = nextType;
	

	return putInCheck;
    }

    static bool check_can_move(List<peice> p, int move, string color)//checks if the peice can move in a givin direction for a move, if not, then it returns false, else, the peice can move.
    {
	    bool can_move = false;
	    
	    int place = findI(p);
	    int update = p[0].allowed_moves(move);
	    
	    
	    
	    //another check if for pawn moving twice, which should be only possible for a white pawn with index 
	    if(off_board(place + update, place, move))
	    {
		return can_move;
	    }
	    
	    if(p[0].type == "p" && move > 2 && board[place+update].color != color && board[place+update].type != " ")
	    {
		return can_move = true;
	    }
	    if(board[place+update].color != color)
	    {
	        can_move = true;
	    }
	    return can_move;
		

    }
    
    static bool check_check_mate_moves(List<peice> p, int selectMove, int selectNumber, string color)///modified finalize move to check if a peice moving at all could remove a check, if not, then 
    {
	    if(!check_can_move(p, selectMove, color))
	    {
		return true;
	    }
	    if(put_in_check(p, selectMove, color))
	    {
		return true;
	    }

	    int p1 = findI(p);
	    int update = 0;
	    bool stop = false;
	    for(int i = 0; i < selectNumber; i++)
	    {
		
		//after this, we can do a check in here that is done after the final move, where if still in check, we return false.
		update += p[0].allowed_moves(selectMove);
		
		if(off_board(p1+update, p1, selectMove))
		{
			update -= p[0].allowed_moves(selectMove);
			break;
		}
		if(blocked(p1 + update, color))
		{
		    update -= p[0].allowed_moves(selectMove);
			break;
		}
		if(!continue_move(p1 + update, color))
		{
			break;
		}
		if(inCheck == color)//this may allow us to check for moves that would block the peice from attacking without removing the attacking peice.
	   	{
			if(still_in_check(p, p1, p1+update, color))
			{
			return true;
	  	}
		
	    }
		
	    }
	    
	    return false;
    }



    static List<peice> getPeice(string selectType, int Id, string color)//gets the peice the user inputed or returns nothing.
    {
        List<peice> p2 = new List<peice>();
        foreach(peice p in board)
        {
            if(p.color == color && p.type == selectType && p.id == Id)
            {
                p2.Add(p);
		return p2; 
            }
        }
        return p2;
    }

    static bool off_board(int next, int previous, int move)
    {
	if(next > 63 || next < 0){return true;}
	else if(move == 3 || move == 5 || move == 7 || move == 9 || move ==11 || move == 13 || move == 14 || move == 17 || move == 19 || move == 21 || move == 22)
	{
		if(board[next].column < board[previous].column){return true;}
	}

	else if(move == 4 || move == 6 || move == 8 || move == 10 || move ==12 || move == 15 || move ==16 || move == 18 || move == 20 || move == 23 || move == 24)
	{
		if(board[next].column > board[previous].column){return true;}
	}
	return false;
	
    }

    static bool blocked(int place, string color)
    {
	if(board[place].color ==color){return true;}
	return false;
	
    }
    static bool continue_move(int place, string color)
    {
	if(board[place].color != color && board[place].type != " "){return false;}
	return true;
	
    }
    //////////////////////////////////////////////////
    ///start of getting peices of the board/checks////
    /////////////////////////////////////////////////

    static void get_type(string color)//get the type from the user, which then gets all of that users peices of that type.
    {
	    bool avalible = false;
	    string selectType;
	    int selectId;
	    List<int> moves = new List<int>();//list of moves for that peice

		if(draw(color))
		{
		    return;
		}
	    
	    while(!avalible)//grabs the type and id of a peice.
	    {
		    output_peices(color);
		    Console.WriteLine("Please enter the type of peice you would like to select.");
		    selectType = Console.ReadLine();
		    Console.WriteLine("Please enter the Id of peice you would like to select.");
		    selectId = Convert.ToInt32(Console.ReadLine());
		    List<peice>p = getPeice(selectType, selectId, color);
		    
		    if(p.Count == 0)
		    {
			    Console.WriteLine("You no longer control that peice or what you entered was invalid.");
			    continue;
		    }
			    
		    moves = p[0].return_moves();
		    
	
		    if(!get_player_move(p, moves, color))
		    {
			   continue;
		    }
		    
		    avalible = true;
		    
	    }
    }

    static bool get_player_move(List<peice> p, List<int> moves, string color)//get the move for that peice
    {
	    int selectMove;
	    bool avalible = false;
	    while(!avalible)//grabs the valid move of the peice.
	    {
	            p[0].output_moves();//maybe change this to output only the valid moves
		    Console.WriteLine("Please select the move you would like to do with the peice, input -1 to select a new peice.");
		    selectMove = Convert.ToInt32(Console.ReadLine());

		    if(selectMove == -1)
		    {
			    return false;
		    }

		    if(!moves.Contains(selectMove))//if doesn't move exists, then continue
		    {
		     	Console.WriteLine("Sorry, the peice cannot currently do that move, please select a new move or new peice.");  
			continue; 
		    }

		    
			
		    if(!get_num_moves(p, selectMove, color))
		    {
			continue;
		    }
		    avalible = true;
		    
		
	    }
	    return true;
		
    }

    static bool get_num_moves(List<peice>p, int selectMove, string color)//get the number of times the player want to move said peice.
    {
		int selectNumber;
		bool avalible = false;
		Console.WriteLine("Please select number of times you would like to move the peice?");
		Console.WriteLine("This number will move the peice one space in the selected direction.");
		Console.WriteLine("If the peice is blocked by a peice of the same color or the end of the board, it will stop.");
		Console.WriteLine("If it captures a peice, it will stop.");
		Console.WriteLine("Lastly, it is important to note that a king, knight, and pawn, can only move once.");
		while(!avalible)
		{
		    selectNumber = Convert.ToInt32(Console.ReadLine());

		    if(selectNumber <= 0)
		    {
			Console.WriteLine("That is not a vliad number, please input a new one.");
			continue;
		    }
		
		    if(p[0].type == "p" || p[0].type == "k" || p[0].type == "h")//if one of three peices, then can only move once.
		    {
			    selectNumber = 1;
			    
		    }
		    
		    if(!finialize_move(p, selectMove, selectNumber, color))
		    {
			return false;
		    }
		    avalible = true;
        	}
		return true;
		
    }

    static bool finialize_move(List<peice> p, int selectMove, int selectNumber, string color)
    {
	    if(!check_can_move(p, selectMove, color))
	    {
		Console.WriteLine("Sorry, you cannot move with that peice in that direction, please select an other peice or move.");
		return false;
	    }
	    if(put_in_check(p, selectMove, color))
	    {
		Console.WriteLine("Sorry, moveing the peice like that will put you in check, please select an other peice or move.");
		return false;
	    }

	    int p1 = findI(p);
	    int update = 0;
	    bool stop = false;
	    for(int i = 0; i < selectNumber; i++)
	    {
		
		//after this, we can do a check in here that is done after the final move, where if still in check, we return false.
		update += p[0].allowed_moves(selectMove);
		
		if(off_board(p1+update, p1, selectMove))
		{
			update -= p[0].allowed_moves(selectMove);
			break;
		}
		if(blocked(p1 + update, color))
		{
		    update -= p[0].allowed_moves(selectMove);
			break;
		}
		if(!continue_move(p1 + update, color))
		{
			break;
		}
		
	    }
	    
	    if(inCheck == color)
	    {
		if(still_in_check(p, p1, p1+update, color))
		{
			Console.WriteLine("Your king is still in check, please modify your move, select a new move, or select a new peice.");
			return false;
		}
		else	
		{
			inCheck = " ";
		}
	    }
	    
	    int old_column = p[0].column;
	    int old_row = p[0].row;
	    int new_row = board[p1+update].row;
	    int new_column = board[p1+update].column;
	    p[0].row = new_row;
	    p[0].column = new_column;
	    board[p1 + update] = p[0];
	    
	    board[p1] = create_empty(0, " ", old_row, old_column);
	
	    if(color == "w")
	    {
		if(check_for_check("b"))
		{
			inCheck = "b";
		}
	    }
	    if(color == "b")
	    {
		if(check_for_check("w"))
		{
			inCheck = "w";
		}
	    }
	    return true;
    }
    
    static void Main() {
        
      tempEmpty.color = " ";
      tempEmpty.type = " ";
      tempHolder.Add(tempEmpty);
      
      test_board_draw();
      output_board();
      
      get_type("b");
      output_board();
      
      get_type("b");
      output_board();
      
      get_type("b");
      output_board();
  }
}
    
    

