//부엌도구
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Structure;
using System.Data;

namespace Modless
{
    public class Util
    {

        //이름으로 바닥 타입 찾기
        public static FloorType 이름으로바닥유형찾기(Document doc, string name)
        {
            FloorType ft = null;
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfClass(typeof(FloorType));
            foreach (FloorType floorType in col)
            {
                if (floorType.Name == name)
                {
                    ft = floorType;
                    break;
                }
            }
            return ft;
        }


        //이름으로 벽 타입 찾기
        public static WallType 이름으로벽유형찾기(Document doc, string name)
        {
            WallType wt = null;
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfClass(typeof(WallType));
            foreach (WallType wallType in col)
            {
                if (wallType.Name == name) { wt = wallType; break; }
            }
            return wt;
        }
    }
}
