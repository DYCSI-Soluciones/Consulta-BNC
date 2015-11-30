
//------------------------------------------------------------------------------
// 
//     This code was generated by a SAP. NET Connector Proxy Generator Version 2.0
//     Created at 16/12/2010
//     Created from Windows
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// 
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace ZConsultaBuro
{
  /// <summary>
  /// A typed collection of Z00_BURO_HI elements.
  /// </summary>
  [Serializable]
  public class Z00_BURO_HITable : SAPTable 
  {
  
    /// <summary>
    /// Returns the element type Z00_BURO_HI.
    /// </summary>
    /// <returns>The type Z00_BURO_HI.</returns>
    public override Type GetElementType() 
    {
        return (typeof(Z00_BURO_HI));
    }

    /// <summary>
    /// Creates an empty new row of type Z00_BURO_HI.
    /// </summary>
    /// <returns>The newZ00_BURO_HI.</returns>
    public override object CreateNewRow()
    { 
        return new Z00_BURO_HI();
    }
     
    /// <summary>
    /// The indexer of the collection.
    /// </summary>
    public Z00_BURO_HI this[int index] 
    {
        get 
        {
            return ((Z00_BURO_HI)(List[index]));
        }
        set 
        {
            List[index] = value;
        }
    }
        
    /// <summary>
    /// Adds a Z00_BURO_HI to the end of the collection.
    /// </summary>
    /// <param name="value">The Z00_BURO_HI to be added to the end of the collection.</param>
    /// <returns>The index of the newZ00_BURO_HI.</returns>
    public int Add(Z00_BURO_HI value) 
    {
        return List.Add(value);
    }
        
    /// <summary>
    /// Inserts a Z00_BURO_HI into the collection at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which value should be inserted.</param>
    /// <param name="value">The Z00_BURO_HI to insert.</param>
    public void Insert(int index, Z00_BURO_HI value) 
    {
        List.Insert(index, value);
    }
        
    /// <summary>
    /// Searches for the specified Z00_BURO_HI and returnes the zero-based index of the first occurrence in the collection.
    /// </summary>
    /// <param name="value">The Z00_BURO_HI to locate in the collection.</param>
    /// <returns>The index of the object found or -1.</returns>
    public int IndexOf(Z00_BURO_HI value) 
    {
        return List.IndexOf(value);
    }
        
    /// <summary>
    /// Determines wheter an element is in the collection.
    /// </summary>
    /// <param name="value">The Z00_BURO_HI to locate in the collection.</param>
    /// <returns>True if found; else false.</returns>
    public bool Contains(Z00_BURO_HI value) 
    {
        return List.Contains(value);
    }
        
    /// <summary>
    /// Removes the first occurrence of the specified Z00_BURO_HI from the collection.
    /// </summary>
    /// <param name="value">The Z00_BURO_HI to remove from the collection.</param>
    public void Remove(Z00_BURO_HI value) 
    {
        List.Remove(value);
    }

    /// <summary>
    /// Copies the contents of the Z00_BURO_HITable to the specified one-dimensional array starting at the specified index in the target array.
    /// </summary>
    /// <param name="array">The one-dimensional destination array.</param>           
    /// <param name="index">The zero-based index in array at which copying begins.</param>           
    public void CopyTo(Z00_BURO_HI[] array, int index) 
    {
        List.CopyTo(array, index);
	}
  }
}
