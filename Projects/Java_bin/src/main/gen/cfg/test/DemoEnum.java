
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;
public enum DemoEnum
{
    /**
     * aa
     */
    A(1),
    /**
     * bb
     */
    B(2),
    /**
     * cc
     */
    C(4),
    /**
     * dd
     */
    D(5),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    DemoEnum(int value) {
        this.value = value;
    }

    public static DemoEnum valueOf(int value) {
        if (value == 1) return A;
        if (value == 2) return B;
        if (value == 4) return C;
        if (value == 5) return D;
        throw new IllegalArgumentException("");
    }
}

