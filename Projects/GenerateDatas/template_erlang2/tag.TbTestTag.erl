%% tag.TbTestTag

-module(tag_tbtesttag)
-export([get/1,get_ids/0])




get(2001) -> 
#{

	id => 2001,
	value => "导出"
}.
get(2004) -> 
#{

	id => 2004,
	value => "导出"
}.
get(2003) -> 
#{

	id => 2003,
	value => "导出"
}.
get(100) -> 
#{

	id => 100,
	value => "导出"
}.
get(1) -> 
#{

	id => 1,
	value => "导出"
}.
get(2) -> 
#{

	id => 2,
	value => "导出"
}.
get(9) -> 
#{

	id => 9,
	value => "测试"
}.
get(10) -> 
#{

	id => 10,
	value => "测试"
}.
get(11) -> 
#{

	id => 11,
	value => "测试"
}.
get(12) -> 
#{

	id => 12,
	value => "导出"
}.
get(13) -> 
#{

	id => 13,
	value => "导出"
}.
get(104) -> 
#{

	id => 104,
	value => "导出"
}.
get(102) -> 
#{

	id => 102,
	value => "测试"
}.
get(3001) -> 
#{

	id => 3001,
	value => "export"
}.
get(3004) -> 
#{

	id => 3004,
	value => "其他"
}.
get(3003) -> 
#{

	id => 3003,
	value => "测试"
}.



get_ids() ->
	[2001,2004,2003,100,1,2,9,10,11,12,13,104,102,3001,3004,3003].





