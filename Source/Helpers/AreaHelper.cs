using System;
using System.Linq;
using Verse;

namespace BetterAutocastVPE.Helpers;

internal static class AreaHelper
{
    public static IntVec3? GetRandomCellInArea<T>(Map map)
        where T : Area
    {
        return map.areaManager.Get<T>().ActiveCells.GetRandomStruct();
    }

    public static IntVec3? GetRandomValidCellInArea<T>(Map map, Func<IntVec3, bool> validator)
        where T : Area
    {
        return map.areaManager.Get<T>().ActiveCells.Where(validator).GetRandomStruct();
    }
}
