%% test.TbMultiRowRecord

-module(test_tbmultirowrecord)
-export([get/1,get_ids/0])




get(1) -> 
#{

	id => 1,
	name => "xxx",
	one_rows => array,
	multi_rows1 => array,
	multi_rows2 => array,
	multi_rows3 => array,
	multi_rows4 => map,
	multi_rows5 => array
}.
get(2) -> 
#{

	id => 2,
	name => "xxx",
	one_rows => array,
	multi_rows1 => array,
	multi_rows2 => array,
	multi_rows3 => array,
	multi_rows4 => map,
	multi_rows5 => array
}.
get(3) -> 
#{

	id => 3,
	name => "ds",
	one_rows => array,
	multi_rows1 => array,
	multi_rows2 => array,
	multi_rows3 => array,
	multi_rows4 => map,
	multi_rows5 => array
}.



get_ids() ->
	[1,2,3].





