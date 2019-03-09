using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum ColorTheory
{
    Opposite,
    Triad,

}
public static class ColorPicker {

    static public void GetOppositeColor(ref Color []master,ref Color[]slave)
    {

        float h, s, v;
        Color.RGBToHSV(master[0], out h, out s, out v);

        for (int i = 1; i < master.Length; i++)
        {
            float t;
            Color.RGBToHSV(master[i], out t, out s, out v);
            master[i] = Color.HSVToRGB(h, s, v);
        }
        h += .5f;
        h =(h>1f)?1-h:h;
        for (int i = 1; i < slave.Length; i++)
        {
            float t;
            Color.RGBToHSV(slave[i], out t, out s, out v);
            slave[i] = Color.HSVToRGB(h, s, v);
        }
    }
}
