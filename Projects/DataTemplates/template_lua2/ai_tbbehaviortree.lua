
-- ai.TbBehaviorTree



return
{
[10002] = 
{
	id=10002,
	name="random move",
	desc="demo behaviour tree haha",
	blackboard_id="demo",
	root=
	{
		id=1,
		node_name="test",
		decorators=
		{
		
			{
				id=3,
				node_name="",
				flow_abort_mode=2,
				num_loops=0,
				infinite_loop=true,
				infinite_loop_timeout_time=-1,
			},
		},
		services=
		{
		},
		children=
		{
		
			{
				id=30,
				node_name="",
				decorators=
				{
				},
				services=
				{
				},
				ignore_restart_self=false,
				wait_time=1,
				random_deviation=0.5,
			},
		
			{
				id=75,
				node_name="",
				decorators=
				{
				},
				services=
				{
				},
				ignore_restart_self=false,
				origin_position_key="x5",
				radius=30,
			},
		},
	},
},
}
