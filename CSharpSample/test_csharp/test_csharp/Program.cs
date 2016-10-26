using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatBuffers;

namespace test_csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("Press any key to exit");
			
			Console.ReadKey(true);
		}

		static void serialize()
		{
			FlatBufferBuilder builder = new FlatBufferBuilder(1024);
			Offset<Grid>[] grids =
			{
				Grid.CreateGrid(builder, 1, 1) ,
				Grid.CreateGrid(builder, 2, 2)
			};
			VectorOffset vector = builder.CreateVectorOfTables<Grid>(grids);

			Offset<MapInfo> mapInfo = MapInfo.CreateMapInfo(builder, 10, 10, vector);
		}

		//static void des

		static void SaveDatas(string path)
		{
			
		}
	}
}
