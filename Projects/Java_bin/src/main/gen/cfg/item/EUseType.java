
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.item;
/**
 * 
 */
public enum EUseType
{
    /**
     * 
     */
    MANUAL(0),
    /**
     * 
     */
    AUTO(1),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EUseType(int value) {
        this.value = value;
    }

    public static EUseType valueOf(int value) {
        if (value == 0) return MANUAL;
        if (value == 1) return AUTO;
        throw new IllegalArgumentException("");
    }
}

