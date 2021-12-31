global using Astrum.AstralCore;
global using Astrum.AstralCore.UI.Attributes;
global using VRC.SDKBase;
using MelonLoader;
using System.Windows.Forms;

[assembly: MelonInfo(typeof(FutureYield.FutureYield), nameof(FutureYield.FutureYield), "acuus", downloadLink: "github.com/xMiraiChan/FutureYield")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace FutureYield
{
    public class FutureYield : MelonMod
    {
        public override void OnApplicationStart()
        {
            if (int.TryParse(((string)typeof(BuildInfo).GetField(nameof(BuildInfo.Version)).GetValue(null)).Replace(".", ""), out int version))
            {
                if (int.TryParse(BuildInfo.Version.Replace(".", ""), out int buildVer))
                {
                    if (buildVer > version)
                    {
                        MessageBox.Show("Your MelonLoader is outdated.", "Outdated Loader");
                        System.Diagnostics.Process.Start("https://github.com/HerpDerpinstine/MelonLoader/releases/latest");
                    }
                    else if (version > buildVer)
                    {
                        LoggerInstance.Warning("Your MelonLoader is too new.");
                        LoggerInstance.Warning("This mod is written for MelonLoader version " + BuildInfo.Version);
                        LoggerInstance.Warning("The mod may work correctly however support will not be provided.");
                    }
                }
            }

            if (UnityEngine.Random.Range(1, 8192) == 1)
                LoggerInstance.Msg("\r\tyyyyyyyyyhshosmMMMMMMN:NNMMMMMMMMMMMMMMMMMMMMms/syyyyyyyyyyyyy\n\ty/.---../+yMMMMMMMMMmsyMMMMMMMMMMMMMMMMMMMMMMMMMy+yyyyyyyyyyyy\n\ty-yyyyoNo.++yyyyhhhhmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMyoyyyyyyyyyy\n\tysoyyyshs/s`/+ssssssyhmMMMMMMMMMMMMMMMMMMMMMMMMMMMMNsyyyyyyyyy\n\tyyyosyhohy:sMMMMMMMmNNhssyhNMMMMMMMMMMMMMMMMMMMMMMMMMdyyyyyyyy\n\tyyyyyoos+:dmMMMMMMMmyNdNNMmy+odMMMMMMMMMMMMMMMMMMMMMMN+yyyyyyy\n\tyyyyyyys+sy+smMMMMmd//oydmNmhsy//yNMMMMMMMMMMMMMMMMMN:/yyyyyyy\n\tyyyyyyyy-ymhdhhhdmdmd+dMMdyss/sMNs`/yMMMMMMMMMMMMMMN:`+yyyyyyy\n\tyyyyyyyy/oMNsMNmmmmmh/mMMydNh:.sNM.ys-omMMMMMMMMMMN:``oyyyyyyy\n\tyyyyyyysdoMMsoNMMMMMNm/NdNs-/oo:-d:sMNs`/dMMMMMMMd:-:/yyyyyyyy\n\tyyyyyyysmNhMM/.yMmNMMMMyyMhmsyy/mNo/MMyd-`/mMMMMh/+oo+hyyyyyyy\n\tyyyyyyysNMymNm``:hMMMMMMhohMNddyMyMydmmMy`:`hMNyossyy+yyyyyyyy\n\tyyyyyyyoMMy:mMh`:hoyydMMMhNMMMMhyhMMdmMMm.m..Myyyhyhssyyyyyyyy\n\tyyyyyyyoMNs`.hy+:-oMMhhhdMMMMMMsyoMmMMMMN-N`sdddhddm+yyyyyyyyy\n\tyyyyyyyoMy`  sh. ` /dNMMMMMMMMNdNsMmMMMMdos:mhmmmmm+oyyyyyyyyy\n\tyyyyyyyyh.   `md.  -:MMMMMMMMMddm+MdMMMM+o`dhmmmdh/-yyyyyyyyyy\n\tyyyyyyysy+`   -MN:.`/-shNMMMNMMNm+MyMMdh``yhmdyydh`syyyyyyyyyy\n\tyyyyyyyyys:    /Mmhs:.``..:+so-`:oN-MNo-`+M+hdMMm`-yyyyyyyyyyy\n\tyyyyyyyyyys.    /dsNNo-.--.:/+oo+h/+m+:+:MMMMMMm.  -syyyyyyyyy\n\tyyyyyyyyyyyy/`   -s-smd/:+`/++++:+/s+oo:NMMMMMh.+d:``+hyyyyyyy\n\tyyyyyyyyyyyyyy+:` -/-.:o//-+:o+/osooyy/NMMMMMo/mMMMh/.:yyyyyyy\n\tyyyyyyyyyyyyyyyso.----:/+/-++/o++osss/mMMMMdsmMMMMMMMy--yyyyyy\n\tyyyyyyyyyyyyyyyyyo:--://s/-++oosyyys+NMMMmmNMMMMMMMMMMN+-yyyyy\n\tyyyyyyyyyyyyyyyyy+:/:/+os+.ooo+///:oMMNmmMMMMMMMMMMMMMMMy-yyyy\n\tyyyyyyyyyyyyyyyyy++/++ooss.`-: -hshMdhNMMMMMMMMMMMMMMMMMMd:yyy\n\tyyyyyyyyyyyyyyyyy+++/++sss/y-` :hmMMMMMMMMMMMMMMMMMMMMMMMMm/yy\n\tyyyyyyyyyyyyyyyyyoo+/o+oyy//  .hMMMMMMMMMMMMMMMMMMMMMMMMMMMh+y\n\tyyyyyyyyyyyyyyyyyoo++`..+h:.:hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMos\n\tyyyyyyyyyyyyyyyyyos/.oyys:/+hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN/\n\tyyyyyyyyyyyyyyyyyos::yoo:+-yMMMMMMMMMMMMMMMMMMMMMMMMMmNmyydMMo\n\tyyyyyyyyyyyyyyyyyoy:+yss.++mMMMMMMMMMMMMdMMMMMMMNmmmNMMMMmhshs\n\t");
        }
    }
}
