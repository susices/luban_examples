
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.common;
public enum EBoolOperator {
    AND(0),
    OR(1),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EBoolOperator(int value) {
        this.value = value;
    }

    public static EBoolOperator valueOf(int value) {
        if (value == 0) return AND;
        if (value == 1) return OR;
        throw new IllegalArgumentException("");
    }
}
