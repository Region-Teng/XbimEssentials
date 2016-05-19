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
	public partial class @IfcBoundaryFaceCondition : IIfcBoundaryFaceCondition
	{
		IIfcModulusOfSubgradeReactionSelect IIfcBoundaryFaceCondition.TranslationalStiffnessByAreaX 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByAreaX for which no match was found
			    if (_translationalStiffnessByAreaX != null)
			        return _translationalStiffnessByAreaX;

			    var value = LinearStiffnessByAreaX;
                if(!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure(value.Value);
			    //##
			} 
			set
			{
				//## Handle setting of TranslationalStiffnessByAreaX for which no match was found
			    if (value == null)
			    {
			        LinearStiffnessByAreaX = null;
                    if (_translationalStiffnessByAreaX != null)
                        SetValue(v => _translationalStiffnessByAreaX = v, _translationalStiffnessByAreaX, null, "TranslationalStiffnessByAreaX", byte.MaxValue);
			        return;

			    }
                if (value is Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure)
                {
                    LinearStiffnessByAreaX = new MeasureResource.IfcModulusOfSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure)value);
                    if (_translationalStiffnessByAreaX != null)
                        SetValue(v => _translationalStiffnessByAreaX = v, _translationalStiffnessByAreaX, null, "TranslationalStiffnessByAreaX", byte.MaxValue);
                    return;
                }

                SetValue(v => _translationalStiffnessByAreaX = v, _translationalStiffnessByAreaX, value, "TranslationalStiffnessByAreaX", byte.MaxValue);
                return;
                
				//##
				NotifyPropertyChanged("TranslationalStiffnessByAreaX");
				
			}
		}
		IIfcModulusOfSubgradeReactionSelect IIfcBoundaryFaceCondition.TranslationalStiffnessByAreaY 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByAreaY for which no match was found
                if (_translationalStiffnessByAreaY != null)
                    return _translationalStiffnessByAreaY;

                var value = LinearStiffnessByAreaY;
                if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure(value.Value);
                //##
			} 
			set
			{
				//## Handle setting of TranslationalStiffnessByAreaY for which no match was found
                if (value == null)
                {
                    LinearStiffnessByAreaY = null;
                    if (_translationalStiffnessByAreaY != null)
                        SetValue(v => _translationalStiffnessByAreaY = v, _translationalStiffnessByAreaY, null, "TranslationalStiffnessByAreaY", byte.MaxValue);
                    return;

                }
                if (value is Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure)
                {
                    LinearStiffnessByAreaY = new MeasureResource.IfcModulusOfSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure)value);
                    if (_translationalStiffnessByAreaY != null)
                        SetValue(v => _translationalStiffnessByAreaY = v, _translationalStiffnessByAreaY, null, "TranslationalStiffnessByAreaY", byte.MaxValue);
                    return;
                }

                SetValue(v => _translationalStiffnessByAreaY = v, _translationalStiffnessByAreaY, value, "TranslationalStiffnessByAreaY", byte.MaxValue);
                return;

                //##
				NotifyPropertyChanged("TranslationalStiffnessByAreaY");
				
			}
		}
		IIfcModulusOfSubgradeReactionSelect IIfcBoundaryFaceCondition.TranslationalStiffnessByAreaZ 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByAreaZ for which no match was found
                if (_translationalStiffnessByAreaZ != null)
                    return _translationalStiffnessByAreaZ;

                var value = LinearStiffnessByAreaZ;
                if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure(value.Value);
                //##
			} 
			set
			{
				//## Handle setting of TranslationalStiffnessByAreaZ for which no match was found
                if (value == null)
                {
                    LinearStiffnessByAreaZ = null;
                    if (_translationalStiffnessByAreaZ != null)
                        SetValue(v => _translationalStiffnessByAreaZ = v, _translationalStiffnessByAreaZ, null, "TranslationalStiffnessByAreaZ", byte.MaxValue);
                    return;

                }
                if (value is Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure)
                {
                    LinearStiffnessByAreaZ = new MeasureResource.IfcModulusOfSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure)value);
                    if (_translationalStiffnessByAreaZ != null)
                        SetValue(v => _translationalStiffnessByAreaZ = v, _translationalStiffnessByAreaZ, null, "TranslationalStiffnessByAreaZ", byte.MaxValue);
                    return;
                }

                SetValue(v => _translationalStiffnessByAreaZ = v, _translationalStiffnessByAreaZ, value, "TranslationalStiffnessByAreaZ", byte.MaxValue);
                return;

                //##
				NotifyPropertyChanged("TranslationalStiffnessByAreaZ");
				
			}
		}
	//## Custom code
        private IIfcModulusOfSubgradeReactionSelect _translationalStiffnessByAreaX;
        private IIfcModulusOfSubgradeReactionSelect _translationalStiffnessByAreaY;
        private IIfcModulusOfSubgradeReactionSelect _translationalStiffnessByAreaZ;
	    //##
	}
}