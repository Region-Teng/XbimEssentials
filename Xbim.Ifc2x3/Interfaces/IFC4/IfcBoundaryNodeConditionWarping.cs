// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralLoadResource
{
	public partial class @IfcBoundaryNodeConditionWarping : IIfcBoundaryNodeConditionWarping
	{
		IIfcWarpingStiffnessSelect IIfcBoundaryNodeConditionWarping.WarpingStiffness 
		{ 
			get
			{
				//## Handle return of WarpingStiffness for which no match was found
                if (_warpingStiffness4 != null)
                    return _warpingStiffness4;

                var value = WarpingStiffness;
                if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcWarpingMomentMeasure(value.Value);
				//##
			} 
			set
			{
				//## Handle setting of WarpingStiffness for which no match was found
                if (value == null)
                {
                    WarpingStiffness = null;
                    if (_warpingStiffness4 != null)
                        SetValue(v => _warpingStiffness4 = v, _warpingStiffness4, null, "WarpingStiffness", byte.MaxValue);
                    return;

                }
                if (value is Ifc4.MeasureResource.IfcWarpingMomentMeasure)
                {
                    WarpingStiffness = new MeasureResource.IfcWarpingMomentMeasure((Ifc4.MeasureResource.IfcWarpingMomentMeasure)value);
                    if (_warpingStiffness4 != null)
                        SetValue(v => _warpingStiffness4 = v, _warpingStiffness4, null, "WarpingStiffness", byte.MaxValue);
                    return;
                }

                SetValue(v => _warpingStiffness4 = v, _warpingStiffness4, value, "WarpingStiffness", byte.MaxValue);
				//##
				
			}
		}
	//## Custom code
	    private IIfcWarpingStiffnessSelect _warpingStiffness4;
	    //##
	}
}