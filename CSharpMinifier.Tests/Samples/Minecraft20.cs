﻿// https://code.google.com/p/minecraft-19lines/source/browse/trunk/Minecraft20/Program.cs
class Minecraft20
{
	static void Main(string[] args)
	{
		ops.Add(delegate(int _pos) { System.Console.SetCursorPosition(int.Parse(data.Substring(int.Parse(data.Substring(_pos + arg1, numLen)), numLen)) % width, int.Parse(data.Substring(int.Parse(data.Substring(_pos + arg1, numLen)), numLen)) / width); });
		ops.Add(delegate(int _pos) { System.Console.Write(data.Substring(int.Parse(data.Substring(_pos + arg1, numLen)), int.Parse(data.Substring(_pos + arg2, numLen)))); });
		ops.Add(delegate(int _pos) { data = data.Remove(int.Parse(data.Substring(_pos + arg1, numLen)), 1).Insert(int.Parse(data.Substring(_pos + arg1, numLen)), new string(new char[] { System.Console.ReadKey(true).KeyChar })); });
		ops.Add(delegate(int _pos) { data = data.Remove(int.Parse(data.Substring(_pos + arg1, numLen)) + int.Parse(data.Substring(int.Parse(data.Substring(_pos + arg2, numLen)), numLen)), (data[_pos + arg3 + numLen] - 'a')).Insert(int.Parse(data.Substring(_pos + arg1, numLen)) + int.Parse(data.Substring(int.Parse(data.Substring(_pos + arg2, numLen)), numLen)), data.Substring(int.Parse(data.Substring(_pos + arg3, numLen)), (data[_pos + arg3 + numLen] - 'a'))); });
		ops.Add(delegate(int _pos) { data = data.Remove(int.Parse(data.Substring(_pos + arg1, numLen)), numLen).Insert(int.Parse(data.Substring(_pos + arg1, numLen)), (int.Parse(data.Substring(int.Parse(data.Substring(_pos + arg1, numLen)), numLen)) + int.Parse(data.Substring(int.Parse(data.Substring(_pos + arg2, numLen)), numLen))).ToString("0000;-000")); });
		ops.Add(delegate(int _pos) { pos = (data.Substring(int.Parse(data.Substring(_pos + arg1, numLen)) + int.Parse(data.Substring(int.Parse(data.Substring(_pos + arg2, numLen)), numLen)), (data[_pos + arg5] - 'a')) == data.Substring(int.Parse(data.Substring(_pos + arg3, numLen)), (data[_pos + arg5] - 'a')) == (data[_pos + arg5 + lenLen] != 'a')) ? int.Parse(data.Substring(_pos + arg4, numLen)) : pos; });
	begin:
		string op = data.Substring(pos, nameLen + lenLen);
		pos += (op[nameLen] - 'a');
		ops[op[0] - 'a'](pos - (op[nameLen] - 'a'));
		goto begin;
	}
	private static int pos = 0, nameLen = 1, lenLen = 1, numLen = 4, width = 80, arg1 = nameLen + lenLen, arg2 = arg1 + numLen, arg3 = arg2 + numLen, arg4 = arg3 + numLen, arg5 = arg4 + numLen;
	private static System.Collections.Generic.List<System.Action<int>> ops = new System.Collections.Generic.List<System.Action<int>>();
	private static string data = "fv0021002100212023eb 00000001-001\n000000010800008010381920-0010001-08000808adwsADWS12345 @#+~Ww. 01850000     ###`   ##``##``##`  ##``######  ######  ######``######``######`#######    \n     ###`` ###``##``###``##``##````  ##````  ##``##``#````#``##````````##``    \n     ###```###``##``###``##``##````  ##````  ##``#```#````#``##````````##`     \n    `########```##``##`####``######  ##````  #####```##```#``#######```###     \n    ###`##`##``##``###`####``##````  ##      ##``##``######``###````````##     \n   `##``#``##``##``##```###``##````  ##      ##``##``###`##```##```  ```##`    \n   ##``````##``##``##```##```#####`  ######  ##``##``###``##``##``   ```###    \n   ##`````###``##``##```##````#####  ######  `#``###``##``##``##`    ````##    \n   `````  ````````````  ```````````  ``````  ``  ```````````````      `````    \n    ````   ```````````   ``````````  ``````  ``  `` ```````````       ````     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n@                                                                             @\n@             ###+                                     +#########+            @\n@             ####+                                 +###############+         @\n@             +++++                                +#####        ####+        @\n@#            +###+   +##### #+         ++         +####         #########++##@\n@##~~~~~~~~~~~+###+######### ##+        +#+       +#####          #######  +##@\n@###~~~~~~~~~~####+######### ###+      +##+ +##########            #####  +###@\n@###~~~~~~~~~~####+######### ####+    +################                  +####@\n@######+++########+######### ######+##################   +##~~~~~~~###########@\n@######+++########+## +####   #####+##############      +#####~~~~############@\n@#++++++++##    ##+## +###         +   ###########     +######################@\n@###+++W+++++   +++   +        +#####+                +#######################@\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@bk01050799ag0042bk09041119fv0021002100212074eb 0000dp207000210042eek20700097ag2070bk00740001ag0054cg0096fv0021002100212152eb 0000fv0021002100212181eb 00000000dp010100210034efv0904009700882295bb fv0904009700942295bb fv0904009700932295bb dp217300210034efv0021002100212310eb dp217300210038efv2173002100342506eb dp217700210097eek21770070fv0904217700892455bb fv0904217700902455bb fv0904217700912455bb dp217300210034efv0021002100212470eb dp217300210038efv2173002100382506eb dp010100210038efv0101002100342558eb ek00970070fv0021002100214248eb fv0021002100212587eb 00000000dp214800210034efv0096002100752840ba dp258300210097eek25830058fv0904258300882789bb fv0904258300912789bb fv0904258300922789bb fv0904258300942789bb fv0904258300932789bb dp257900210034efv0021002100212804eb dp257900210038efv2579002100342840eb dp214800210038efv2148002100342892eb ek00970058fv0021002100214248eb fv0021002100212921eb 00000000dp214800210034efv0096002100763174ba dp291700210097eek29170062fv0904291700883123bb fv0904291700913123bb fv0904291700923123bb fv0904291700943123bb fv0904291700933123bb dp291300210034efv0021002100213138eb dp291300210038efv2913002100343174eb dp214800210038efv2148002100343226eb ek00970062fv0021002100214248eb fv0021002100213255eb 00000000dp214800210034efv0096002100773883ba dp325100210097eek32510066fv0904325100883457bb fv0904325100913457bb fv0904325100923457bb fv0904325100943457bb fv0904325100933457bb dp324700210034efv0021002100213472eb dp324700210038efv3247002100343883eb fv0021002100213522eb 00000000dp324700210034efv0904325100883636bb fv0904325100943636bb fv0904325100933636bb dp351400210034efv0021002100213651eb dp351400210038efv3514002100343847eb dp351800213251eek35180070fv0904351800893796bb fv0904351800903796bb fv0904351800913796bb dp351400210034efv0021002100213811eb dp351400210038efv3514002100383847eb dp324700210038efv3247002100383883eb dp214800210038efv2148002100343935eb ek00970066fv0021002100214248eb fv0021002100213964eb 00000000dp214800210034efv0096002100784217ba dp396000210097eek39600070fv0904396000884166bb fv0904396000914166bb fv0904396000924166bb fv0904396000944166bb fv0904396000934166bb dp395600210034efv0021002100214181eb dp395600210038efv3956002100344217eb dp214800210038efv2148002100344248eb ek00970070fv0101002100385241eb fv0021002100214298eb 00000000fv0096002100794473ba dp429400210097eek42940058fv0904429400904401bb dp429000210034efv0021002100214416eb dp429000210038efv4290002100344473eb dp090442940088bfv0021002100214977eb fv0096002100804648ba dp429400210097eek42940062fv0904429400904576bb dp429000210034efv0021002100214591eb dp429000210038efv4290002100344648eb dp090442940088bfv0021002100214977eb fv0096002100814823ba dp429400210097eek42940066fv0904429400904751bb dp429000210034efv0021002100214766eb dp429000210038efv4290002100344823eb dp090442940088bfv0021002100214977eb fv0096002100824977ba dp429400210097eek42940070fv0904429400904926bb dp429000210034efv0021002100214941eb dp429000210038efv4290002100344977eb dp090442940088bfv0096002100835034ba dp090400970088bfv0021002100215241eb fv0096002100845091ba dp090400970090bfv0021002100215241eb fv0096002100855148ba dp090400970091bfv0021002100215241eb fv0096002100865205ba dp090400970092bfv0021002100215241eb fv0096002100875241ba dp090400970093bfv0021002100215266eb 0000dp526200210046efv0021002100215306eb 0000fv0904526200885510ba dp530200215262eek53020058fv0904530200925388ba dp090452620095bdp530200215262eek53020062fv0904530200925449ba dp090452620095bdp530200215262eek53020066fv0904530200925510ba dp090452620095bfv0021002100215535eb 0000fv0904526200945739ba dp553100215262eek55310058fv0904553100925617ba dp090452620095bdp553100215262eek55310062fv0904553100925678ba dp090452620095bdp553100215262eek55310066fv0904553100925739ba dp090452620095bfv0021002100215764eb 0000fv0904526200935968ba dp576000215262eek57600058fv0904576000925846ba dp090452620095bdp576000215262eek57600062fv0904576000925907ba dp090452620095bdp576000215262eek57600066fv0904576000925968ba dp090452620095bek52620025fv5262002100506020eb fv0021002100215281eb dp526200210046efv0904526200956071ba dp090452620092bek52620025fv5262002100506123eb fv0021002100216035eb dp526200210046efv0021002100216163eb 0000fv0904526200916367ba dp615900215262eek61590058fv0904615900946245ba dp090452620095bdp615900215262eek61590062fv0904615900946306ba dp090452620095bdp615900215262eek61590070fv0904615900946367ba dp090452620095bfv0021002100216392eb 0000fv0904526200916596ba dp638800215262eek63880058fv0904638800936474ba dp090452620095bdp638800215262eek63880062fv0904638800936535ba dp090452620095bdp638800215262eek63880070fv0904638800936596ba dp090452620095bek52620025fv5262002100506648eb fv0021002100216138eb dp526200210046efv0904526200956699ba dp090452620094bek52620025fv5262002100506751eb fv0021002100216663eb dp526200210046efv0904526200936802ba dp090452620095bfv0904526200946838ba dp090452620093bek52620025fv5262002100506890eb fv0021002100216766eb dp526200210046efv0904526200956941ba dp090452620094bek52620025fv5262002100506993eb fv0021002100216905eb ag0042bk09041119fv0021002100217034eb 0000dp703000210042eek70300097ag7030bk00740001ag0054fv0021002100212121eb ";
}