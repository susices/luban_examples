//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;
public enum ENotifyObserverMode {
    ON_VALUE_CHANGE(0),
    ON_RESULT_CHANGE(1),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    ENotifyObserverMode(int value) {
        this.value = value;
    }

    public static ENotifyObserverMode valueOf(int value) {
        if (value == 0) return ON_VALUE_CHANGE;
        if (value == 1) return ON_RESULT_CHANGE;
        throw new IllegalArgumentException("");
    }
}
