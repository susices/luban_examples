-module(test_tbtestmap).
-export([get_data_map/0, get_key_list/0]).
get_data_map() -> #{
	1 => #{id => 1,x1 => #{1 => 2,3 => 4},x2 => #{1 => 2,3 => 4},x3 => #{"aaa" => 1,"bbb" => 2},x4 => #{1 => 1,2 => 20}}}.
get_key_list() ->
	[1].