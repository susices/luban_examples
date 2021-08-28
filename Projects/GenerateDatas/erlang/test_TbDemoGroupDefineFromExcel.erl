-module(test_tbdemogroupdefinefromexcel).
-export([get_data_map/0, get_key_list/0]).
get_data_map() -> #{
	1 => #{id => 1,x1 => 1,x2 => 2,x3 => 3,x4 => 4,x5 => #{y1 => 10,y2 => 20,y3 => 30,y4 => 40}},
	2 => #{id => 2,x1 => 1,x2 => 2,x3 => 3,x4 => 4,x5 => #{y1 => 10,y2 => 20,y3 => 30,y4 => 40}},
	3 => #{id => 3,x1 => 1,x2 => 2,x3 => 3,x4 => 4,x5 => #{y1 => 10,y2 => 20,y3 => 30,y4 => 40}},
	4 => #{id => 4,x1 => 1,x2 => 2,x3 => 3,x4 => 4,x5 => #{y1 => 10,y2 => 20,y3 => 30,y4 => 40}}}.
get_key_list() ->
	[1,2,3,4].